
namespace Controle_de_estoque.Formularios
{
    partial class Compras
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
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumQtd = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFInalizar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Location = new System.Drawing.Point(12, 57);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProdutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SubTotal";
            // 
            // NumQtd
            // 
            this.NumQtd.Location = new System.Drawing.Point(13, 123);
            this.NumQtd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumQtd.Name = "NumQtd";
            this.NumQtd.Size = new System.Drawing.Size(120, 20);
            this.NumQtd.TabIndex = 5;
            this.NumQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 220);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnFInalizar
            // 
            this.btnFInalizar.Location = new System.Drawing.Point(12, 249);
            this.btnFInalizar.Name = "btnFInalizar";
            this.btnFInalizar.Size = new System.Drawing.Size(95, 23);
            this.btnFInalizar.TabIndex = 7;
            this.btnFInalizar.Text = "Finalizar Compra";
            this.btnFInalizar.UseVisualStyleBackColor = true;
            this.btnFInalizar.Click += new System.EventHandler(this.btnFInalizar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduto,
            this.colPreco,
            this.colQuantidade,
            this.colSubtotal});
            this.dgvProdutos.Location = new System.Drawing.Point(220, 57);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(444, 228);
            this.dgvProdutos.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(238, 413);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(8, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // colProduto
            // 
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            // 
            // colQuantidade
            // 
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: R$ 0,00";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(12, 278);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(107, 23);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnFInalizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.NumQtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProdutos);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.NumQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumQtd;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFInalizar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemover;
    }
}