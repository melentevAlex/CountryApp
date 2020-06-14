using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace InfoAboutCountryApp
{
    public partial class ShowAllCountirs : Form
    {
        Connection connection;
        Point lastPoint;
        FirstForm firstForm;

        public ShowAllCountirs()
        {
            InitializeComponent();
        }

        private void ShowAvaiableButton_Click(object sender, EventArgs e)
        {
            connection = new Connection();
            connection.GetConnection();
            List<string[]> da = connection.Data;
            foreach (string[] s in da)
                dataGridView1.Rows.Add(s);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimyzeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm = new FirstForm();
            firstForm.Show();
        }
    }
}
