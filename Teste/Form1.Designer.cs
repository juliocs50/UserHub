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

        private System.Windows.Forms.Label labelLog;

        private void InitializeComponent()
        {
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            this.textBoxCadastroNome = new System.Windows.Forms.TextBox();
            this.textBoxCadastroEmail = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelListaContatos = new System.Windows.Forms.Label();
            this.labelCadastroNome = new System.Windows.Forms.Label();
            this.labelCadastroEmail = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatos.Location = new System.Drawing.Point(72, 152);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            this.dataGridViewContatos.Size = new System.Drawing.Size(646, 178);
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
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(313, 366);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 401);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(362, 400);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Filtrar por Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Filtrar por E-mail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Filtrar por Nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "e";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.labelLog);
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

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

