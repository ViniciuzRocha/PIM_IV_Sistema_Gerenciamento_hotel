
namespace TelaLogin
{
    partial class ConsultarReserva
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busca_id_reserva = new System.Windows.Forms.TextBox();
            this.txt_checkout = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_checkin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_busca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_quarto = new System.Windows.Forms.TextBox();
            this.txt_cod_hosp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id_reserva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_reservas = new System.Windows.Forms.DataGridView();
            this.btn_reserva_confirmada = new System.Windows.Forms.Button();
            this.btn_reserva_cancelada = new System.Windows.Forms.Button();
            this.btn_reserva_geral = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "CPF do Hóspede";
            // 
            // txt_busca_id_reserva
            // 
            this.txt_busca_id_reserva.Location = new System.Drawing.Point(44, 41);
            this.txt_busca_id_reserva.Name = "txt_busca_id_reserva";
            this.txt_busca_id_reserva.Size = new System.Drawing.Size(142, 27);
            this.txt_busca_id_reserva.TabIndex = 0;
            // 
            // txt_checkout
            // 
            this.txt_checkout.Enabled = false;
            this.txt_checkout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_checkout.Location = new System.Drawing.Point(152, 110);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.Size = new System.Drawing.Size(135, 27);
            this.txt_checkout.TabIndex = 61;
            this.txt_checkout.Value = new System.DateTime(2021, 10, 23, 12, 14, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(52, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "CheckOut";
            // 
            // txt_checkin
            // 
            this.txt_checkin.Enabled = false;
            this.txt_checkin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_checkin.Location = new System.Drawing.Point(152, 63);
            this.txt_checkin.Name = "txt_checkin";
            this.txt_checkin.Size = new System.Drawing.Size(135, 27);
            this.txt_checkin.TabIndex = 55;
            this.txt_checkin.Value = new System.DateTime(2021, 10, 23, 12, 14, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(68, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "CheckIn";
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_busca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_busca.Location = new System.Drawing.Point(44, 88);
            this.btn_busca.Margin = new System.Windows.Forms.Padding(5);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(141, 30);
            this.btn_busca.TabIndex = 53;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_busca);
            this.groupBox1.Controls.Add(this.txt_busca_id_reserva);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(179, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 133);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código da Reserva";
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(373, 154);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 27);
            this.txt_valor.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(279, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Valor";
            // 
            // txt_quarto
            // 
            this.txt_quarto.Enabled = false;
            this.txt_quarto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quarto.Location = new System.Drawing.Point(152, 155);
            this.txt_quarto.Name = "txt_quarto";
            this.txt_quarto.Size = new System.Drawing.Size(49, 27);
            this.txt_quarto.TabIndex = 62;
            // 
            // txt_cod_hosp
            // 
            this.txt_cod_hosp.Enabled = false;
            this.txt_cod_hosp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_hosp.Location = new System.Drawing.Point(152, 17);
            this.txt_cod_hosp.Name = "txt_cod_hosp";
            this.txt_cod_hosp.Size = new System.Drawing.Size(135, 27);
            this.txt_cod_hosp.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(77, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quarto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_id_reserva);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_checkout);
            this.groupBox2.Controls.Add(this.txt_status);
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_quarto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_checkin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_cod_hosp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(459, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 199);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Reserva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(317, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 65;
            this.label9.Text = "Cód. Reserva";
            // 
            // txt_id_reserva
            // 
            this.txt_id_reserva.Enabled = false;
            this.txt_id_reserva.Location = new System.Drawing.Point(433, 110);
            this.txt_id_reserva.Name = "txt_id_reserva";
            this.txt_id_reserva.Size = new System.Drawing.Size(40, 27);
            this.txt_id_reserva.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.AutoSize = true;
            this.txt_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(382, 19);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(72, 25);
            this.txt_status.TabIndex = 60;
            this.txt_status.Text = "Ativo";
            this.txt_status.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(240, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Consulta de Reservas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelaLogin.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(179, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_reservas
            // 
            this.dgv_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservas.Location = new System.Drawing.Point(179, 314);
            this.dgv_reservas.Name = "dgv_reservas";
            this.dgv_reservas.Size = new System.Drawing.Size(768, 160);
            this.dgv_reservas.TabIndex = 58;
            // 
            // btn_reserva_confirmada
            // 
            this.btn_reserva_confirmada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_reserva_confirmada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva_confirmada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reserva_confirmada.Location = new System.Drawing.Point(350, 260);
            this.btn_reserva_confirmada.Margin = new System.Windows.Forms.Padding(5);
            this.btn_reserva_confirmada.Name = "btn_reserva_confirmada";
            this.btn_reserva_confirmada.Size = new System.Drawing.Size(196, 46);
            this.btn_reserva_confirmada.TabIndex = 55;
            this.btn_reserva_confirmada.Text = "Reservas Confirmadas";
            this.btn_reserva_confirmada.UseVisualStyleBackColor = false;
            this.btn_reserva_confirmada.Click += new System.EventHandler(this.btn_reserva_confirmada_Click);
            // 
            // btn_reserva_cancelada
            // 
            this.btn_reserva_cancelada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_reserva_cancelada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva_cancelada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reserva_cancelada.Location = new System.Drawing.Point(557, 260);
            this.btn_reserva_cancelada.Margin = new System.Windows.Forms.Padding(5);
            this.btn_reserva_cancelada.Name = "btn_reserva_cancelada";
            this.btn_reserva_cancelada.Size = new System.Drawing.Size(183, 46);
            this.btn_reserva_cancelada.TabIndex = 56;
            this.btn_reserva_cancelada.Text = "Reservas Canceladas";
            this.btn_reserva_cancelada.UseVisualStyleBackColor = false;
            this.btn_reserva_cancelada.Click += new System.EventHandler(this.btn_reserva_cancelada_Click);
            // 
            // btn_reserva_geral
            // 
            this.btn_reserva_geral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_reserva_geral.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva_geral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reserva_geral.Location = new System.Drawing.Point(179, 261);
            this.btn_reserva_geral.Margin = new System.Windows.Forms.Padding(5);
            this.btn_reserva_geral.Name = "btn_reserva_geral";
            this.btn_reserva_geral.Size = new System.Drawing.Size(158, 46);
            this.btn_reserva_geral.TabIndex = 59;
            this.btn_reserva_geral.Text = "Consulta Geral";
            this.btn_reserva_geral.UseVisualStyleBackColor = false;
            this.btn_reserva_geral.Click += new System.EventHandler(this.btn_reserva_geral_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salvar.Location = new System.Drawing.Point(751, 260);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(196, 47);
            this.btn_salvar.TabIndex = 54;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // ConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(951, 487);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_reserva_geral);
            this.Controls.Add(this.btn_reserva_confirmada);
            this.Controls.Add(this.btn_reserva_cancelada);
            this.Controls.Add(this.dgv_reservas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarReserva";
            this.Text = "ConsultarReserva";
            this.Load += new System.EventHandler(this.ConsultarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busca_id_reserva;
        private System.Windows.Forms.DateTimePicker txt_checkout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_checkin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_quarto;
        private System.Windows.Forms.TextBox txt_cod_hosp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox txt_status;
        private System.Windows.Forms.DataGridView dgv_reservas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id_reserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reserva_confirmada;
        private System.Windows.Forms.Button btn_reserva_cancelada;
        private System.Windows.Forms.Button btn_reserva_geral;
        private System.Windows.Forms.Button btn_salvar;
    }
}