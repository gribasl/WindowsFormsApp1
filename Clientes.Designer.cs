namespace WindowsFormsApp1
{
    partial class Clientes
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
            this.nome = new System.Windows.Forms.Label();
            this.nascimento = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDt = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados de identificação";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(12, 39);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // nascimento
            // 
            this.nascimento.AutoSize = true;
            this.nascimento.Location = new System.Drawing.Point(14, 117);
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(80, 13);
            this.nascimento.TabIndex = 2;
            this.nascimento.Text = "Dt. Nascimento";
            // 
            // celular
            // 
            this.celular.AutoSize = true;
            this.celular.Location = new System.Drawing.Point(223, 39);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(39, 13);
            this.celular.TabIndex = 3;
            this.celular.Text = "Celular";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(14, 78);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 4;
            this.email.Text = "E-mail";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(223, 117);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(27, 13);
            this.cpf.TabIndex = 5;
            this.cpf.Text = "CPF";
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Location = new System.Drawing.Point(223, 78);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(23, 13);
            this.rg.TabIndex = 6;
            this.rg.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(12, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtDt
            // 
            this.txtDt.Enabled = false;
            this.txtDt.Location = new System.Drawing.Point(12, 94);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(179, 20);
            this.txtDt.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(226, 55);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(118, 20);
            this.txtCelular.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(12, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(226, 94);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(118, 20);
            this.txtRg.TabIndex = 11;
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(226, 133);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(118, 20);
            this.txtCpf.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 174);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(133, 174);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(251, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(373, 174);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(611, 174);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDt);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.email);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.nascimento);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label nascimento;
        private System.Windows.Forms.Label celular;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDt;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
    }
}