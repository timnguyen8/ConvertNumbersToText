using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_To_Text_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInputString_MouseClick(object sender, MouseEventArgs e)
        {
            txtInputString.Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            char ch = '.';
            string integerString = "", fractionalString = "", result = "";
            string cent = "Cent", dollar = "Dollar";
            double inputDouble = 0.0;

            if ((txtInputString.Text == "")|| txtInputString.Text =="$00.00") { txtInputString.Text = "0.00"; };
            string inputValue = txtInputString.Text;           

            inputDouble = double.Parse(inputValue);
            if (inputDouble < 0)
            {
                txtOutputString.Text = "Input Number should not be negative, Please try again!!";
            }
            else if (inputDouble > 1000000000)
            {
                txtOutputString.Text = "Input Number is too big, Please try again!!";
            }
            else
            {


                int inputLength = inputValue.Length;
                //find the index of "." in input value 
                int indexOfDot = inputValue.IndexOf(ch);

                //if input without fraction
                if (!inputValue.Contains(ch))
                {
                    fractionalString = "00";
                    integerString = inputValue;
                }
                else
                {
                    fractionalString = inputValue.Substring(indexOfDot + 1);

                    if (fractionalString.Length == 0)
                    {
                        inputValue += "00";
                        fractionalString = "00";
                        integerString = inputValue.Substring(0, inputLength - 1);
                    }
                    else if (fractionalString.Length == 1)
                    {

                        fractionalString = inputValue.Substring(indexOfDot + 1) + "0";
                        integerString = inputValue.Substring(0, inputLength - 2);
                    }
                    else if (fractionalString.Length == 2)
                    {
                        integerString = inputValue.Substring(0, inputLength - 3);
                        fractionalString = inputValue.Substring(indexOfDot + 1, 2);

                    }
                    else if (fractionalString.Length > 2)
                    {
                        integerString = inputValue.Substring(0, inputLength - fractionalString.Length - 1);
                        fractionalString = inputValue.Substring(indexOfDot + 1, 2);

                    }


                }


                //Convert two strings to interger value
                int integerPart = int.Parse(integerString);
                int fractionalPart = int.Parse(fractionalString);


                //Cents or Cent and Nothing 
                if (fractionalPart == 0) { cent = ""; }
                else if (fractionalPart > 1) { cent += "s"; };
                //Dollars or Dollar And Nothing
                if (integerPart == 0) { dollar = ""; }
                else if (integerPart > 1) { dollar += "s"; };

                //Format output 

                if ((fractionalPart == 0) && (integerPart != 0))
                {
                    result = string.Format("{0:C2}: \t{1} {2}",Double.Parse(integerString + "." + fractionalString), convertNumberToText(integerPart), dollar);
                }
                else if ((fractionalPart != 0) && (integerPart == 0))
                {
                    result = string.Format("{0:C2}: \t{1} {2}", Double.Parse(integerString + "." + fractionalString), convertNumberToText(fractionalPart), cent);
                }
                else if ((fractionalPart == 0) && (integerPart == 0))
                {
                    result = string.Format("{0:C2}: \t{1} {2}",Double.Parse(integerString + "." + fractionalString), convertNumberToText(integerPart), dollar);
                }
                else
                {
                    result = string.Format("{0:C2}: \t{1} {2} And {3} {4}",Double.Parse(integerString + "." + fractionalString), convertNumberToText(integerPart), dollar, convertNumberToText(fractionalPart), cent);
                    ;

                }

                txtOutputString.Text = result.ToString();
            }
        }

        /* 
         *Using recursion to convert data in chunks of input
         */

        private string convertNumberToText(int value)
        {

            const int HUNDRED = 100, THOUSAND = 1000, MILLON = 1000000, BILLION = 1000000000;

            if (value < HUNDRED)
            {
                switch (value)
                {
                    case 0: return "Zero";
                    case 1: return "One";
                    case 2: return "Two";
                    case 3: return "Three";
                    case 4: return "Four";
                    case 5: return "Five";
                    case 6: return "Six";
                    case 7: return "Seven";
                    case 8: return "Eight";
                    case 9: return "Nine";
                    case 10: return "Ten";
                    case 11: return "Eleven";
                    case 12: return "Twelve";
                    case 13: return "Thirteen";
                    case 14: return "Fourteen";
                    case 15: return "Fifteen";
                    case 16: return "Sixteen";
                    case 17: return "Seventeen";
                    case 18: return "Eighteen";
                    case 19: return "Nineteen";
                    case 20: return "Twenty";
                    case 30: return "Thirty";
                    case 40: return "Forty";
                    case 50: return "Fifty";
                    case 60: return "Sixty";
                    case 70: return "Seventy";
                    case 80: return "Eighty";
                    case 90: return "Ninety";
                    
                    default:
                        int numberPart = value % 10;
                        int numberX10Part = value - numberPart;
                        return convertNumberToText(numberX10Part) + "-" + convertNumberToText(numberPart);

                }
            }
            else if (value < THOUSAND)
            {
                int hundredPart = value / HUNDRED;
                int hundredRemain = value % HUNDRED;
                if (hundredRemain == 0)
                {
                    return convertNumberToText(hundredPart) + " Hundred ";
                }
                else
                {
                    return convertNumberToText(hundredPart) + " Hundred and " + convertNumberToText(hundredRemain);
                }
            }
            else if (value < MILLON)
            {
                if ((value % THOUSAND) == 0)
                {
                    return convertNumberToText(value / THOUSAND) + " Thousand ";
                }
                else
                {
                    return convertNumberToText(value / THOUSAND) + " Thousand, " + convertNumberToText(value % THOUSAND);
                }

                
            }
            else if (value < BILLION)
            {
                if ((value % THOUSAND) == 0)
                {
                    return convertNumberToText(value / MILLON) + " Million ";
                }
                else
                {
                    return convertNumberToText(value / MILLON) + " Million, " + convertNumberToText(value % MILLON);
                }
                
            }
            else
            {
                return "Out of Range";
            }

        }  
    }
}
