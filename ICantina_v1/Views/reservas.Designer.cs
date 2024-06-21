namespace ICantina_v1.Views
{
    partial class reservas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_tipoCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.diaDaReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_extras = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_menus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_reservas = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combo_menus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_extras);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.diaDaReserva);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_num);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_tipoCliente);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Efetuar uma Reserva";
            // 
            // combo_tipoCliente
            // 
            this.combo_tipoCliente.FormattingEnabled = true;
            this.combo_tipoCliente.Items.AddRange(new object[] {
            "Professor",
            "Aluno",
            "Funcionario"});
            this.combo_tipoCliente.Location = new System.Drawing.Point(143, 40);
            this.combo_tipoCliente.Name = "combo_tipoCliente";
            this.combo_tipoCliente.Size = new System.Drawing.Size(121, 24);
            this.combo_tipoCliente.TabIndex = 1;
            this.combo_tipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Cliente";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(143, 121);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(158, 22);
            this.txt_nome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(143, 84);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(158, 22);
            this.txt_num.TabIndex = 5;
            // 
            // diaDaReserva
            // 
            this.diaDaReserva.Location = new System.Drawing.Point(143, 242);
            this.diaDaReserva.Name = "diaDaReserva";
            this.diaDaReserva.Size = new System.Drawing.Size(121, 22);
            this.diaDaReserva.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dia da Reserva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fazer Reserva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Extras";
            // 
            // combo_extras
            // 
            this.combo_extras.FormattingEnabled = true;
            this.combo_extras.Items.AddRange(new object[] {
            "Refrigerantes",
            "Sobremesa",
            "Acompanhamentos",
            "Molhos e Condimentos",
            ""});
            this.combo_extras.Location = new System.Drawing.Point(143, 200);
            this.combo_extras.Name = "combo_extras";
            this.combo_extras.Size = new System.Drawing.Size(121, 24);
            this.combo_extras.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Menu";
            // 
            // combo_menus
            // 
            this.combo_menus.FormattingEnabled = true;
            this.combo_menus.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.combo_menus.Location = new System.Drawing.Point(143, 160);
            this.combo_menus.Name = "combo_menus";
            this.combo_menus.Size = new System.Drawing.Size(121, 24);
            this.combo_menus.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.list_reservas);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservas";
            // 
            // list_reservas
            // 
            this.list_reservas.FormattingEnabled = true;
            this.list_reservas.ItemHeight = 16;
            this.list_reservas.Location = new System.Drawing.Point(6, 21);
            this.list_reservas.Name = "list_reservas";
            this.list_reservas.Size = new System.Drawing.Size(632, 292);
            this.list_reservas.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reserva Efetuada";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancelar Reserva";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "?editar?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "reservas";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_tipoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker diaDaReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_extras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_menus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox list_reservas;
    }
}