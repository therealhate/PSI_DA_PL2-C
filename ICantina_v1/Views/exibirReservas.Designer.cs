namespace ICantina_v1.Views
{
    partial class exibirReservas
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
            this.list_reservasFeitas = new System.Windows.Forms.ListBox();
            this.btn_ativarReserva = new System.Windows.Forms.Button();
            this.btn_eliminarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_reservasFeitas
            // 
            this.list_reservasFeitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_reservasFeitas.FormattingEnabled = true;
            this.list_reservasFeitas.ItemHeight = 20;
            this.list_reservasFeitas.Location = new System.Drawing.Point(12, 12);
            this.list_reservasFeitas.Name = "list_reservasFeitas";
            this.list_reservasFeitas.Size = new System.Drawing.Size(894, 384);
            this.list_reservasFeitas.TabIndex = 0;
            // 
            // btn_ativarReserva
            // 
            this.btn_ativarReserva.Location = new System.Drawing.Point(12, 415);
            this.btn_ativarReserva.Name = "btn_ativarReserva";
            this.btn_ativarReserva.Size = new System.Drawing.Size(127, 23);
            this.btn_ativarReserva.TabIndex = 1;
            this.btn_ativarReserva.Text = "Ativar Reserva";
            this.btn_ativarReserva.UseVisualStyleBackColor = true;
            this.btn_ativarReserva.Click += new System.EventHandler(this.btn_ativarReserva_Click);
            // 
            // btn_eliminarReserva
            // 
            this.btn_eliminarReserva.Location = new System.Drawing.Point(161, 415);
            this.btn_eliminarReserva.Name = "btn_eliminarReserva";
            this.btn_eliminarReserva.Size = new System.Drawing.Size(127, 23);
            this.btn_eliminarReserva.TabIndex = 2;
            this.btn_eliminarReserva.Text = "Eliminar Reserva";
            this.btn_eliminarReserva.UseVisualStyleBackColor = true;
            // 
            // exibirReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.btn_eliminarReserva);
            this.Controls.Add(this.btn_ativarReserva);
            this.Controls.Add(this.list_reservasFeitas);
            this.Name = "exibirReservas";
            this.Text = "reservas";
            this.Load += new System.EventHandler(this.exibirReservas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_reservasFeitas;
        private System.Windows.Forms.Button btn_ativarReserva;
        private System.Windows.Forms.Button btn_eliminarReserva;
    }
}