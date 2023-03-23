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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCaminho
            // 
            this.TxtCaminho.Location = new System.Drawing.Point(18, 27);
            this.TxtCaminho.Name = "TxtCaminho";
            this.TxtCaminho.Size = new System.Drawing.Size(504, 20);
            this.TxtCaminho.TabIndex = 0;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(528, 27);
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
            this.label1.Location = new System.Drawing.Point(370, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IMPORTADOR DE ARQUIVOS TXT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(709, 337);
            this.dataGridView1.TabIndex = 5;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(528, 53);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 20);
            this.BtnInserir.TabIndex = 6;
            this.BtnInserir.Text = "Salvar";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(299, 19);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 20);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(18, 19);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(262, 20);
            this.TxtBuscar.TabIndex = 8;
            // 
            // CbRemetente
            // 
            this.CbRemetente.AutoSize = true;
            this.CbRemetente.Location = new System.Drawing.Point(18, 54);
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
            this.CbRegistro.Location = new System.Drawing.Point(196, 54);
            this.CbRegistro.Name = "CbRegistro";
            this.CbRegistro.Size = new System.Drawing.Size(84, 17);
            this.CbRegistro.TabIndex = 10;
            this.CbRegistro.Text = "Por Registro";
            this.CbRegistro.UseVisualStyleBackColor = true;
            this.CbRegistro.CheckedChanged += new System.EventHandler(this.CbRegistro_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(389, 19);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 20);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.CbRegistro);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.CbRemetente);
            this.groupBox1.Location = new System.Drawing.Point(47, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 470);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCaminho);
            this.groupBox2.Controls.Add(this.BtnSelecionar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BtnInserir);
            this.groupBox2.Location = new System.Drawing.Point(47, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 111);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IMPORTADOR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

