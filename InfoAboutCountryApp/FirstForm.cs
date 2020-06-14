using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutCountryApp
{
    public partial class FirstForm : Form
    {
        MainWindowForm mainWindow;
        ShowAllCountirs showAllCountirs;
        Point lastPoint;

        public FirstForm()
        {
            InitializeComponent();
        }

        private void SelectOneButton_MouseMove(object sender, MouseEventArgs e)
        {
            SelectOneButton.BackColor = Color.FromArgb(214, 238, 203);
        }

        private void SelectOneButton_MouseLeave(object sender, EventArgs e)
        {
            SelectOneButton.BackColor = Color.FromArgb(238, 227, 203);
        }

        private void ShowAllButton_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAllButton.BackColor = Color.FromArgb(214, 238, 203);
        }

        private void ShowAllButton_MouseLeave(object sender, EventArgs e)
        {
            ShowAllButton.BackColor = Color.FromArgb(238, 227, 203);
        }

        private void SelectOneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow = new MainWindowForm();
            mainWindow.Show();
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
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            showAllCountirs = new ShowAllCountirs();
            showAllCountirs.Show();
        }


    }
}
