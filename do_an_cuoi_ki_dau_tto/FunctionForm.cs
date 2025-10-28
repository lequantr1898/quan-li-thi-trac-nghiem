using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_cuoi_ki_dau_tto
{
    public partial class FuctionForm : Form
    {
        public FuctionForm()
        {
            InitializeComponent();
        }
        private Form currentForm = null;
        public void LoadFormToPanel(Form form)
        {
            if ( currentForm != null)
                currentForm.Close();

            currentForm = form;
            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnufile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new UserForm());
        }
    }
}
