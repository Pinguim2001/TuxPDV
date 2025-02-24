namespace TuxPDV.View
{
    partial class frmEsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueceuSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtCodRecup = new System.Windows.Forms.TextBox();
            this.btnVerificaCode = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu e-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(334, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o código que você recebeu por e-mail";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(453, 226);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(94, 35);
            this.btnEnviarEmail.TabIndex = 3;
            this.btnEnviarEmail.Text = "ENVIAR";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(500, 190);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 20);
            this.lblTimer.TabIndex = 4;
            // 
            // txtCodRecup
            // 
            this.txtCodRecup.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodRecup.Location = new System.Drawing.Point(334, 331);
            this.txtCodRecup.Name = "txtCodRecup";
            this.txtCodRecup.Size = new System.Drawing.Size(328, 29);
            this.txtCodRecup.TabIndex = 5;
            // 
            // btnVerificaCode
            // 
            this.btnVerificaCode.Location = new System.Drawing.Point(453, 396);
            this.btnVerificaCode.Name = "btnVerificaCode";
            this.btnVerificaCode.Size = new System.Drawing.Size(94, 35);
            this.btnVerificaCode.TabIndex = 6;
            this.btnVerificaCode.Text = "VERIFICAR";
            this.btnVerificaCode.UseVisualStyleBackColor = true;
            this.btnVerificaCode.Click += new System.EventHandler(this.btnVerificaCode_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(852, 438);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 35);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmEsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 485);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVerificaCode);
            this.Controls.Add(this.txtCodRecup);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUXPDV";
            this.Load += new System.EventHandler(this.frmEsqueceuSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtCodRecup;
        private System.Windows.Forms.Button btnVerificaCode;
        private System.Windows.Forms.Button btnVoltar;
    }
}