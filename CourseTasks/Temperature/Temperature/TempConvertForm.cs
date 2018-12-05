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
            cbToTemp.DataSource = scaleList;
            cbFromTemp.DataSource = scaleList;
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
            //IScale[] scaleList = { new CelsiumScale(), new KelvinScale(), new FahrenheitScale() };
            IScale fromTemp = (IScale)cbFromTemp.SelectedItem;
            IScale toTemp = (IScale)cbToTemp.SelectedItem;
            labelResult.Text = fromTemp.ConvertTempToCelsium(Convert.ToDouble(tbInputTemp.Text)) + toTemp.ConvertTempFromCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text;
            //KelvinScale kelvinScale = new KelvinScale();
            //FahrenheitScale fahrenheitScale = new FahrenheitScale();
            //switch (cbFromTemp.SelectedIndex)
            //{
            //    case 0:
            //        switch (cbToTemp.SelectedIndex)
            //        {
            //            case 0:
            //                labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Цельсия";
            //                break;
            //            case 1:
            //                labelResult.Text = kelvinScale.ConvertTempFromCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Кельвина";
            //                break;
            //            case 2:
            //                labelResult.Text = fahrenheitScale.ConvertTempFromCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Фаренгейта";
            //                break;
            //        }
            //        break;
            //    case 1:
            //        switch (cbToTemp.SelectedIndex)
            //        {
            //            case 0:
            //                labelResult.Text = kelvinScale.ConvertTempToCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Цельсия";
            //                break;
            //            case 1:
            //                labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Кельвина";
            //                break;
            //            case 2:
            //                double fahrenheitConst = 32;
            //                labelResult.Text = kelvinScale.ConvertTempToCelsium(Convert.ToDouble(tbInputTemp.Text)) * 9 / 5 + fahrenheitConst + " " + labelResult.Text + " Фаренгейта";
            //                break;
            //        }
            //        break;
            //    case 2:
            //        switch (cbToTemp.SelectedIndex)
            //        {
            //            case 0:
            //                labelResult.Text = fahrenheitScale.ConvertTempToCelsium(Convert.ToDouble(tbInputTemp.Text)) + " " + labelResult.Text + " Цельсия";
            //                break;
            //            case 1:
            //                double kelvinConst = 273.15;
            //                labelResult.Text = fahrenheitScale.ConvertTempToCelsium(Convert.ToDouble(tbInputTemp.Text)) + kelvinConst + " " + labelResult.Text + " Кельвина";
            //                break;
            //            case 2:
            //                labelResult.Text = tbInputTemp.Text + " " + labelResult.Text + " Фаренгейта";
            //                break;
            //        }
            //        break;
            //}
        }
    }
}
