namespace Banco_de_Dados
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_box_pesquisar = new System.Windows.Forms.TextBox();
            this.data_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastro de Novos Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar :";
            // 
            // txt_box_pesquisar
            // 
            this.txt_box_pesquisar.Location = new System.Drawing.Point(153, 68);
            this.txt_box_pesquisar.Name = "txt_box_pesquisar";
            this.txt_box_pesquisar.Size = new System.Drawing.Size(249, 20);
            this.txt_box_pesquisar.TabIndex = 2;
            this.txt_box_pesquisar.TextChanged += new System.EventHandler(this.txt_box_pesquisar_TextChanged);
            // 
            // data_grid
            // 
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(50, 104);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(448, 150);
            this.data_grid.TabIndex = 3;
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 342);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.txt_box_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_box_pesquisar;
        private System.Windows.Forms.DataGridView data_grid;
    }
}

