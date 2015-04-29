using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Menu_form : Form
    {
        object tl;
        public Menu_form(object sender)
        {
            InitializeComponent();
            tl = sender;
        }

        private void TL_menuItem_Click(object sender, EventArgs e)
        {
            (tl as Main_form).Visible = true;
            this.Dispose();
        }

        private void Solve_menuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void Desc_menuItem_Click(object sender, EventArgs e)
        {
            Description_form fr = new Description_form();
            fr.Show();
        }

        private void FC_menuItem_Click(object sender, EventArgs e)
        {
            Flowchart_form fr = new Flowchart_form();
            fr.Show();
        }

        private void Exit_menuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ref_menuItem_Click(object sender, EventArgs e)
        {
            ref_form fr = new ref_form();
            fr.Show();
        }

        private void About_nemuItem_Click(object sender, EventArgs e)
        {
            About_form fr = new About_form();
            fr.Show();
        }

        private void Menu_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
