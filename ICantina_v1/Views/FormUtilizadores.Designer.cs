namespace ICantina_v1.Views
{
    partial class FormUtilizadores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ListBox listBox_funcionarios;
        private System.Windows.Forms.Button btn_adicionarFuncionario;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.listBox_funcionarios = new System.Windows.Forms.ListBox();
            this.btn_adicionarFuncionario = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(52, 104);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(160, 22);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(52, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(160, 22);
            this.txt_email.TabIndex = 1;
            // 
            // listBox_funcionarios
            // 
            this.listBox_funcionarios.FormattingEnabled = true;
            this.listBox_funcionarios.ItemHeight = 16;
            this.listBox_funcionarios.Location = new System.Drawing.Point(237, 12);
            this.listBox_funcionarios.Name = "listBox_funcionarios";
            this.listBox_funcionarios.Size = new System.Drawing.Size(313, 324);
            this.listBox_funcionarios.TabIndex = 2;
            // 
            // btn_adicionarFuncionario
            // 
            this.btn_adicionarFuncionario.Location = new System.Drawing.Point(52, 160);
            this.btn_adicionarFuncionario.Name = "btn_adicionarFuncionario";
            this.btn_adicionarFuncionario.Size = new System.Drawing.Size(160, 32);
            this.btn_adicionarFuncionario.TabIndex = 3;
            this.btn_adicionarFuncionario.Text = "Adicionar Funcionário";
            this.btn_adicionarFuncionario.UseVisualStyleBackColor = true;
            this.btn_adicionarFuncionario.Click += new System.EventHandler(this.btn_adicionarFuncionario_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(237, 342);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(100, 32);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(343, 342);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 32);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // FormUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_adicionarFuncionario);
            this.Controls.Add(this.listBox_funcionarios);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Name = "FormUtilizadores";
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_eliminar;
    }
}
