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
using PIM_IV_MODEL;
using PIM_IV_DAL;

namespace TelaLogin
{

    public partial class tela_login : Form
    {

        public tela_login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            Funcionario funcionario = new Funcionario ();
            FuncionarioDAO loginDAL = new FuncionarioDAO();
            MessageBox.Show(loginDAL.LoginFuncionario(txt_user.Text, txt_pass.Text, out int acesso));
            if (acesso == 2 || acesso == 3 || acesso ==4)
            {
                MenuInicial menu_inicial = new MenuInicial(acesso);
                this.Hide();
                menu_inicial.Show();
            }

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

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuInicial menu_inicial = new MenuInicial(2);
            this.Hide();
            menu_inicial.Show();
        }
    }
}
