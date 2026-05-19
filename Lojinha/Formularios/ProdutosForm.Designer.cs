using System;

namespace Lojinha.Formularios
{
    partial class ProdutosForm
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
            this.codigoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.precoLabel = new System.Windows.Forms.Label();
            this.estoqueLabel = new System.Windows.Forms.Label();
            this.codigoTextbox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.precoTextbox = new System.Windows.Forms.TextBox();
            this.estoqueTextbox = new System.Windows.Forms.TextBox();
            this.incluiButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.listarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(48, 63);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(46, 13);
            this.codigoLabel.TabIndex = 0;
            this.codigoLabel.Text = "Codigo: ";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(48, 102);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(41, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome: ";
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(48, 141);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(41, 13);
            this.precoLabel.TabIndex = 2;
            this.precoLabel.Text = "Preço: ";
            // 
            // estoqueLabel
            // 
            this.estoqueLabel.AutoSize = true;
            this.estoqueLabel.Location = new System.Drawing.Point(48, 179);
            this.estoqueLabel.Name = "estoqueLabel";
            this.estoqueLabel.Size = new System.Drawing.Size(52, 13);
            this.estoqueLabel.TabIndex = 3;
            this.estoqueLabel.Text = "Estoque: ";
            // 
            // codigoTextbox
            // 
            this.codigoTextbox.Location = new System.Drawing.Point(112, 56);
            this.codigoTextbox.Name = "codigoTextbox";
            this.codigoTextbox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextbox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(112, 95);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(158, 20);
            this.nomeTextBox.TabIndex = 5;
           
            // 
            // precoTextbox
            // 
            this.precoTextbox.Location = new System.Drawing.Point(112, 134);
            this.precoTextbox.Name = "precoTextbox";
            this.precoTextbox.Size = new System.Drawing.Size(158, 20);
            this.precoTextbox.TabIndex = 6;
            // 
            // estoqueTextbox
            // 
            this.estoqueTextbox.Location = new System.Drawing.Point(112, 172);
            this.estoqueTextbox.Name = "estoqueTextbox";
            this.estoqueTextbox.Size = new System.Drawing.Size(158, 20);
            this.estoqueTextbox.TabIndex = 7;
            // 
            // incluiButton
            // 
            this.incluiButton.Location = new System.Drawing.Point(112, 236);
            this.incluiButton.Name = "incluiButton";
            this.incluiButton.Size = new System.Drawing.Size(75, 23);
            this.incluiButton.TabIndex = 8;
            this.incluiButton.Text = "Incluir";
            this.incluiButton.UseVisualStyleBackColor = true;
            this.incluiButton.Click += new System.EventHandler(this.incluiButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(206, 236);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 9;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(304, 236);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 10;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(503, 236);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 11;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(404, 236);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(75, 23);
            this.listarButton.TabIndex = 12;
            this.listarButton.Text = "Listagem";
            this.listarButton.UseVisualStyleBackColor = true;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.incluiButton);
            this.Controls.Add(this.estoqueTextbox);
            this.Controls.Add(this.precoTextbox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.codigoTextbox);
            this.Controls.Add(this.estoqueLabel);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "ProdutosForm";
            this.Text = "ProdutosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label estoqueLabel;
        private System.Windows.Forms.TextBox codigoTextbox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox precoTextbox;
        private System.Windows.Forms.TextBox estoqueTextbox;
        private System.Windows.Forms.Button incluiButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button listarButton;
    }
}