namespace Actividad6
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPulsame = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btnPulsame
            // 
            this.btnPulsame.Location = new System.Drawing.Point(448, 323);
            this.btnPulsame.Name = "btnPulsame";
            this.btnPulsame.Size = new System.Drawing.Size(94, 29);
            this.btnPulsame.TabIndex = 0;
            this.btnPulsame.Text = "Pulsame";
            this.btnPulsame.UseVisualStyleBackColor = true;
            this.btnPulsame.Click += new System.EventHandler(this.btnPulsame_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(380, 284);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(244, 20);
            this.lblContenido.TabIndex = 1;
            this.lblContenido.Text = "Voy a cambiar de color y contenido";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1075, 527);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnPulsame);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btnPulsame;
        private Label lblContenido;
    }
}