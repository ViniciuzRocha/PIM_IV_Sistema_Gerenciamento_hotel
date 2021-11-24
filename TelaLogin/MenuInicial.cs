using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TelaLogin
{
    public partial class MenuInicial : Form
    {
        public MenuInicial(int acesso)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
                switch (acesso)
                {
                    case 4: //recepcao
                        btn_funcionarios.Enabled = false;
                        btn_relatorios.Enabled = false;
                        break;
                    case 3: //admin
                        btn_reservas.Enabled = false;
                        btn_relatorios.Enabled = false;
                        break;
                    case 2: //gerente
                        break;

                }
        }
        private void FecharForm()
        {
            foreach (object item in barra_center.Controls)
            {
                if (item is Form)
                {
                    Form auxiliar = item as Form;
                    auxiliar.Close();
                }
            }
        } 

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_min.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_min.Visible = true;
        }

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cadastros_Click(object sender, EventArgs e)
        {

            if (submenu_cadastros.Visible == false)
            {
                submenu_cadastros.Visible = true;
                submenu_reservas.Visible = false;
                submenu_relatorios.Visible = false;
            }
            else
            {
                submenu_cadastros.Visible = false;
                
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {
            submenu_funcionarios.BringToFront();
            submenu_funcionarios.Visible = true;
            submenu_hospedes.Visible = false;
            FecharForm();
        }

        private void btn_add_funcionario_Click(object sender, EventArgs e)
        {
            submenu_funcionarios.Visible = false;
            submenu_cadastros.Visible = false;
            tela_adiciona_funcionario(new AdicionarFuncionario());
        }
        private void tela_adiciona_funcionario(object add_user)
        {
            /* this.WindowState = FormStartPosition.CenterScreen(Controls.Add);
            this.WindowState =*/ 

            //if (this.barra_center.Controls.Count > 2) ;
            Form adiciona_user = add_user as Form;
            adiciona_user.TopLevel = false;
            this.barra_center.Controls.Add(adiciona_user);
            this.barra_center.Tag = adiciona_user;
            adiciona_user.Show();
        }
        private void btn_consulta_funcionario_Click(object sender, EventArgs e)
        {
            submenu_funcionarios.Visible = false;
            submenu_cadastros.Visible = false;
            tela_consulta_funcionario(new ConsultarFuncionario());
        }
        private void tela_consulta_funcionario(object consult_user)
        {
            Form consulta_user = consult_user as Form;
            consulta_user.TopLevel = false;
            this.barra_center.Controls.Add(consulta_user);
            this.barra_center.Tag = consulta_user;
            consulta_user.Show();
        }

        private void btn_hospedes_Click(object sender, EventArgs e)
        {
            FecharForm();
            submenu_hospedes.BringToFront();
            submenu_hospedes.Visible = true;
            submenu_funcionarios.Visible = false;
            
        }

        private void btn_add_hospede_Click(object sender, EventArgs e)
        {
            submenu_hospedes.Visible = false;
            submenu_cadastros.Visible = false;
            /*AdicionarHospede tela_add_hosp = new AdicionarHospede(); --CASO USE POP-UP
            tela_add_hosp.Show();
            this.Hide();*/
            tela_adiciona_hospede(new AdicionarHospede());
        }
        private void tela_adiciona_hospede(object add_hosp)  //FUNÇÃO PARA ATIVAR O ADD USER DA LINHA 66
        {
            /*if (this.barra_center.Controls.Count > 0)
                this.barra_center.Controls.RemoveAt(0);*/
            Form adiciona_hosp = add_hosp as Form;
            adiciona_hosp.TopLevel = false;
            this.barra_center.Controls.Add(adiciona_hosp);
            this.barra_center.Tag = adiciona_hosp;
            adiciona_hosp.Show();
        }

        private void btn_consulta_hospede_Click(object sender, EventArgs e)
        {
            submenu_hospedes.Visible = false;
            submenu_cadastros.Visible = false;
            tela_consulta_hospede(new ConsultarHospede());
        }
        private void tela_consulta_hospede(object consult_hosp)
        {
            Form consulta_hosp = consult_hosp as Form;
            consulta_hosp.TopLevel = false;
            this.barra_center.Controls.Add(consulta_hosp);
            this.barra_center.Tag = consulta_hosp;
            consulta_hosp.Show();
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            if (submenu_reservas.Visible == false)
            {
                submenu_reservas.Visible = true;
                submenu_cadastros.Visible = false;
                submenu_relatorios.Visible = false;
                
            }
            else
            {
                submenu_reservas.Visible = false;
            }
        }

        private void submenu_cadastros_VisibleChanged(object sender, EventArgs e)
        {
            if (submenu_cadastros.Visible==false)
            {
                submenu_funcionarios.Visible = false;
                submenu_hospedes.Visible = false;
                
                
            }
        }

        private void btn_realiza_reserva_Click(object sender, EventArgs e)
        {
            FecharForm();
            submenu_reservas.Visible = false;
            tela_adiciona_reserva(new AdicionarReserva());

        }
        private void tela_adiciona_reserva(object add_reserva)
        {
            //if (this.barra_center.Controls.Count > 2) ;
            Form adiciona_reserva = add_reserva as Form;
            adiciona_reserva.TopLevel = false;
            this.barra_center.Controls.Add(adiciona_reserva);
            this.barra_center.Tag = adiciona_reserva;
            adiciona_reserva.Show();
        }

        private void btn_consulta_reserva_Click(object sender, EventArgs e)
        {
            FecharForm();
            submenu_reservas.Visible = false;
            tela_consulta_reserva(new ConsultarReserva());

        }
        private void tela_consulta_reserva(object cons_reserva)
        {
            //if (this.barra_center.Controls.Count > 2) ;
            Form consulta_reserva = cons_reserva as Form;
            consulta_reserva.TopLevel = false;
            this.barra_center.Controls.Add(consulta_reserva);
            this.barra_center.Tag = consulta_reserva;
            consulta_reserva.Show();
        }
        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            FecharForm();
            submenu_funcionarios.Visible = false;
            submenu_hospedes.Visible = false;
            submenu_cadastros.Visible = false;
            submenu_reservas.Visible = false;
            tela_consulta_relatorios(new RelatoriosGerais());

            /*if (submenu_relatorios.Visible == false)
            {
                submenu_relatorios.Visible = true; ESSE É O ERRADO, USAR O BACKUP
                submenu_reservas.Visible = false;
                submenu_cadastros.Visible = false;
            }
            else
            {
                submenu_relatorios.Visible = false;
            }*/
        }
        private void tela_consulta_relatorios(object consulta_relatorio)
        {
            Form Relatorios = consulta_relatorio as Form;
            Relatorios.TopLevel = false;
            this.barra_center.Controls.Add(Relatorios);
            this.barra_center.Tag = Relatorios;
            Relatorios.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barra_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_LogOff_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form tela in Application.OpenForms)
            {
                if (tela is tela_login)
                {

                    tela.Show();
                }
            }
            
        }

        private void botao_off_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form tela in Application.OpenForms)
            {
                if (tela is tela_login)
                {

                    tela.Show();
                }
            }
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por:\nVinicius Rocha\n\nVersão do sistema: 1.0.0.0", "Sobre o Sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
