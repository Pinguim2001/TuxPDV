namespace TuxPDV.View
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(609, 176);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(144, 104);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "RELATÓRIOS";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendas.BackgroundImage")));
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVendas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(357, 176);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(144, 104);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.Text = "VENDAS";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaixa.BackgroundImage")));
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCaixa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(95, 176);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(144, 104);
            this.btnCaixa.TabIndex = 4;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSair.Location = new System.Drawing.Point(848, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 32);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 485);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnCaixa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "TUXPDV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnSair;
    }
}