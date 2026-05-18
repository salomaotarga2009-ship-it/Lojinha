namespace Lojinha.Formularios
{
    partial class BuscaClientesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoTextbox = new System.Windows.Forms.TextBox();
            this.nomeTextbox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextbox = new System.Windows.Forms.TextBox();
            this.LimparButton = new System.Windows.Forms.Button();
            this.IncluirButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.filtroTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone: ";
            // 
            // codigoTextbox
            // 
            this.codigoTextbox.Enabled = false;
            this.codigoTextbox.Location = new System.Drawing.Point(82, 26);
            this.codigoTextbox.Name = "codigoTextbox";
            this.codigoTextbox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextbox.TabIndex = 4;
            // 
            // nomeTextbox
            // 
            this.nomeTextbox.Location = new System.Drawing.Point(82, 61);
            this.nomeTextbox.Name = "nomeTextbox";
            this.nomeTextbox.Size = new System.Drawing.Size(222, 20);
            this.nomeTextbox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(82, 99);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(222, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // telefoneTextbox
            // 
            this.telefoneTextbox.Location = new System.Drawing.Point(82, 136);
            this.telefoneTextbox.Name = "telefoneTextbox";
            this.telefoneTextbox.Size = new System.Drawing.Size(222, 20);
            this.telefoneTextbox.TabIndex = 7;
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(82, 186);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(75, 23);
            this.LimparButton.TabIndex = 8;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            // 
            // IncluirButton
            // 
            this.IncluirButton.Location = new System.Drawing.Point(176, 186);
            this.IncluirButton.Name = "IncluirButton";
            this.IncluirButton.Size = new System.Drawing.Size(75, 23);
            this.IncluirButton.TabIndex = 9;
            this.IncluirButton.Text = "Incluir ";
            this.IncluirButton.UseVisualStyleBackColor = true;
            // 
            // AlterarButton
            // 
            this.AlterarButton.Location = new System.Drawing.Point(269, 186);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(75, 23);
            this.AlterarButton.TabIndex = 10;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(367, 186);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 11;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(82, 228);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(438, 150);
            this.ClientesDataGridView.TabIndex = 12;
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(367, 405);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 13;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // filtroTextbox
            // 
            this.filtroTextbox.Location = new System.Drawing.Point(82, 405);
            this.filtroTextbox.Name = "filtroTextbox";
            this.filtroTextbox.Size = new System.Drawing.Size(262, 20);
            this.filtroTextbox.TabIndex = 14;
            // 
            // BuscaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtroTextbox);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.AlterarButton);
            this.Controls.Add(this.IncluirButton);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.telefoneTextbox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextbox);
            this.Controls.Add(this.codigoTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscaClientesForm";
            this.Text = "BuscaClientesForm";
            this.Load += new System.EventHandler(this.BuscaClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoTextbox;
        private System.Windows.Forms.TextBox nomeTextbox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextbox;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.Button IncluirButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.TextBox filtroTextbox;
    }
}