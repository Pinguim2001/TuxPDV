namespace TuxPDV.View
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSair.Location = new System.Drawing.Point(655, 339);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 32);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "VOLTAR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 475);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaixa";
            this.Text = "TUXPDV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
    }
}