using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbFromTemp.SelectedIndex = 0;
            cbToTemp.SelectedIndex = 0;
        }

        private void tbInputTemp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(tbInputTemp.Text, out double n))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число!");
                tbInputTemp.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = "градусов";
            switch (cbFromTemp.SelectedIndex)
            {
                case 0:
                    switch (cbToTemp.SelectedIndex)
                    {
                        case 0:
                            labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Цельсия";
                            break;
                        case 1:
                            labelResult.Text = CelsiumToKelvin(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Кельвина";
                            break;
                        case 2:
                            labelResult.Text = CelsiumToFarengeit(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Фаренгейта";
                            break;
                    }
                    break;
                case 1:
                    switch (cbToTemp.SelectedIndex)
                    {
                        case 0:
                            labelResult.Text = KelvinToCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Цельсия";
                            break;
                        case 1:
                            labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Кельвина";
                            break;
                        case 2:
                            labelResult.Text = KelvinToFarengeit(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Фаренгейта";
                            break;
                    }
                    break;
                case 2:
                    switch (cbToTemp.SelectedIndex)
                    {
                        case 0:
                            labelResult.Text = FarengeitToCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Цельсия";
                            break;
                        case 1:
                            labelResult.Text = FarengeitToKelvin(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Кельвина";
                            break;
                        case 2:
                            labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Фаренгейта";
                            break;
                    }
                    break;
            }
        }

        private double CelsiumToKelvin(double degree)
        {
            double kelvinConst = 273.15;
            return degree + kelvinConst;
        }

        private double KelvinToCelsium(double degree)
        {
            double kelvinConst = 273.15;
            return degree - kelvinConst;
        }

        private double CelsiumToFarengeit(double degree)
        {
            double farengeitConst = 32;
            return degree * 9 / 5 + farengeitConst;
        }

        private double FarengeitToCelsium(double degree)
        {
            double farengeitConst = 32;
            return (degree - farengeitConst) * 5 / 9;
        }

        private double FarengeitToKelvin(double degree)
        {
            double farengeitConst = 32;
            double kelvinConst = 273.15;
            return (degree - farengeitConst) * 5 / 9 + kelvinConst;
        }

        private double KelvinToFarengeit(double degree)
        {
            double farengeitConst = 32;
            double kelvinConst = 273.15;
            return (degree - kelvinConst) * 9 / 5 + farengeitConst;
        }
    }
}
