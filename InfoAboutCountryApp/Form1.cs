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
using System.Data;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfoAboutCountryApp
{
    public partial class MainWindowForm : Form
    {
        Point lastPoint;
        FirstForm firstForm;
        GetInfo getInfo;
        Saving saving;
        

        public MainWindowForm()
        {
            InitializeComponent();
        }

        public void InputMethod()
        {


            if (textBox1.Text.Length < 3)
            {
                throw new MyException();

            }

            Regex regex = new Regex(@"[^a-zA-Z]");
            MatchCollection matchCollection = regex.Matches(textBox1.Text);
            if (matchCollection.Count > 0)
            {
                throw new InputMustContainsOnlyLetters();
            }
            else
            {
                getInfo = new GetInfo();
                getInfo.Input = textBox1.Text.Substring(0, 3);
            }
      

        }
        public void LableMethod()
        {
            CapitalLabel.Text = getInfo.Capital;
            AreaLabel.Text = getInfo.Area;
            PopulationLabel.Text = getInfo.Population;
            CodeLabel.Text = getInfo.Code;
            NameLabel.Text = getInfo.Name;
            RegionLabel.Text = getInfo.Region;

            saving = new Saving();

            saving.Capital = CapitalLabel.Text;
            saving.Area = AreaLabel.Text;
            saving.Population = PopulationLabel.Text;
            saving.Code = CodeLabel.Text;
            saving.Name = NameLabel.Text;
            saving.Region = RegionLabel.Text;
        }


        #region 
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


        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm = new FirstForm();
            firstForm.Show();
        }

        #endregion


        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                InputMethod();
                getInfo.GetInfoAPI();
                LableMethod();
            
                MethDialWin();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InputMustContainsOnlyLetters ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            catch (ThatCountryDoesNotExist ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            
        }
        
        public void MethDialWin()
        {

            DialogResult result = MessageBox.Show(
            "Save in the database?",
            "Message",

            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                saving.MethSave();

            this.TopMost = true;



        }
    }
}
