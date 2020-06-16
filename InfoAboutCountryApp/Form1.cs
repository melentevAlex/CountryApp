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
        private string Mess;

        public string Mess1 { get => Mess; set => Mess = value; }

        public MainWindowForm()
        {
            InitializeComponent();
        }

        public void InputMethod()  // that method checks input for errors.
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
        public  void LableMethod() // that method transmits info that got in method GetInfoApi through properties to labels
        {
            CapitalLabel.Text = getInfo.Capital;
            AreaLabel.Text = getInfo.Area;
            PopulationLabel.Text = getInfo.Population;
            CodeLabel.Text = getInfo.Code;
            NameLabel.Text = getInfo.Name;
            RegionLabel.Text = getInfo.Region;
        }


        #region just actions with controls
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
                InputMethod(); // that method checks input for errors.
                getInfo.GetInfoAPI();
                LableMethod();
            }
            
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InputMustContainsOnlyLetters ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ThatCountryDoesNotExist ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public async void MethodDiagram() // that method shows dialog window
        {
            await Task.Run(() =>
            {
                DialogResult result = MessageBox.Show(
                "Save in the database?",
                "Message",

                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    saving = new Saving();

                    saving.Capital = CapitalLabel.Text;
                    saving.Area = AreaLabel.Text;
                    saving.Population = PopulationLabel.Text;
                    saving.Code = CodeLabel.Text;
                    saving.Name = NameLabel.Text;
                    saving.Region = RegionLabel.Text;
                    getInfo.GetInfoName(); // we need to check is there a country with that name in the DB, save names of countries from DB to list
                    try
                    {
                        getInfo.Checking(); // now, check
                        saving.MethSave(); // save a new position in DB
                    }
                    catch (AlreadyExistInDB ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }

            });

        }

        private void CapitalLabel_TextChanged_1(object sender, EventArgs e) // this event requires that country information appears on the form before the dialog box appears.
        {
            if (CapitalLabel.Text.Length > 0) //  if the label is filled with information
            {
                MethodDiagram(); // call the method that calls dialog

            }
        }
    }
}
