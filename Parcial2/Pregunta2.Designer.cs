namespace Parcial2
{
    partial class Pregunta2
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
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.rdbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion4 = new System.Windows.Forms.RadioButton();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Location = new System.Drawing.Point(125, 50);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(529, 15);
            this.lblPregunta2.TabIndex = 0;
            this.lblPregunta2.Text = "¿Cómo se llama la inteligencia artificial que lidera a las máquinas en la guerra " +
    "contra los humanos? ";
            // 
            // rdbOpcion1
            // 
            this.rdbOpcion1.AutoSize = true;
            this.rdbOpcion1.Location = new System.Drawing.Point(120, 117);
            this.rdbOpcion1.Name = "rdbOpcion1";
            this.rdbOpcion1.Size = new System.Drawing.Size(75, 19);
            this.rdbOpcion1.TabIndex = 1;
            this.rdbOpcion1.TabStop = true;
            this.rdbOpcion1.Text = "Hall-9000";
            this.rdbOpcion1.UseVisualStyleBackColor = true;
            this.rdbOpcion1.CheckedChanged += new System.EventHandler(this.rdbOpcion1_CheckedChanged);
            // 
            // rdbOpcion2
            // 
            this.rdbOpcion2.AutoSize = true;
            this.rdbOpcion2.Location = new System.Drawing.Point(120, 153);
            this.rdbOpcion2.Name = "rdbOpcion2";
            this.rdbOpcion2.Size = new System.Drawing.Size(60, 19);
            this.rdbOpcion2.TabIndex = 2;
            this.rdbOpcion2.TabStop = true;
            this.rdbOpcion2.Text = "Skynet";
            this.rdbOpcion2.UseVisualStyleBackColor = true;
            this.rdbOpcion2.CheckedChanged += new System.EventHandler(this.rdbOpcion2_CheckedChanged);
            // 
            // rdbOpcion3
            // 
            this.rdbOpcion3.AutoSize = true;
            this.rdbOpcion3.Location = new System.Drawing.Point(120, 191);
            this.rdbOpcion3.Name = "rdbOpcion3";
            this.rdbOpcion3.Size = new System.Drawing.Size(77, 19);
            this.rdbOpcion3.TabIndex = 3;
            this.rdbOpcion3.TabStop = true;
            this.rdbOpcion3.Text = "Megatron";
            this.rdbOpcion3.UseVisualStyleBackColor = true;
            this.rdbOpcion3.CheckedChanged += new System.EventHandler(this.rdbOpcion3_CheckedChanged);
            // 
            // rdbOpcion4
            // 
            this.rdbOpcion4.AutoSize = true;
            this.rdbOpcion4.Location = new System.Drawing.Point(120, 232);
            this.rdbOpcion4.Name = "rdbOpcion4";
            this.rdbOpcion4.Size = new System.Drawing.Size(63, 19);
            this.rdbOpcion4.TabIndex = 4;
            this.rdbOpcion4.TabStop = true;
            this.rdbOpcion4.Text = "TalCual";
            this.rdbOpcion4.UseVisualStyleBackColor = true;
            this.rdbOpcion4.CheckedChanged += new System.EventHandler(this.rdbOpcion4_CheckedChanged);
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Location = new System.Drawing.Point(120, 293);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente2.TabIndex = 5;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial2.Properties.Resources._11125963283_4043bc5b03_b;
            this.pictureBox1.Location = new System.Drawing.Point(242, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Pregunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiguiente2);
            this.Controls.Add(this.rdbOpcion4);
            this.Controls.Add(this.rdbOpcion3);
            this.Controls.Add(this.rdbOpcion2);
            this.Controls.Add(this.rdbOpcion1);
            this.Controls.Add(this.lblPregunta2);
            this.Name = "Pregunta2";
            this.Text = "Pregunta2";
            this.Load += new System.EventHandler(this.Pregunta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta2;
        private RadioButton rdbOpcion1;
        private RadioButton rdbOpcion2;
        private RadioButton rdbOpcion3;
        private RadioButton rdbOpcion4;
        private Button btnSiguiente2;
        private PictureBox pictureBox1;
    }
}