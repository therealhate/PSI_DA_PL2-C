using System;

namespace ICantina_v1.Views
{
    partial class formPrincipal
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_semanas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_reservas = new System.Windows.Forms.Button();
            this.btn_multas = new System.Windows.Forms.Button();
            this.btn_menus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mudarUser = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 75);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(862, 514);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.btn_semanas);
            this.panel2.Controls.Add(this.btn_clientes);
            this.panel2.Controls.Add(this.btn_reservas);
            this.panel2.Controls.Add(this.btn_multas);
            this.panel2.Controls.Add(this.btn_menus);
            this.panel2.Location = new System.Drawing.Point(13, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 48);
            this.panel2.TabIndex = 6;
            // 
            // btn_semanas
            // 
            this.btn_semanas.Location = new System.Drawing.Point(188, 15);
            this.btn_semanas.Name = "btn_semanas";
            this.btn_semanas.Size = new System.Drawing.Size(75, 23);
            this.btn_semanas.TabIndex = 8;
            this.btn_semanas.Text = "Semana";
            this.btn_semanas.UseVisualStyleBackColor = true;
            this.btn_semanas.Click += new System.EventHandler(this.btn_semanas_Click_1);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(512, 15);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_clientes.TabIndex = 7;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_reservas
            // 
            this.btn_reservas.Location = new System.Drawing.Point(430, 15);
            this.btn_reservas.Name = "btn_reservas";
            this.btn_reservas.Size = new System.Drawing.Size(75, 23);
            this.btn_reservas.TabIndex = 6;
            this.btn_reservas.Text = "Reservas";
            this.btn_reservas.UseVisualStyleBackColor = true;
            this.btn_reservas.Click += new System.EventHandler(this.btn_reservas_Click);
            // 
            // btn_multas
            // 
            this.btn_multas.Location = new System.Drawing.Point(350, 15);
            this.btn_multas.Name = "btn_multas";
            this.btn_multas.Size = new System.Drawing.Size(75, 23);
            this.btn_multas.TabIndex = 5;
            this.btn_multas.Text = "Multas";
            this.btn_multas.UseVisualStyleBackColor = true;
            this.btn_multas.Click += new System.EventHandler(this.btn_multas_Click);
            // 
            // btn_menus
            // 
            this.btn_menus.Location = new System.Drawing.Point(268, 15);
            this.btn_menus.Name = "btn_menus";
            this.btn_menus.Size = new System.Drawing.Size(75, 23);
            this.btn_menus.TabIndex = 4;
            this.btn_menus.Text = "Menus";
            this.btn_menus.UseVisualStyleBackColor = true;
            this.btn_menus.Click += new System.EventHandler(this.btn_menus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_mudarUser);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 40);
            this.panel1.TabIndex = 5;
            // 
            // btn_mudarUser
            // 
            this.btn_mudarUser.Location = new System.Drawing.Point(802, 5);
            this.btn_mudarUser.Name = "btn_mudarUser";
            this.btn_mudarUser.Size = new System.Drawing.Size(50, 20);
            this.btn_mudarUser.TabIndex = 8;
            this.btn_mudarUser.Text = "Mudar";
            this.btn_mudarUser.UseVisualStyleBackColor = true;
            this.btn_mudarUser.Click += new System.EventHandler(this.btn_mudarUser_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(732, 6);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(70, 16);
            this.user.TabIndex = 3;
            this.user.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ICantina";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICantina";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_semanas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_reservas;
        private System.Windows.Forms.Button btn_multas;
        private System.Windows.Forms.Button btn_menus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mudarUser;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
    }
}

