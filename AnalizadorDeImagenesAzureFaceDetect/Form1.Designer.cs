namespace AnalizadorDeImagenesAzureFaceDetect
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresarImagen1 = new System.Windows.Forms.Button();
            this.PicMostrarImagen1 = new System.Windows.Forms.PictureBox();
            this.OfdSeleccionarImagen1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRutaImagen1 = new System.Windows.Forms.TextBox();
            this.lblRutaDeLaImagen1 = new System.Windows.Forms.Label();
            this.lblImagenQueSeAnaliza = new System.Windows.Forms.Label();
            this.txtRespuestaDeApiFaceDetectJson1 = new System.Windows.Forms.TextBox();
            this.lblAnalisisFaceApiJson = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.PicMostrarImagen2 = new System.Windows.Forms.PictureBox();
            this.txtRutaImagen2 = new System.Windows.Forms.TextBox();
            this.btnIngresarImagen2 = new System.Windows.Forms.Button();
            this.lblRutaDeLaImagen2 = new System.Windows.Forms.Label();
            this.txtRespuestaDeApiFaceDetectJson2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultadoDeVerificacion = new System.Windows.Forms.TextBox();
            this.OfdSeleccionarImagen2 = new System.Windows.Forms.OpenFileDialog();
            this.btnVerificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarImagen1
            // 
            this.btnIngresarImagen1.Location = new System.Drawing.Point(170, 24);
            this.btnIngresarImagen1.Name = "btnIngresarImagen1";
            this.btnIngresarImagen1.Size = new System.Drawing.Size(117, 22);
            this.btnIngresarImagen1.TabIndex = 0;
            this.btnIngresarImagen1.Text = "Ingresar Imagen";
            this.btnIngresarImagen1.UseVisualStyleBackColor = true;
            this.btnIngresarImagen1.Click += new System.EventHandler(this.btnIngresarImagen1_Click);
            // 
            // PicMostrarImagen1
            // 
            this.PicMostrarImagen1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PicMostrarImagen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicMostrarImagen1.Location = new System.Drawing.Point(12, 51);
            this.PicMostrarImagen1.Name = "PicMostrarImagen1";
            this.PicMostrarImagen1.Size = new System.Drawing.Size(275, 188);
            this.PicMostrarImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMostrarImagen1.TabIndex = 1;
            this.PicMostrarImagen1.TabStop = false;
            // 
            // OfdSeleccionarImagen1
            // 
            this.OfdSeleccionarImagen1.Title = "Seleccionar Imagen";
            this.OfdSeleccionarImagen1.ValidateNames = false;
            // 
            // txtRutaImagen1
            // 
            this.txtRutaImagen1.Location = new System.Drawing.Point(12, 25);
            this.txtRutaImagen1.Name = "txtRutaImagen1";
            this.txtRutaImagen1.Size = new System.Drawing.Size(162, 20);
            this.txtRutaImagen1.TabIndex = 2;
            // 
            // lblRutaDeLaImagen1
            // 
            this.lblRutaDeLaImagen1.AutoSize = true;
            this.lblRutaDeLaImagen1.Location = new System.Drawing.Point(9, 9);
            this.lblRutaDeLaImagen1.Name = "lblRutaDeLaImagen1";
            this.lblRutaDeLaImagen1.Size = new System.Drawing.Size(119, 13);
            this.lblRutaDeLaImagen1.TabIndex = 3;
            this.lblRutaDeLaImagen1.Text = "Ruta de la Imagen: ";
            // 
            // lblImagenQueSeAnaliza
            // 
            this.lblImagenQueSeAnaliza.AutoSize = true;
            this.lblImagenQueSeAnaliza.Location = new System.Drawing.Point(655, 36);
            this.lblImagenQueSeAnaliza.Name = "lblImagenQueSeAnaliza";
            this.lblImagenQueSeAnaliza.Size = new System.Drawing.Size(198, 13);
            this.lblImagenQueSeAnaliza.TabIndex = 4;
            this.lblImagenQueSeAnaliza.Text = "Datos de Verificacion de Rostros:";
            // 
            // txtRespuestaDeApiFaceDetectJson1
            // 
            this.txtRespuestaDeApiFaceDetectJson1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRespuestaDeApiFaceDetectJson1.Location = new System.Drawing.Point(12, 274);
            this.txtRespuestaDeApiFaceDetectJson1.Multiline = true;
            this.txtRespuestaDeApiFaceDetectJson1.Name = "txtRespuestaDeApiFaceDetectJson1";
            this.txtRespuestaDeApiFaceDetectJson1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaDeApiFaceDetectJson1.Size = new System.Drawing.Size(275, 156);
            this.txtRespuestaDeApiFaceDetectJson1.TabIndex = 5;
            // 
            // lblAnalisisFaceApiJson
            // 
            this.lblAnalisisFaceApiJson.AutoSize = true;
            this.lblAnalisisFaceApiJson.Location = new System.Drawing.Point(36, 255);
            this.lblAnalisisFaceApiJson.Name = "lblAnalisisFaceApiJson";
            this.lblAnalisisFaceApiJson.Size = new System.Drawing.Size(214, 13);
            this.lblAnalisisFaceApiJson.TabIndex = 6;
            this.lblAnalisisFaceApiJson.Text = "Resultado del Analisis del 1° Rostro:";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(276, 245);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(87, 23);
            this.btnAnalizar.TabIndex = 7;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // PicMostrarImagen2
            // 
            this.PicMostrarImagen2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PicMostrarImagen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicMostrarImagen2.Location = new System.Drawing.Point(348, 51);
            this.PicMostrarImagen2.Name = "PicMostrarImagen2";
            this.PicMostrarImagen2.Size = new System.Drawing.Size(275, 188);
            this.PicMostrarImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMostrarImagen2.TabIndex = 8;
            this.PicMostrarImagen2.TabStop = false;
            // 
            // txtRutaImagen2
            // 
            this.txtRutaImagen2.Location = new System.Drawing.Point(348, 27);
            this.txtRutaImagen2.Name = "txtRutaImagen2";
            this.txtRutaImagen2.Size = new System.Drawing.Size(162, 20);
            this.txtRutaImagen2.TabIndex = 9;
            // 
            // btnIngresarImagen2
            // 
            this.btnIngresarImagen2.Location = new System.Drawing.Point(506, 27);
            this.btnIngresarImagen2.Name = "btnIngresarImagen2";
            this.btnIngresarImagen2.Size = new System.Drawing.Size(117, 22);
            this.btnIngresarImagen2.TabIndex = 10;
            this.btnIngresarImagen2.Text = "Ingresar Imagen";
            this.btnIngresarImagen2.UseVisualStyleBackColor = true;
            this.btnIngresarImagen2.Click += new System.EventHandler(this.btnIngresarImagen2_Click);
            // 
            // lblRutaDeLaImagen2
            // 
            this.lblRutaDeLaImagen2.AutoSize = true;
            this.lblRutaDeLaImagen2.Location = new System.Drawing.Point(345, 9);
            this.lblRutaDeLaImagen2.Name = "lblRutaDeLaImagen2";
            this.lblRutaDeLaImagen2.Size = new System.Drawing.Size(119, 13);
            this.lblRutaDeLaImagen2.TabIndex = 11;
            this.lblRutaDeLaImagen2.Text = "Ruta de la Imagen: ";
            // 
            // txtRespuestaDeApiFaceDetectJson2
            // 
            this.txtRespuestaDeApiFaceDetectJson2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRespuestaDeApiFaceDetectJson2.Location = new System.Drawing.Point(348, 274);
            this.txtRespuestaDeApiFaceDetectJson2.Multiline = true;
            this.txtRespuestaDeApiFaceDetectJson2.Name = "txtRespuestaDeApiFaceDetectJson2";
            this.txtRespuestaDeApiFaceDetectJson2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaDeApiFaceDetectJson2.Size = new System.Drawing.Size(275, 156);
            this.txtRespuestaDeApiFaceDetectJson2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Resultado del Analisis del 2° Rostro:";
            // 
            // txtResultadoDeVerificacion
            // 
            this.txtResultadoDeVerificacion.Location = new System.Drawing.Point(658, 52);
            this.txtResultadoDeVerificacion.Multiline = true;
            this.txtResultadoDeVerificacion.Name = "txtResultadoDeVerificacion";
            this.txtResultadoDeVerificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoDeVerificacion.Size = new System.Drawing.Size(263, 47);
            this.txtResultadoDeVerificacion.TabIndex = 14;
            // 
            // OfdSeleccionarImagen2
            // 
            this.OfdSeleccionarImagen2.Title = "Seleccionar Imagen";
            this.OfdSeleccionarImagen2.ValidateNames = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(778, 105);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 15;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 442);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtResultadoDeVerificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRespuestaDeApiFaceDetectJson2);
            this.Controls.Add(this.lblRutaDeLaImagen2);
            this.Controls.Add(this.btnIngresarImagen2);
            this.Controls.Add(this.txtRutaImagen2);
            this.Controls.Add(this.PicMostrarImagen2);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.lblAnalisisFaceApiJson);
            this.Controls.Add(this.txtRespuestaDeApiFaceDetectJson1);
            this.Controls.Add(this.lblImagenQueSeAnaliza);
            this.Controls.Add(this.lblRutaDeLaImagen1);
            this.Controls.Add(this.txtRutaImagen1);
            this.Controls.Add(this.PicMostrarImagen1);
            this.Controls.Add(this.btnIngresarImagen1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Analizador de Restros en una Foto";
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarImagen1;
        private System.Windows.Forms.PictureBox PicMostrarImagen1;
        private System.Windows.Forms.OpenFileDialog OfdSeleccionarImagen1;
        private System.Windows.Forms.TextBox txtRutaImagen1;
        private System.Windows.Forms.Label lblRutaDeLaImagen1;
        private System.Windows.Forms.Label lblImagenQueSeAnaliza;
        private System.Windows.Forms.TextBox txtRespuestaDeApiFaceDetectJson1;
        private System.Windows.Forms.Label lblAnalisisFaceApiJson;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.PictureBox PicMostrarImagen2;
        private System.Windows.Forms.TextBox txtRutaImagen2;
        private System.Windows.Forms.Button btnIngresarImagen2;
        private System.Windows.Forms.Label lblRutaDeLaImagen2;
        private System.Windows.Forms.TextBox txtRespuestaDeApiFaceDetectJson2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultadoDeVerificacion;
        private System.Windows.Forms.OpenFileDialog OfdSeleccionarImagen2;
        private System.Windows.Forms.Button btnVerificar;
    }
}

