
namespace ListaDeCompras
{
    partial class Form1
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
            this.tbxItem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.tbxQuant = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInserirEmail = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxItens = new System.Windows.Forms.TextBox();
            this.tbxEmails = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDividir = new System.Windows.Forms.Button();
            this.tbxValores = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxItem
            // 
            this.tbxItem.Location = new System.Drawing.Point(3, 21);
            this.tbxItem.MaxLength = 30;
            this.tbxItem.Name = "tbxItem";
            this.tbxItem.Size = new System.Drawing.Size(198, 20);
            this.tbxItem.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnInserirItem);
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.lblQuant);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.tbxPreco);
            this.panel1.Controls.Add(this.tbxQuant);
            this.panel1.Controls.Add(this.tbxItem);
            this.panel1.Location = new System.Drawing.Point(12, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 207);
            this.panel1.TabIndex = 1;
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.Location = new System.Drawing.Point(70, 157);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(75, 37);
            this.btnInserirItem.TabIndex = 4;
            this.btnInserirItem.Text = "Inserir Item";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(3, 103);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(169, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço (por unidade/peso/pacote):";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(3, 54);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(208, 13);
            this.lblQuant.TabIndex = 1;
            this.lblQuant.Text = "Quant. (unidades/peso (gramas)/pacotes):";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(3, 4);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(65, 13);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item (nome):";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(3, 119);
            this.tbxPreco.MaxLength = 5;
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(100, 20);
            this.tbxPreco.TabIndex = 3;
            // 
            // tbxQuant
            // 
            this.tbxQuant.Location = new System.Drawing.Point(3, 70);
            this.tbxQuant.MaxLength = 5;
            this.tbxQuant.Name = "tbxQuant";
            this.tbxQuant.Size = new System.Drawing.Size(100, 20);
            this.tbxQuant.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInserirEmail);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.tbxEmail);
            this.panel2.Location = new System.Drawing.Point(231, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 207);
            this.panel2.TabIndex = 1;
            // 
            // btnInserirEmail
            // 
            this.btnInserirEmail.Location = new System.Drawing.Point(67, 157);
            this.btnInserirEmail.Name = "btnInserirEmail";
            this.btnInserirEmail.Size = new System.Drawing.Size(75, 37);
            this.btnInserirEmail.TabIndex = 6;
            this.btnInserirEmail.Text = "Inserir Email";
            this.btnInserirEmail.UseVisualStyleBackColor = true;
            this.btnInserirEmail.Click += new System.EventHandler(this.btnInserirEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(3, 21);
            this.tbxEmail.MaxLength = 100;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(198, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxItens
            // 
            this.tbxItens.Location = new System.Drawing.Point(12, 9);
            this.tbxItens.Multiline = true;
            this.tbxItens.Name = "tbxItens";
            this.tbxItens.ReadOnly = true;
            this.tbxItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxItens.Size = new System.Drawing.Size(213, 300);
            this.tbxItens.TabIndex = 5;
            this.tbxItens.TabStop = false;
            this.tbxItens.WordWrap = false;
            // 
            // tbxEmails
            // 
            this.tbxEmails.Location = new System.Drawing.Point(231, 9);
            this.tbxEmails.Multiline = true;
            this.tbxEmails.Name = "tbxEmails";
            this.tbxEmails.ReadOnly = true;
            this.tbxEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxEmails.Size = new System.Drawing.Size(213, 300);
            this.tbxEmails.TabIndex = 5;
            this.tbxEmails.TabStop = false;
            this.tbxEmails.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDividir);
            this.panel3.Location = new System.Drawing.Point(450, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 207);
            this.panel3.TabIndex = 1;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(54, 156);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(102, 35);
            this.btnDividir.TabIndex = 0;
            this.btnDividir.Text = "Dividir a conta";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // tbxValores
            // 
            this.tbxValores.Location = new System.Drawing.Point(450, 9);
            this.tbxValores.Multiline = true;
            this.tbxValores.Name = "tbxValores";
            this.tbxValores.ReadOnly = true;
            this.tbxValores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxValores.Size = new System.Drawing.Size(213, 300);
            this.tbxValores.TabIndex = 5;
            this.tbxValores.TabStop = false;
            this.tbxValores.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(676, 535);
            this.Controls.Add(this.tbxValores);
            this.Controls.Add(this.tbxEmails);
            this.Controls.Add(this.tbxItens);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.TextBox tbxQuant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInserirEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxItens;
        private System.Windows.Forms.TextBox tbxEmails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox tbxValores;
    }
}

