namespace ICantina_v1
{
    partial class MenusForm
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_vegan = new System.Windows.Forms.Button();
            this.btn_peixe = new System.Windows.Forms.Button();
            this.btnCarne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMenus = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.btn_vegan);
            this.panel1.Controls.Add(this.btn_peixe);
            this.panel1.Controls.Add(this.btnCarne);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 556);
            this.panel1.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(79, 511);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(96, 28);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_vegan
            // 
            this.btn_vegan.Location = new System.Drawing.Point(79, 309);
            this.btn_vegan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vegan.Name = "btn_vegan";
            this.btn_vegan.Size = new System.Drawing.Size(96, 28);
            this.btn_vegan.TabIndex = 3;
            this.btn_vegan.Text = "Vegan";
            this.btn_vegan.UseVisualStyleBackColor = true;
            this.btn_vegan.Click += new System.EventHandler(this.btn_vegan_Click);
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
            this.btn_peixe.Click += new System.EventHandler(this.btn_peixe_Click);
            // 
            // btnCarne
            // 
            this.btnCarne.Location = new System.Drawing.Point(79, 145);
            this.btnCarne.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarne.Name = "btnCarne";
            this.btnCarne.Size = new System.Drawing.Size(96, 28);
            this.btnCarne.TabIndex = 1;
            this.btnCarne.Text = "Carne";
            this.btnCarne.UseVisualStyleBackColor = true;
            this.btnCarne.Click += new System.EventHandler(this.btnCarne_Click);
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
            // MenusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 623);
            this.Controls.Add(this.lstMenus);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenusForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_vegan;
        private System.Windows.Forms.Button btn_peixe;
        private System.Windows.Forms.Button btnCarne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ListBox lstMenus;
    }
}