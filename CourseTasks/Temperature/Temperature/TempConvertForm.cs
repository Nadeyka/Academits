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
    public partial class TempConvertForm : Form
    {
        public TempConvertForm()
        {
            InitializeComponent();
            IScale[] scaleList = { new CelsiumScale(), new KelvinScale(), new FahrenheitScale() };
            string[] scaleFromList = new string[scaleList.Length];
            string[] scaleToList = new string[scaleList.Length];
            for (int i = 0; i < scaleList.Length; ++i)
            {
                scaleFromList[i] = scaleList[i].ScaleName;
                scaleToList[i] = scaleList[i].ScaleName;
            }
            cbToTemp.DataSource = scaleToList;
            cbFromTemp.DataSource = scaleFromList;
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
                else
                {
                    lblInputTemp.Text = "Введите температуру:";
                    lblInputTemp.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {
                lblInputTemp.Text = "Введите число!";
                lblInputTemp.ForeColor = Color.Red;
                tbInputTemp.Clear();
            }
        }

        private void btnTempConvert_Click(object sender, EventArgs e)
        {
            labelResult.Text = "градусов";
            IScale[] scaleList = { new CelsiumScale(), new KelvinScale(), new FahrenheitScale() };
            IScale fromTemp = scaleList[0];
            IScale toTemp = scaleList[0];
            string selectedFromScale = (string)cbFromTemp.SelectedItem;
            string selectedToScale = (string)cbToTemp.SelectedItem;
            double temperatureValue = Convert.ToDouble(tbInputTemp.Text);
            labelResult.Text = TemperatureConverter.ConvertTemperature(scaleList, fromTemp, toTemp, selectedFromScale, selectedToScale, temperatureValue) + " " + labelResult.Text;
        }
    }
}
