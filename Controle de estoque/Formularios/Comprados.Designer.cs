namespace Controle_de_estoque.Formularios
{
    partial class Comprados
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
            this.dtGridComprados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridComprados
            // 
            this.dtGridComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridComprados.Location = new System.Drawing.Point(184, 52);
            this.dtGridComprados.Name = "dtGridComprados";
            this.dtGridComprados.Size = new System.Drawing.Size(441, 258);
            this.dtGridComprados.TabIndex = 0;
            this.dtGridComprados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridComprados_CellContentClick);
            // 
            // Comprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridComprados);
            this.Name = "Comprados";
            this.Text = "Comprados";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridComprados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridComprados;
    }
}