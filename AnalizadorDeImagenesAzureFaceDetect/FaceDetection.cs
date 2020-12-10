using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace AnalizadorDeImagenesAzureFaceDetect
{
    class FaceDetection
    {
        public string resultad;
       

      FaceDetectResponse fd1 = new FaceDetectResponse();
        FaceDetectResponse fd2 = new FaceDetectResponse();

        string faceId_1 = "";
        string faceId_2 = "";

        string urlVerify = "";

        byte[] data1, data2, respuesta1, respuesta2;

        const string SuscripcionKey = "c2f574b73d9e42289d2bc2e1be6eab97";


        const string urlBase =
            "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";

        string urlObtenerFaceId = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect?returnFaceId=true";


        public async void HacerElAnalisisDeDeteccion(string direccionDeImagenPath)
        {
            HttpClient cliente = new HttpClient();


            cliente.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", SuscripcionKey);


            string ParametrosRequest = "returnFaceId=false&returnFaceLandmarks=false" +
                "&returnFaceAttributes=age,gender,smile,glasses," +
                "emotion";


            string url = urlBase + "?" + ParametrosRequest;

            HttpResponseMessage rest;


            byte[] byteData = GetImageAsByteArray(direccionDeImagenPath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {

                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");


                rest = await cliente.PostAsync(url, content);


                string contentString = await rest.Content.ReadAsStringAsync();

                resultad = contentString;

                
            }

        }


        public string VerificacionDeRostros(string rutaDeImagen1, string rutaDeImagen2)
        {
            double resultado;
            FaceVerifyResponse respons3 = new FaceVerifyResponse();
            string verif = "";

            var faceId_2 = "";
            string resultadox;

            using (var q = new WebClient())
            {
                JavaScriptSerializer oJS = new JavaScriptSerializer();

                q.Headers.Add(HttpRequestHeader.ContentType, "application/octet-stream");
                q.Headers.Add("Ocp-Apim-Subscription-Key", "c2f574b73d9e42289d2bc2e1be6eab97");

                data1 = File.ReadAllBytes(rutaDeImagen1);
                respuesta1 = q.UploadData(urlObtenerFaceId, data1);
                var str1 = Encoding.UTF8.GetString(respuesta1);

                fd1 = JsonConvert.DeserializeObject<FaceDetectResponse[]>(str1)[0];
                

            }

            using (var q = new WebClient())
            {
                q.Headers.Add(HttpRequestHeader.ContentType, "application/octet-stream");
                q.Headers.Add("Ocp-Apim-Subscription-Key", "c2f574b73d9e42289d2bc2e1be6eab97");

                data2 = File.ReadAllBytes(rutaDeImagen2);
                respuesta2 = q.UploadData(urlObtenerFaceId, data2);
                string str2 = Encoding.UTF8.GetString(respuesta2);


                fd2 = JsonConvert.DeserializeObject<FaceDetectResponse[]>(str2)[0];
   

            }


            using (var q = new WebClient())
            {
                q.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                q.Headers.Add("Ocp-Apim-Subscription-Key", "c2f574b73d9e42289d2bc2e1be6eab97");
                 urlVerify = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/verify";
                string json = "{\"faceId1\":\"" + fd1.FaceId + "\", \"faceId2\":\"" + fd2.FaceId + "\" }";
                string str = q.UploadString(urlVerify, json);
                FaceVerifyResponse res = JsonConvert.DeserializeObject<FaceVerifyResponse>(str);

                 verif = str;
            }

            return verif;
        }


        public byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStreams =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStreams);
                return binaryReader.ReadBytes((int)fileStreams.Length);
            }
        }

        public string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            json = json.Replace(Environment.NewLine, "").Replace("\t", "");

            StringBuilder sb = new StringBuilder();
            bool quote = false;
            bool ignore = false;
            int offset = 0;
            int indentLength = 3;

            foreach (char ch in json)
            {
                switch (ch)
                {
                    case '"':
                        if (!ignore) quote = !quote;
                        break;
                    case '\'':
                        if (quote) ignore = !ignore;
                        break;
                }

                if (quote)
                    sb.Append(ch);
                else
                {
                    switch (ch)
                    {
                        case '{':
                        case '[':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', ++offset * indentLength));
                            break;
                        case '}':
                        case ']':
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', --offset * indentLength));
                            sb.Append(ch);
                            break;
                        case ',':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', offset * indentLength));
                            break;
                        case ':':
                            sb.Append(ch);
                            sb.Append(' ');
                            break;
                        default:
                            if (ch != ' ') sb.Append(ch);
                            break;
                    }
                }
            }

            return sb.ToString().Trim();
        }

    }
}
