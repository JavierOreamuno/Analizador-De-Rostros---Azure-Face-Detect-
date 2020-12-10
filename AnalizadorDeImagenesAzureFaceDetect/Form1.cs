using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorDeImagenesAzureFaceDetect
{
    public partial class Form1 : Form
    {
        FaceDetection faceDetectionIamgen1 = new FaceDetection();
        FaceDetection faceDetectionIamgen2 = new FaceDetection();
        FaceDetection deteccion = new FaceDetection();
        FaceDetection verificacioDeRostros = new FaceDetection();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnIngresarImagen1_Click(object sender, EventArgs e)
        {
            if (OfdSeleccionarImagen1.ShowDialog() == DialogResult.OK)
            {
                string direccionPathDeLaImagen1;

                PicMostrarImagen1.ImageLocation = OfdSeleccionarImagen1.FileName;
                direccionPathDeLaImagen1  = OfdSeleccionarImagen1.FileName;
                txtRutaImagen1.Text = direccionPathDeLaImagen1;
                

            }
            else 
            {
                MessageBox.Show("No se selecciono imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnIngresarImagen2_Click(object sender, EventArgs e)
        {
            if (OfdSeleccionarImagen2.ShowDialog() == DialogResult.OK)
            {
                string direccionPathDeLaImagen2;

                PicMostrarImagen2.ImageLocation = OfdSeleccionarImagen2.FileName;
                direccionPathDeLaImagen2 = OfdSeleccionarImagen2.FileName;
                txtRutaImagen2.Text = direccionPathDeLaImagen2;


            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
           
            faceDetectionIamgen1.HacerElAnalisisDeDeteccion(txtRutaImagen1.Text);          
            txtRespuestaDeApiFaceDetectJson1.Text = faceDetectionIamgen1.JsonPrettyPrint(faceDetectionIamgen1.resultad);
            

            faceDetectionIamgen2.HacerElAnalisisDeDeteccion(txtRutaImagen2.Text);
            txtRespuestaDeApiFaceDetectJson2.Text = faceDetectionIamgen2.JsonPrettyPrint(faceDetectionIamgen2.resultad);

           

            MessageBox.Show("Espere un momento mientras se procesan los resultados");

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string coincidencia;

            coincidencia = verificacioDeRostros.VerificacionDeRostros(txtRutaImagen1.Text, txtRutaImagen2.Text);

            txtResultadoDeVerificacion.Text = coincidencia.ToString();

            MessageBox.Show("Espere un momento mientras se procesan los resultados");
        }
    }
}
