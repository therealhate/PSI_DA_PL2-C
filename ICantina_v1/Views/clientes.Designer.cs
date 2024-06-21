namespace ICantina_v1.Views
{
    partial class clientes
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
            this.listBox_clientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_tipoCliente = new System.Windows.Forms.ComboBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_marcarReserva = new System.Windows.Forms.Button();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_clientes
            // 
            this.listBox_clientes.FormattingEnabled = true;
            this.listBox_clientes.ItemHeight = 16;
            this.listBox_clientes.Location = new System.Drawing.Point(257, 0);
            this.listBox_clientes.Name = "listBox_clientes";
            this.listBox_clientes.Size = new System.Drawing.Size(794, 356);
            this.listBox_clientes.TabIndex = 0;
            this.listBox_clientes.SelectedIndexChanged += new System.EventHandler(this.listBox_clientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.txt_saldo);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.combo_tipoCliente);
            this.mainPanel.Controls.Add(this.txt_num);
            this.mainPanel.Controls.Add(this.button5);
            this.mainPanel.Controls.Add(this.txt_email);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.txt_nome);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.listBox_clientes);
            this.mainPanel.Location = new System.Drawing.Point(12, 44);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1051, 365);
            this.mainPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // combo_tipoCliente
            // 
            this.combo_tipoCliente.FormattingEnabled = true;
            this.combo_tipoCliente.Location = new System.Drawing.Point(65, 83);
            this.combo_tipoCliente.Name = "combo_tipoCliente";
            this.combo_tipoCliente.Size = new System.Drawing.Size(173, 24);
            this.combo_tipoCliente.TabIndex = 18;
            this.combo_tipoCliente.SelectedIndexChanged += new System.EventHandler(this.combo_tipoCliente_SelectedIndexChanged);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(65, 116);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(173, 22);
            this.txt_num.TabIndex = 17;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(113, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(65, 172);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(173, 22);
            this.txt_email.TabIndex = 13;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(65, 144);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(173, 22);
            this.txt_nome.TabIndex = 11;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(880, 415);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(83, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_marcarReserva
            // 
            this.btn_marcarReserva.Location = new System.Drawing.Point(269, 415);
            this.btn_marcarReserva.Name = "btn_marcarReserva";
            this.btn_marcarReserva.Size = new System.Drawing.Size(129, 23);
            this.btn_marcarReserva.TabIndex = 6;
            this.btn_marcarReserva.Text = "Marcar Reserva";
            this.btn_marcarReserva.UseVisualStyleBackColor = true;
            this.btn_marcarReserva.Click += new System.EventHandler(this.btn_marcarReserva_Click);
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(65, 200);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(173, 22);
            this.txt_saldo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Saldo";
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.btn_marcarReserva);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label1);
            this.Name = "clientes";
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_tipoCliente;
        private System.Windows.Forms.Button btn_marcarReserva;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label label6;
    }
}