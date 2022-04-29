namespace Parcial2
{
    partial class Pregunta1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregunta1));
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.rdbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion4 = new System.Windows.Forms.RadioButton();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Location = new System.Drawing.Point(158, 47);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(508, 15);
            this.lblPregunta1.TabIndex = 0;
            this.lblPregunta1.Text = "En la versión original de ‘Terminator 2’, qué dice el T-800 en lugar del famoso “" +
    "Sayonara Baby”? ";
            // 
            // rdbOpcion1
            // 
            this.rdbOpcion1.AutoSize = true;
            this.rdbOpcion1.Location = new System.Drawing.Point(99, 138);
            this.rdbOpcion1.Name = "rdbOpcion1";
            this.rdbOpcion1.Size = new System.Drawing.Size(121, 19);
            this.rdbOpcion1.TabIndex = 1;
            this.rdbOpcion1.TabStop = true;
            this.rdbOpcion1.Text = "Hasta luego Lucas";
            this.rdbOpcion1.UseVisualStyleBackColor = true;
            this.rdbOpcion1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbOpcion2
            // 
            this.rdbOpcion2.AutoSize = true;
            this.rdbOpcion2.Location = new System.Drawing.Point(99, 181);
            this.rdbOpcion2.Name = "rdbOpcion2";
            this.rdbOpcion2.Size = new System.Drawing.Size(93, 19);
            this.rdbOpcion2.TabIndex = 2;
            this.rdbOpcion2.TabStop = true;
            this.rdbOpcion2.Text = "Arigato Baby";
            this.rdbOpcion2.UseVisualStyleBackColor = true;
            this.rdbOpcion2.CheckedChanged += new System.EventHandler(this.rdbOpcion2_CheckedChanged);
            // 
            // rdbOpcion3
            // 
            this.rdbOpcion3.AutoSize = true;
            this.rdbOpcion3.Location = new System.Drawing.Point(99, 225);
            this.rdbOpcion3.Name = "rdbOpcion3";
            this.rdbOpcion3.Size = new System.Drawing.Size(126, 19);
            this.rdbOpcion3.TabIndex = 3;
            this.rdbOpcion3.TabStop = true;
            this.rdbOpcion3.Text = "Hasta la vista, Baby";
            this.rdbOpcion3.UseVisualStyleBackColor = true;
            this.rdbOpcion3.CheckedChanged += new System.EventHandler(this.rdbOpcion3_CheckedChanged);
            // 
            // rdbOpcion4
            // 
            this.rdbOpcion4.AutoSize = true;
            this.rdbOpcion4.Location = new System.Drawing.Point(99, 269);
            this.rdbOpcion4.Name = "rdbOpcion4";
            this.rdbOpcion4.Size = new System.Drawing.Size(106, 19);
            this.rdbOpcion4.TabIndex = 4;
            this.rdbOpcion4.TabStop = true;
            this.rdbOpcion4.Text = "La buena mi fai";
            this.rdbOpcion4.UseVisualStyleBackColor = true;
            this.rdbOpcion4.CheckedChanged += new System.EventHandler(this.rdbOpcion4_CheckedChanged);
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Location = new System.Drawing.Point(112, 318);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente1.TabIndex = 5;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pregunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 456);
            this.Controls.Add(this.btnSiguiente1);
            this.Controls.Add(this.rdbOpcion4);
            this.Controls.Add(this.rdbOpcion3);
            this.Controls.Add(this.rdbOpcion2);
            this.Controls.Add(this.rdbOpcion1);
            this.Controls.Add(this.lblPregunta1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pregunta1";
            this.Text = "Pregunta1";
            this.Load += new System.EventHandler(this.Pregunta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta1;
        private RadioButton rdbOpcion1;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion3;
        private RadioButton rdbOpcion4;
        private Button btnSiguiente1;
        private PictureBox pictureBox1;
    }
}