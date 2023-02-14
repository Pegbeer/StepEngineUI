namespace StepEngineUI
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
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtBoxPortName = new System.Windows.Forms.TextBox();
            this.lblPortName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(12, 97);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(75, 23);
            this.btnDisminuir.TabIndex = 0;
            this.btnDisminuir.Text = "Disminuir";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(203, 97);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 1;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContador.Location = new System.Drawing.Point(133, 90);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(24, 30);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "0";
            // 
            // txtBoxPortName
            // 
            this.txtBoxPortName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxPortName.Location = new System.Drawing.Point(91, 18);
            this.txtBoxPortName.Name = "txtBoxPortName";
            this.txtBoxPortName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPortName.TabIndex = 3;
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(12, 21);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(73, 15);
            this.lblPortName.TabIndex = 4;
            this.lblPortName.Text = "Puerto COM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(104, 150);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 224);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPortName);
            this.Controls.Add(this.txtBoxPortName);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.btnDisminuir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisminuir;
        private Button btnAumentar;
        private Label lblContador;
        private TextBox txtBoxPortName;
        private Label lblPortName;
        private Button button1;
        private Button btnEnviar;
    }
}