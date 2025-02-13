namespace TuxPDV.View
{
    partial class frmResetSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarNovaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label1.Location = new System.Drawing.Point(86, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua Nova Senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(91, 100);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(235, 20);
            this.txtNovaSenha.TabIndex = 1;
            // 
            // txtConfirNovaSenha
            // 
            this.txtConfirNovaSenha.Location = new System.Drawing.Point(91, 212);
            this.txtConfirNovaSenha.Name = "txtConfirNovaSenha";
            this.txtConfirNovaSenha.PasswordChar = '*';
            this.txtConfirNovaSenha.Size = new System.Drawing.Size(235, 20);
            this.txtConfirNovaSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label2.Location = new System.Drawing.Point(86, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repita sua nova senha ";
            // 
            // btnSalvarNovaSenha
            // 
            this.btnSalvarNovaSenha.Location = new System.Drawing.Point(624, 405);
            this.btnSalvarNovaSenha.Name = "btnSalvarNovaSenha";
            this.btnSalvarNovaSenha.Size = new System.Drawing.Size(124, 33);
            this.btnSalvarNovaSenha.TabIndex = 4;
            this.btnSalvarNovaSenha.Text = "Salvar";
            this.btnSalvarNovaSenha.UseVisualStyleBackColor = true;
            this.btnSalvarNovaSenha.Click += new System.EventHandler(this.btnSalvarNovaSenha_Click);
            // 
            // frmResetSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarNovaSenha);
            this.Controls.Add(this.txtConfirNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResetSenha";
            this.Text = "TUXPDV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfirNovaSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarNovaSenha;
    }
}