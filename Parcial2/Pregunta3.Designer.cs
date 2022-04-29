namespace Parcial2
{
    partial class Pregunta3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPregunta3 = new System.Windows.Forms.Label();
            this.txtPregunta3 = new System.Windows.Forms.TextBox();
            this.btnSiguiente3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta3
            // 
            this.lblPregunta3.AutoSize = true;
            this.lblPregunta3.Location = new System.Drawing.Point(153, 61);
            this.lblPregunta3.Name = "lblPregunta3";
            this.lblPregunta3.Size = new System.Drawing.Size(266, 15);
            this.lblPregunta3.TabIndex = 0;
            this.lblPregunta3.Text = "En todas las películas  de la saga, se repite la frase";
            this.lblPregunta3.Click += new System.EventHandler(this.lblPregunta3_Click);
            // 
            // txtPregunta3
            // 
            this.txtPregunta3.Location = new System.Drawing.Point(425, 53);
            this.txtPregunta3.Name = "txtPregunta3";
            this.txtPregunta3.Size = new System.Drawing.Size(212, 23);
            this.txtPregunta3.TabIndex = 1;
            this.txtPregunta3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSiguiente3
            // 
            this.btnSiguiente3.Location = new System.Drawing.Point(353, 398);
            this.btnSiguiente3.Name = "btnSiguiente3";
            this.btnSiguiente3.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente3.TabIndex = 2;
            this.btnSiguiente3.Text = "Siguiente";
            this.btnSiguiente3.UseVisualStyleBackColor = true;
            this.btnSiguiente3.Click += new System.EventHandler(this.btnSiguiente3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial2.Properties.Resources._15eaf9ddbd78cb061e59ee148427c2ca;
            this.pictureBox1.Location = new System.Drawing.Point(196, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Pregunta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiguiente3);
            this.Controls.Add(this.txtPregunta3);
            this.Controls.Add(this.lblPregunta3);
            this.Name = "Pregunta3";
            this.Text = "Pregunta3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta3;
        private TextBox txtPregunta3;
        private Button btnSiguiente3;
        private PictureBox pictureBox1;
    }
}