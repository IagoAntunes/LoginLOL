using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginLOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNickname_Click(object sender, EventArgs e)
        {
            //adarjgeadwSADSFGwdasdfdgrearg
            //EEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
            //Teste 12345678

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("") || txtUser.Text.Equals(""))
            {
                MessageBox.Show("Opa");
            }
            else
            {
                if (txtUser.Text.Equals("iago1234") && txtSenha.Text.Equals("abcde"))
                {
                    new Parte2cs().Show();
                    this.Hide();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }
    }
}
