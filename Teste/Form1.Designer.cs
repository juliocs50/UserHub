// Form1.Designer.cs
namespace Teste
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView dataGridViewContatos;
        private System.Windows.Forms.TextBox textBoxCadastroNome;
        private System.Windows.Forms.TextBox textBoxCadastroEmail;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label labelCadastroNome;
        private System.Windows.Forms.Label labelCadastroEmail;
        private System.Windows.Forms.Label labelListaContatos;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonFiltrar;

        private System.Windows.Forms.Label labelLog;

        private void InitializeComponent()
        {
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            dataGridViewContatos.CellContentClick += dataGridViewContatos_CellContentClick;
            this.textBoxCadastroNome = new System.Windows.Forms.TextBox();
            this.textBoxCadastroEmail = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelListaContatos = new System.Windows.Forms.Label();
            this.labelCadastroNome = new System.Windows.Forms.Label();
            this.labelCadastroEmail = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelCadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatos.Location = new System.Drawing.Point(72, 152);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            this.dataGridViewContatos.Size = new System.Drawing.Size(717, 178);
            this.dataGridViewContatos.TabIndex = 0;
            // 
            // textBoxCadastroNome
            // 
            this.textBoxCadastroNome.Location = new System.Drawing.Point(213, 25);
            this.textBoxCadastroNome.Name = "textBoxCadastroNome";
            this.textBoxCadastroNome.Size = new System.Drawing.Size(279, 20);
            this.textBoxCadastroNome.TabIndex = 1;
            this.textBoxCadastroNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCadastroEmail
            // 
            this.textBoxCadastroEmail.Location = new System.Drawing.Point(213, 47);
            this.textBoxCadastroEmail.Name = "textBoxCadastroEmail";
            this.textBoxCadastroEmail.Size = new System.Drawing.Size(279, 20);
            this.textBoxCadastroEmail.TabIndex = 7;
            this.textBoxCadastroEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(174, 73);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelListaContatos
            // 
            this.labelListaContatos.AutoSize = true;
            this.labelListaContatos.Location = new System.Drawing.Point(174, 136);
            this.labelListaContatos.Name = "labelListaContatos";
            this.labelListaContatos.Size = new System.Drawing.Size(88, 13);
            this.labelListaContatos.TabIndex = 2;
            this.labelListaContatos.Text = "Lista de contatos";
            // 
            // labelCadastroNome
            // 
            this.labelCadastroNome.AutoSize = true;
            this.labelCadastroNome.Location = new System.Drawing.Point(174, 28);
            this.labelCadastroNome.Name = "labelCadastroNome";
            this.labelCadastroNome.Size = new System.Drawing.Size(35, 13);
            this.labelCadastroNome.TabIndex = 4;
            this.labelCadastroNome.Text = "Nome";
            // 
            // labelCadastroEmail
            // 
            this.labelCadastroEmail.AutoSize = true;
            this.labelCadastroEmail.Location = new System.Drawing.Point(174, 50);
            this.labelCadastroEmail.Name = "labelCadastroEmail";
            this.labelCadastroEmail.Size = new System.Drawing.Size(35, 13);
            this.labelCadastroEmail.TabIndex = 5;
            this.labelCadastroEmail.Text = "E-mail";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(97, 103);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 11;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(376, 362);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(0, 13);
            this.labelLog.TabIndex = 12;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Location = new System.Drawing.Point(171, 9);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(52, 13);
            this.labelCadastro.TabIndex = 13;
            this.labelCadastro.Text = "Cadastrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxCadastroEmail);
            this.Controls.Add(this.labelCadastroEmail);
            this.Controls.Add(this.labelCadastroNome);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelListaContatos);
            this.Controls.Add(this.textBoxCadastroNome);
            this.Controls.Add(this.dataGridViewContatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

