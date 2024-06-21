namespace ICantina_v1.Views
{
    partial class menus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_vegan = new System.Windows.Forms.Button();
            this.btn_peixe = new System.Windows.Forms.Button();
            this.btncarne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMenus = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_TipoMenu = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnTodos);
            this.panel1.Controls.Add(this.btn_vegan);
            this.panel1.Controls.Add(this.btn_peixe);
            this.panel1.Controls.Add(this.btncarne);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 556);
            this.panel1.TabIndex = 0;
            // 
            // btn_vegan
            // 
            this.btn_vegan.Location = new System.Drawing.Point(79, 299);
            this.btn_vegan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vegan.Name = "btn_vegan";
            this.btn_vegan.Size = new System.Drawing.Size(96, 28);
            this.btn_vegan.TabIndex = 3;
            this.btn_vegan.Text = "Vegan";
            this.btn_vegan.UseVisualStyleBackColor = true;
            this.btn_vegan.Click += new System.EventHandler(this.btnvegan_Click);
            // 
            // btn_peixe
            // 
            this.btn_peixe.Location = new System.Drawing.Point(79, 224);
            this.btn_peixe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_peixe.Name = "btn_peixe";
            this.btn_peixe.Size = new System.Drawing.Size(96, 28);
            this.btn_peixe.TabIndex = 2;
            this.btn_peixe.Text = "Peixe";
            this.btn_peixe.UseVisualStyleBackColor = true;
            this.btn_peixe.Click += new System.EventHandler(this.btnpeixe_Click);
            // 
            // btncarne
            // 
            this.btncarne.Location = new System.Drawing.Point(79, 145);
            this.btncarne.Margin = new System.Windows.Forms.Padding(4);
            this.btncarne.Name = "btncarne";
            this.btncarne.Size = new System.Drawing.Size(96, 28);
            this.btncarne.TabIndex = 1;
            this.btncarne.Text = "Carne";
            this.btncarne.UseVisualStyleBackColor = true;
            this.btncarne.Click += new System.EventHandler(this.btncarne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menus";
            // 
            // lstMenus
            // 
            this.lstMenus.FormattingEnabled = true;
            this.lstMenus.ItemHeight = 16;
            this.lstMenus.Location = new System.Drawing.Point(265, 44);
            this.lstMenus.Margin = new System.Windows.Forms.Padding(4);
            this.lstMenus.Name = "lstMenus";
            this.lstMenus.Size = new System.Drawing.Size(436, 532);
            this.lstMenus.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo";
            // 
            // combo_TipoMenu
            // 
            this.combo_TipoMenu.FormattingEnabled = true;
            this.combo_TipoMenu.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegetariano"});
            this.combo_TipoMenu.Location = new System.Drawing.Point(792, 210);
            this.combo_TipoMenu.Name = "combo_TipoMenu";
            this.combo_TipoMenu.Size = new System.Drawing.Size(173, 24);
            this.combo_TipoMenu.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(839, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(792, 271);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(173, 22);
            this.txt_nome.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(79, 380);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(96, 28);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 623);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_TipoMenu);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMenus);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenusForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_vegan;
        private System.Windows.Forms.Button btn_peixe;
        private System.Windows.Forms.Button btncarne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMenus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_TipoMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTodos;
    }
}