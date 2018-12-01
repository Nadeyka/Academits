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
                            CelsiumToKelvinConverter celsiumToKelvin = new CelsiumToKelvinConverter();
                            labelResult.Text = celsiumToKelvin.ConvertTemp(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Кельвина";
                            break;
                        case 2:
                            CelsiumToFahrenheitConverter celsiumToFahrenheit = new CelsiumToFahrenheitConverter();
                            labelResult.Text = celsiumToFahrenheit.ConvertTemp(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Фаренгейта";
                            break;
                    }
                    break;
                case 1:
                    switch (cbToTemp.SelectedIndex)
                    {
                        case 0:
                            KelvinToCelsiumConverter kelvinToCelsium = new KelvinToCelsiumConverter();
                            labelResult.Text = kelvinToCelsium.ConvertTemp(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Цельсия";
                            break;
                        case 1:
                            labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Кельвина";
                            break;
                        case 2:
                            KelvinToFahrenheitConverter kelvinToFahrenheit = new KelvinToFahrenheitConverter();
                            labelResult.Text = kelvinToFahrenheit.ConvertTemp(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Фаренгейта";
                            break;
                    }
                    break;
                case 2:
                    switch (cbToTemp.SelectedIndex)
                    {
                        case 0:
                            FahrenheitToCelsiumConverter fahrenheitToCelsium = new FahrenheitToCelsiumConverter();
                            labelResult.Text = fahrenheitToCelsium.ConvertTemp(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Цельсия";
                            break;
                        case 1:
                            FahrenheitToKelvinConverter fahrenheitToKelvin = new FahrenheitToKelvinConverter();
                            labelResult.Text = fahrenheitToKelvin.ConvertTemp(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Кельвина";
                            break;
                        case 2:
                            labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Фаренгейта";
                            break;
                    }
                    break;
            }
        }
    }
}
