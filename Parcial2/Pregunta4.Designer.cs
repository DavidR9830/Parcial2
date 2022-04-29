namespace Parcial2
{
    partial class Pregunta4
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
            this.lblPregunta4 = new System.Windows.Forms.Label();
            this.txtPregunta4 = new System.Windows.Forms.TextBox();
            this.btnSiguiente4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta4
            // 
            this.lblPregunta4.AutoSize = true;
            this.lblPregunta4.Location = new System.Drawing.Point(60, 71);
            this.lblPregunta4.Name = "lblPregunta4";
            this.lblPregunta4.Size = new System.Drawing.Size(480, 15);
            this.lblPregunta4.TabIndex = 0;
            this.lblPregunta4.Text = "El T-1000, el ciborg que persigue a John Connor y al T-800 en ‘Terminator 2, esta" +
    " hecho de:";
            this.lblPregunta4.Click += new System.EventHandler(this.lblPregunta4_Click);
            // 
            // txtPregunta4
            // 
            this.txtPregunta4.Location = new System.Drawing.Point(537, 63);
            this.txtPregunta4.Name = "txtPregunta4";
            this.txtPregunta4.Size = new System.Drawing.Size(181, 23);
            this.txtPregunta4.TabIndex = 1;
            this.txtPregunta4.TextChanged += new System.EventHandler(this.txtPregunta4_TextChanged);
            // 
            // btnSiguiente4
            // 
            this.btnSiguiente4.Location = new System.Drawing.Point(357, 389);
            this.btnSiguiente4.Name = "btnSiguiente4";
            this.btnSiguiente4.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente4.TabIndex = 2;
            this.btnSiguiente4.Text = "Siguiente";
            this.btnSiguiente4.UseVisualStyleBackColor = true;
            this.btnSiguiente4.Click += new System.EventHandler(this.btnSiguiente4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Parcial2.Properties.Resources._5da0550a2f824;
            this.pictureBox2.Location = new System.Drawing.Point(174, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Pregunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSiguiente4);
            this.Controls.Add(this.txtPregunta4);
            this.Controls.Add(this.lblPregunta4);
            this.Name = "Pregunta4";
            this.Text = "Pregunta4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta4;
        private TextBox txtPregunta4;
        private Button btnSiguiente4;
        private PictureBox pictureBox2;
    }
}