namespace Parcial2
{
    partial class Pregunta5
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbVerdadero = new System.Windows.Forms.RadioButton();
            this.rdbFalso = new System.Windows.Forms.RadioButton();
            this.btnSiguiente5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A John Connor lo asesinan en el año 2000";
            // 
            // rdbVerdadero
            // 
            this.rdbVerdadero.AutoSize = true;
            this.rdbVerdadero.Location = new System.Drawing.Point(120, 150);
            this.rdbVerdadero.Name = "rdbVerdadero";
            this.rdbVerdadero.Size = new System.Drawing.Size(78, 19);
            this.rdbVerdadero.TabIndex = 1;
            this.rdbVerdadero.TabStop = true;
            this.rdbVerdadero.Text = "Verdadero";
            this.rdbVerdadero.UseVisualStyleBackColor = true;
            this.rdbVerdadero.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFalso
            // 
            this.rdbFalso.AutoSize = true;
            this.rdbFalso.Location = new System.Drawing.Point(120, 196);
            this.rdbFalso.Name = "rdbFalso";
            this.rdbFalso.Size = new System.Drawing.Size(52, 19);
            this.rdbFalso.TabIndex = 2;
            this.rdbFalso.TabStop = true;
            this.rdbFalso.Text = "Falso";
            this.rdbFalso.UseVisualStyleBackColor = true;
            this.rdbFalso.CheckedChanged += new System.EventHandler(this.rdbFalso_CheckedChanged);
            // 
            // btnSiguiente5
            // 
            this.btnSiguiente5.Location = new System.Drawing.Point(120, 243);
            this.btnSiguiente5.Name = "btnSiguiente5";
            this.btnSiguiente5.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente5.TabIndex = 3;
            this.btnSiguiente5.Text = "Siguiente";
            this.btnSiguiente5.UseVisualStyleBackColor = true;
            this.btnSiguiente5.Click += new System.EventHandler(this.btnSiguiente5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial2.Properties.Resources.John_Connor_Timeline;
            this.pictureBox1.Location = new System.Drawing.Point(260, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Pregunta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiguiente5);
            this.Controls.Add(this.rdbFalso);
            this.Controls.Add(this.rdbVerdadero);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta5";
            this.Text = "Pregunta5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rdbVerdadero;
        private RadioButton rdbFalso;
        private Button btnSiguiente5;
        private PictureBox pictureBox1;
    }
}