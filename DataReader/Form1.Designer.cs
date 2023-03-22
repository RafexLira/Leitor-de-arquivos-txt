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
            this.ColRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemetente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCaminho
            // 
            this.TxtCaminho.Location = new System.Drawing.Point(51, 91);
            this.TxtCaminho.Name = "TxtCaminho";
            this.TxtCaminho.Size = new System.Drawing.Size(198, 20);
            this.TxtCaminho.TabIndex = 0;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(280, 91);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecionar.TabIndex = 1;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSolucionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LEITOR DE ARQUIVOS DE DADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRegistro,
            this.ColNome,
            this.ColDataEnvio,
            this.ColRemetente,
            this.ColDestinatario,
            this.ColConteudo});
            this.dataGridView1.Location = new System.Drawing.Point(166, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 381);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColRegistro
            // 
            this.ColRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRegistro.HeaderText = "Registro";
            this.ColRegistro.Name = "ColRegistro";
            // 
            // ColNome
            // 
            this.ColNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            // 
            // ColDataEnvio
            // 
            this.ColDataEnvio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDataEnvio.HeaderText = "Data de Envio";
            this.ColDataEnvio.Name = "ColDataEnvio";
            // 
            // ColRemetente
            // 
            this.ColRemetente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRemetente.HeaderText = "Remetente";
            this.ColRemetente.Name = "ColRemetente";
            // 
            // ColDestinatario
            // 
            this.ColDestinatario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDestinatario.HeaderText = "Destinatario";
            this.ColDestinatario.Name = "ColDestinatario";
            // 
            // ColConteudo
            // 
            this.ColConteudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColConteudo.HeaderText = "Conteudo";
            this.ColConteudo.Name = "ColConteudo";
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(280, 143);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 23);
            this.BtnInserir.TabIndex = 6;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(166, 272);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 715);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemetente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConteudo;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnConsultar;
    }
}

