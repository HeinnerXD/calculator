using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraPage : ContentPage
    {

        private String number1;
        private String number2;
        private String operation;
        private List<String> operationsList = new List<string>();
        public CalculadoraPage()
        {
            InitializeComponent();
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "0";
            }
            else
            {
                lblResult.Text += "0";
            }
            
        }
        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "1";
            }
            else
            {
                lblResult.Text += "1";
            }
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "2";
            }
            else
            {
                lblResult.Text += "2";
            }
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "3";
            }
            else
            {
                lblResult.Text += "3";
            }
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "4";
            }
            else
            {
                lblResult.Text += "4";
            }
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "5";
            }
            else
            {
                lblResult.Text += "5";
            }
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "6";
            }
            else
            {
                lblResult.Text += "6";
            }
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "7";
            }
            else
            {
                lblResult.Text += "7";
            }
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "8";
            }
            else
            {
                lblResult.Text += "8";
            }
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "9";
            }
            else
            {
                lblResult.Text += "9";
            }
        }

        private void ButtonDot_Clicked(object sender, EventArgs e)
        {
            if (lblResult.Text == "0")
            {
                lblResult.Text = "0.";
            }
            else
            {
                lblResult.Text += ".";
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            lblOperations.Text = "";
        }

        private void ButtonSign_Clicked(object sender, EventArgs e)
        {
            double stringNumber = Convert.ToDouble(lblResult.Text) * -1;
            lblResult.Text = stringNumber.ToString();
        }

        private void ButtonPercent_Clicked(object sender, EventArgs e)
        {
            number1 = lblResult.Text;
            operation = "percent";
            lblOperations.Text += String.Format("{0:00}", number1) + "%";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblResult.Text = "0";

        }

        private void ButtonDiv_Clicked(object sender, EventArgs e)
        {
            number1 = lblResult.Text;
            operation = "div";
            lblOperations.Text += String.Format("{0:00}", number1) + "/";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblResult.Text = "0";
        }

        private void ButtonTimes_Clicked(object sender, EventArgs e)
        {
            number1 = lblResult.Text;
            operation = "mult";
            lblOperations.Text += String.Format("{0:00}", number1) + "*";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblResult.Text = "0";
        }

        private void ButtonMinus_Clicked(object sender, EventArgs e)
        {
            number1 = lblResult.Text;
            operation = "subs";
            lblOperations.Text += String.Format("{0:00}", number1) + "-";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblResult.Text = "0";
        }

        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            number1 = lblResult.Text;
            operation = "sum";
            lblOperations.Text += String.Format("{0:00}", number1) + "+";
            operationsList.Add(number1);
            operationsList.Add(operation);
            lblResult.Text = "0";
        }

        private void ButtonResult_Clicked(object sender, EventArgs e)
        {
            number2 = lblResult.Text;
            lblOperations.Text += number2;
            operationsList.Add(number2);
            lblResult.Text = calculate(operationsList);
        }

        private String calculate(List<String> operationsList)
        {
            double actualNumber = 0;
            for (int i = 0; i < operationsList.Count; i++)
            {

                switch (operationsList[i])
                {
                    case "percent":
                        actualNumber = actualNumber * Convert.ToDouble(operationsList[i + 1]) / 100;
                        i++;
                        break;
                    case "div":
                        actualNumber = actualNumber / Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    case "mult":
                        actualNumber = actualNumber * Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    case "subs":
                        actualNumber = actualNumber - Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    case "sum":
                        actualNumber = actualNumber + Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    default:
                        actualNumber = Convert.ToDouble(operationsList[i]);
                        break;
                }
            }

            return actualNumber.ToString();
        }
    }
}