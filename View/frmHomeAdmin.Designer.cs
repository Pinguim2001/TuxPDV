namespace TuxPDV.View
{
    partial class frmHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeAdmin));
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaixa.BackgroundImage")));
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCaixa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(139, 92);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(144, 104);
            this.btnCaixa.TabIndex = 0;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendas.BackgroundImage")));
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVendas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Location = new System.Drawing.Point(401, 92);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(144, 104);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "VENDAS";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstoque.BackgroundImage")));
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEstoque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(653, 92);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(144, 104);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "ESTOQUE";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(281, 252);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(144, 104);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "RELATÓRIOS";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(538, 252);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(144, 104);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "USUÁRIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSair.Location = new System.Drawing.Point(848, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 32);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 485);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnCaixa);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmHomeAdmin";
            this.Text = "TUXPDV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSair;
    }
}