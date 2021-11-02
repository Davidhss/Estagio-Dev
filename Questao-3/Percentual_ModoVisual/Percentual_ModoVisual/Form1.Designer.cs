
namespace Percentual_ModoVisual
{
    partial class frmPer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPer));
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(143, 32);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(73, 20);
            this.txtVenda.TabIndex = 0;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(143, 81);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(73, 20);
            this.txtTaxa.TabIndex = 1;
            this.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(20, 34);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(117, 15);
            this.lblVenda.TabIndex = 99;
            this.lblVenda.Text = "Valor da venda (R$):";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(31, 83);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(106, 15);
            this.lblTaxa.TabIndex = 98;
            this.lblTaxa.Text = "Valor da taxa (R$):";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(62, 124);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(114, 15);
            this.lblPer.TabIndex = 97;
            this.lblPer.Text = "Percentual da Taxa:";
            // 
            // txtPer
            // 
            this.txtPer.Location = new System.Drawing.Point(43, 145);
            this.txtPer.Name = "txtPer";
            this.txtPer.ReadOnly = true;
            this.txtPer.Size = new System.Drawing.Size(156, 20);
            this.txtPer.TabIndex = 5;
            this.txtPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(43, 187);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(156, 39);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(43, 232);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(124, 232);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(247, 283);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(263, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(263, 322);
            this.Name = "frmPer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Percentual de Taxas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

