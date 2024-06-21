namespace ICantina_v1.Views
{
    partial class reservar
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
            this.lblClientName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_menus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_extras = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.diaDaReserva = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salvarReservas = new System.Windows.Forms.Button();
            this.list_reservas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_preco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblClientName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combo_menus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_extras);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.diaDaReserva);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Efetuar uma Reserva";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(156, 30);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(41, 16);
            this.lblClientName.TabIndex = 14;
            this.lblClientName.Text = "adfas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
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
            this.combo_menus.Location = new System.Drawing.Point(114, 87);
            this.combo_menus.Name = "combo_menus";
            this.combo_menus.Size = new System.Drawing.Size(207, 24);
            this.combo_menus.TabIndex = 12;
            this.combo_menus.SelectedIndexChanged += new System.EventHandler(this.combo_menus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Extras";
            // 
            // combo_extras
            // 
            this.combo_extras.FormattingEnabled = true;
            this.combo_extras.Items.AddRange(new object[] {
            "Refrigerantes + 1.00€",
            "Sobremesa + 0.50€",
            "Acompanhamentos + 1.50€",
            "Molhos e Condimentos + 0.50€"});
            this.combo_extras.Location = new System.Drawing.Point(114, 127);
            this.combo_extras.Name = "combo_extras";
            this.combo_extras.Size = new System.Drawing.Size(207, 24);
            this.combo_extras.TabIndex = 10;
            this.combo_extras.SelectedIndexChanged += new System.EventHandler(this.combo_extras_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fazer Reserva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dia da Reserva";
            // 
            // diaDaReserva
            // 
            this.diaDaReserva.Location = new System.Drawing.Point(114, 169);
            this.diaDaReserva.Name = "diaDaReserva";
            this.diaDaReserva.Size = new System.Drawing.Size(207, 22);
            this.diaDaReserva.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salvarReservas);
            this.groupBox2.Controls.Add(this.list_reservas);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 349);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservas";
            // 
            // btn_salvarReservas
            // 
            this.btn_salvarReservas.Location = new System.Drawing.Point(6, 319);
            this.btn_salvarReservas.Name = "btn_salvarReservas";
            this.btn_salvarReservas.Size = new System.Drawing.Size(121, 23);
            this.btn_salvarReservas.TabIndex = 15;
            this.btn_salvarReservas.Text = "Salvar Reservas";
            this.btn_salvarReservas.UseVisualStyleBackColor = true;
            this.btn_salvarReservas.Click += new System.EventHandler(this.btn_salvarReservas_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Preço";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(156, 213);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(0, 16);
            this.lbl_preco.TabIndex = 16;
            // 
            // reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "reservar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.reservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker diaDaReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_extras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_menus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_reservas;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btn_salvarReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_preco;
    }
}
