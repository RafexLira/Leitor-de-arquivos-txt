namespace DataReader
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
            this.TxtCaminho = new System.Windows.Forms.TextBox();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbRemetente = new System.Windows.Forms.CheckBox();
            this.CbRegistro = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCaminho
            // 
            this.TxtCaminho.Location = new System.Drawing.Point(47, 66);
            this.TxtCaminho.Name = "TxtCaminho";
            this.TxtCaminho.Size = new System.Drawing.Size(646, 20);
            this.TxtCaminho.TabIndex = 0;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(699, 66);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 20);
            this.BtnSelecionar.TabIndex = 1;
            this.BtnSelecionar.Text = "Procurar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSolucionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IMPORTADOR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(829, 381);
            this.dataGridView1.TabIndex = 5;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(699, 92);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 20);
            this.BtnInserir.TabIndex = 6;
            this.BtnInserir.Text = "Salvar";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(325, 242);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 20);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(47, 242);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(262, 20);
            this.TxtBuscar.TabIndex = 8;
            // 
            // CbRemetente
            // 
            this.CbRemetente.AutoSize = true;
            this.CbRemetente.Location = new System.Drawing.Point(47, 268);
            this.CbRemetente.Name = "CbRemetente";
            this.CbRemetente.Size = new System.Drawing.Size(97, 17);
            this.CbRemetente.TabIndex = 9;
            this.CbRemetente.Text = "Por Remetente";
            this.CbRemetente.UseVisualStyleBackColor = true;
            this.CbRemetente.CheckedChanged += new System.EventHandler(this.CbRemetente_CheckedChanged);
            // 
            // CbRegistro
            // 
            this.CbRegistro.AutoSize = true;
            this.CbRegistro.Location = new System.Drawing.Point(225, 268);
            this.CbRegistro.Name = "CbRegistro";
            this.CbRegistro.Size = new System.Drawing.Size(84, 17);
            this.CbRegistro.TabIndex = 10;
            this.CbRegistro.Text = "Por Registro";
            this.CbRegistro.UseVisualStyleBackColor = true;
            this.CbRegistro.CheckedChanged += new System.EventHandler(this.CbRegistro_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(418, 242);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 20);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 691);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbRegistro);
            this.Controls.Add(this.CbRemetente);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.TxtCaminho);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCaminho;
        private System.Windows.Forms.Button BtnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbRemetente;
        private System.Windows.Forms.CheckBox CbRegistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemover;
    }
}

