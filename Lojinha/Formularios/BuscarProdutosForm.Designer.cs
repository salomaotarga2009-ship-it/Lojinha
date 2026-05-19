namespace Lojinha.Formularios
{
    partial class BuscarProdutosForm
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
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.filtrarTextBox = new System.Windows.Forms.TextBox();
            this.incluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(89, 41);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estoque: ";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(89, 80);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(89, 119);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 6;
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Location = new System.Drawing.Point(89, 154);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.estoqueTextBox.TabIndex = 7;
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Location = new System.Drawing.Point(89, 231);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.Size = new System.Drawing.Size(348, 150);
            this.produtosDataGridView.TabIndex = 8;
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(376, 387);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 9;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Location = new System.Drawing.Point(89, 387);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(240, 20);
            this.filtrarTextBox.TabIndex = 10;
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(190, 190);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 11;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(283, 190);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 12;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(89, 190);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 13;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(376, 190);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 14;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            // 
            // BuscarProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.filtrarTextBox);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoTextBox);
            this.Name = "BuscarProdutosForm";
            this.Text = "BuscarProdutosForm";
            this.Load += new System.EventHandler(this.BuscarProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button excluirButton;
    }
}