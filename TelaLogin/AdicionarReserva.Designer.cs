
namespace TelaLogin
{
    partial class AdicionarReserva
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
            this.btn_add_reserva = new System.Windows.Forms.Button();
            this.txt_valor_total = new System.Windows.Forms.TextBox();
            this.txt_quarto = new System.Windows.Forms.TextBox();
            this.txt_checkout = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_cod_hosp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_quartos = new System.Windows.Forms.Label();
            this.btn_calcular_reserva = new System.Windows.Forms.Button();
            this.txt_categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_reserva
            // 
            this.btn_add_reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_add_reserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_reserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_reserva.Location = new System.Drawing.Point(477, 359);
            this.btn_add_reserva.Name = "btn_add_reserva";
            this.btn_add_reserva.Size = new System.Drawing.Size(159, 45);
            this.btn_add_reserva.TabIndex = 29;
            this.btn_add_reserva.Text = "Concluir";
            this.btn_add_reserva.UseVisualStyleBackColor = false;
            this.btn_add_reserva.Click += new System.EventHandler(this.btn_add_reserva_Click);
            // 
            // txt_valor_total
            // 
            this.txt_valor_total.Enabled = false;
            this.txt_valor_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_total.Location = new System.Drawing.Point(469, 130);
            this.txt_valor_total.Name = "txt_valor_total";
            this.txt_valor_total.Size = new System.Drawing.Size(85, 27);
            this.txt_valor_total.TabIndex = 10;
            // 
            // txt_quarto
            // 
            this.txt_quarto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quarto.Location = new System.Drawing.Point(175, 171);
            this.txt_quarto.Name = "txt_quarto";
            this.txt_quarto.Size = new System.Drawing.Size(100, 27);
            this.txt_quarto.TabIndex = 9;
            // 
            // txt_checkout
            // 
            this.txt_checkout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_checkout.Location = new System.Drawing.Point(175, 127);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.Size = new System.Drawing.Size(125, 27);
            this.txt_checkout.TabIndex = 8;
            this.txt_checkout.Value = new System.DateTime(2021, 11, 7, 0, 0, 0, 0);
            this.txt_checkout.ValueChanged += new System.EventHandler(this.txt_checkout_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(375, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(61, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "CheckOut";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(77, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "CheckIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(86, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quarto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF do Hóspede";
            // 
            // txt_checkin
            // 
            this.txt_checkin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_checkin.Location = new System.Drawing.Point(175, 83);
            this.txt_checkin.Name = "txt_checkin";
            this.txt_checkin.Size = new System.Drawing.Size(125, 27);
            this.txt_checkin.TabIndex = 2;
            this.txt_checkin.Value = new System.DateTime(2021, 11, 7, 0, 0, 0, 0);
            this.txt_checkin.ValueChanged += new System.EventHandler(this.txt_checkin_ValueChanged);
            // 
            // txt_cod_hosp
            // 
            this.txt_cod_hosp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_hosp.Location = new System.Drawing.Point(175, 41);
            this.txt_cod_hosp.Name = "txt_cod_hosp";
            this.txt_cod_hosp.Size = new System.Drawing.Size(166, 27);
            this.txt_cod_hosp.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_quartos);
            this.groupBox1.Controls.Add(this.btn_calcular_reserva);
            this.groupBox1.Controls.Add(this.txt_categoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_valor_total);
            this.groupBox1.Controls.Add(this.txt_quarto);
            this.groupBox1.Controls.Add(this.txt_checkout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_checkin);
            this.groupBox1.Controls.Add(this.txt_cod_hosp);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(234, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 232);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira os dados da reserva abaixo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.AutoSize = true;
            this.txt_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(469, 88);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(72, 25);
            this.txt_status.TabIndex = 33;
            this.txt_status.Text = "Ativo";
            this.txt_status.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "R$";
            // 
            // lbl_quartos
            // 
            this.lbl_quartos.AutoSize = true;
            this.lbl_quartos.Location = new System.Drawing.Point(281, 178);
            this.lbl_quartos.Name = "lbl_quartos";
            this.lbl_quartos.Size = new System.Drawing.Size(106, 19);
            this.lbl_quartos.TabIndex = 31;
            this.lbl_quartos.Text = "Quartos 1-10";
            this.lbl_quartos.Visible = false;
            // 
            // btn_calcular_reserva
            // 
            this.btn_calcular_reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_calcular_reserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular_reserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_calcular_reserva.Location = new System.Drawing.Point(469, 178);
            this.btn_calcular_reserva.Name = "btn_calcular_reserva";
            this.btn_calcular_reserva.Size = new System.Drawing.Size(116, 40);
            this.btn_calcular_reserva.TabIndex = 30;
            this.btn_calcular_reserva.Text = "Calcular";
            this.btn_calcular_reserva.UseVisualStyleBackColor = false;
            this.btn_calcular_reserva.Click += new System.EventHandler(this.btn_calcular_reserva_Click);
            // 
            // txt_categoria
            // 
            this.txt_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_categoria.FormattingEnabled = true;
            this.txt_categoria.Items.AddRange(new object[] {
            "STANDART",
            "MASTER",
            "DELUXE"});
            this.txt_categoria.Location = new System.Drawing.Point(469, 40);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(121, 27);
            this.txt_categoria.TabIndex = 12;
            this.txt_categoria.SelectedIndexChanged += new System.EventHandler(this.txt_categoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categoria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(295, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cadastrar Reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelaLogin.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(234, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // AdicionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.btn_add_reserva);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarReserva";
            this.Text = "AdicionarReserva";
            this.Load += new System.EventHandler(this.AdicionarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_reserva;
        private System.Windows.Forms.TextBox txt_valor_total;
        private System.Windows.Forms.TextBox txt_quarto;
        private System.Windows.Forms.DateTimePicker txt_checkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_checkin;
        private System.Windows.Forms.TextBox txt_cod_hosp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txt_categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_calcular_reserva;
        private System.Windows.Forms.Label lbl_quartos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox txt_status;
        private System.Windows.Forms.Label label8;
    }
}