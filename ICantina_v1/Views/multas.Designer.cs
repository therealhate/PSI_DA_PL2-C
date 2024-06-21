using System;

namespace ICantina_v1.Views
{
    partial class multas
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
            this.listBox_multa = new System.Windows.Forms.ListBox();
            this.btn_pagarMulta = new System.Windows.Forms.Button();
            this.btn_eliminarMulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Multas";
            // 
            // listBox_multa
            // 
            this.listBox_multa.FormattingEnabled = true;
            this.listBox_multa.ItemHeight = 16;
            this.listBox_multa.Location = new System.Drawing.Point(14, 49);
            this.listBox_multa.Name = "listBox_multa";
            this.listBox_multa.Size = new System.Drawing.Size(776, 340);
            this.listBox_multa.TabIndex = 2;
            // 
            // btn_pagarMulta
            // 
            this.btn_pagarMulta.Location = new System.Drawing.Point(14, 405);
            this.btn_pagarMulta.Name = "btn_pagarMulta";
            this.btn_pagarMulta.Size = new System.Drawing.Size(119, 33);
            this.btn_pagarMulta.TabIndex = 4;
            this.btn_pagarMulta.Text = "Pagar Multa";
            this.btn_pagarMulta.UseVisualStyleBackColor = true;
            this.btn_pagarMulta.Click += new System.EventHandler(this.btn_pagarMulta_Click);
            // 
            // btn_eliminarMulta
            // 
            this.btn_eliminarMulta.Location = new System.Drawing.Point(139, 405);
            this.btn_eliminarMulta.Name = "btn_eliminarMulta";
            this.btn_eliminarMulta.Size = new System.Drawing.Size(119, 33);
            this.btn_eliminarMulta.TabIndex = 5;
            this.btn_eliminarMulta.Text = "Eliminar Multa";
            this.btn_eliminarMulta.UseVisualStyleBackColor = true;
            this.btn_eliminarMulta.Click += new System.EventHandler(this.btn_eliminarMulta_Click);
            // 
            // multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminarMulta);
            this.Controls.Add(this.btn_pagarMulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_multa);
            this.Name = "multas";
            this.Text = "multas";
            this.Load += new System.EventHandler(this.multas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_multa;
        private System.Windows.Forms.Button btn_pagarMulta;
        private System.Windows.Forms.Button btn_eliminarMulta;
    }
}