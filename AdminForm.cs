using Login1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemPhatPhim
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemPhim themPhim = new ThemPhim();
            themPhim.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btQLUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLUsers QLUsers = new QLUsers();
            QLUsers.ShowDialog();
        }
    }
}
