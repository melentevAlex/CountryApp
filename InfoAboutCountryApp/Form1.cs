using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Windows.Forms;
using ClassLibrary;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace InfoAboutCountryApp
{
    public partial class MainWindowForm : Form
    {
        Point lastPoint;
        Class1 class1;

        public MainWindowForm()
        {
            InitializeComponent();
        }


        public void Me()
        {
            class1 = new Class1();
            class1.Input = textBox1.Text.Substring(0, 3);

        }
        public void Me2()
        {
            CapitalLabel.Text = class1.Capital;
            AreaLabel.Text = class1.Area;
            PopulationLabel.Text = class1.Population;
            CodeLabel.Text = class1.Code;
            NameLabel.Text = class1.Name;
            RegionLabel.Text = class1.Region;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Me();
            class1.GetInfoAPI();
            Me2();

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void MinimyzeButton_Click(object sender, EventArgs e)
        {
            MinimyzeWindow();
        }

        public void MinimyzeWindow()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void CloseWindow()
        {
            Application.Exit();
        }



        public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=CountriesDB;Integrated Security=True";
        public void GetConnection()
        {
            SqlConnection Mycon = new SqlConnection(conString);

            Mycon.Open();

            string query = "SELECT Name FROM Countries";

            SqlCommand command = new SqlCommand(query, Mycon);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
            }
            reader.Close();
            Mycon.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            GetConnection();
        }
    }
}
