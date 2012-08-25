namespace AgendaEletronica1._0
{
    partial class Viabilidade
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
            this.button1 = new System.Windows.Forms.Button();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.btNovoContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(223, 227);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btPesquisa.TabIndex = 12;
            this.btPesquisa.Text = "&Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click_1);
            // 
            // btNovoContato
            // 
            this.btNovoContato.Location = new System.Drawing.Point(12, 227);
            this.btNovoContato.Name = "btNovoContato";
            this.btNovoContato.Size = new System.Drawing.Size(81, 23);
            this.btNovoContato.TabIndex = 13;
            this.btNovoContato.Text = "Novo Contato";
            this.btNovoContato.UseVisualStyleBackColor = true;
            this.btNovoContato.Click += new System.EventHandler(this.btNovoContato_Click);
            // 
            // Viabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 262);
            this.Controls.Add(this.btNovoContato);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.button1);
            this.Name = "Viabilidade";
            this.Text = "Viabilidade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPesquisa;
        internal System.Windows.Forms.Button btNovoContato;
    }
}