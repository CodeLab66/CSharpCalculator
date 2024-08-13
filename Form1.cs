namespace Calculator
{
    public partial class Screen : Form
    {
        bool isFirst = true;
        double num1, num2;
        double number1;
        char op;
        private double Sin(double xDegrees)
        {
            double x = (xDegrees * Math.PI) / 180; // Convert degrees to radians

            double result = 0.0;
            double term = x;
            double sign = 1.0;

            for (int i = 3; i <= 15; i += 2) // Start from the third term and increment by 2
            {
                result += sign * term;
                sign *= -1;
                term *= (x * x) / (i * (i - 1));
            }

            return result;
        }
        private double Cos(double xDegrees)
        {
            double x = (xDegrees * Math.PI) / 180; // Convert degrees to radians

            double result = 0.0;
            double term = 1; // First term is always 1 for cosine
            double sign = 1.0;

            for (int i = 2; i <= 14; i += 2) // Start from the second term and increment by 2
            {
                result += sign * term;
                sign *= -1; // Toggle the sign for the next term
                term *= (x * x) / (i * (i - 1));
            }

            return result;
        }
        private double Tan(double xDegrees)
        {
            double sinX = Sin(xDegrees);
            double cosX = Cos(xDegrees);

            double tanX = sinX / cosX;
            return tanX;
        }
        private double Log(double x)
        {
            return Math.Log10(x);
        }
        private double logxy(double x, double y)
        {
            return Math.Log(y) / Math.Log(x);
        }
        private string DecimalToBinary(int decimalNumber)
        {
            string binaryResult = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binaryResult = remainder + binaryResult;
                decimalNumber = decimalNumber / 2;
            }
            return binaryResult;
        }
        private string DecimalToHexadecimal(int decimalNumber)
        {
            string hexResult = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16;
                if (remainder < 10)
                {
                    hexResult = remainder + hexResult;
                }
                else
                {
                    char hexChar = (char)(remainder - 10 + 'A');
                    hexResult = hexChar + hexResult;
                }
                decimalNumber = decimalNumber / 16;
            }
            return hexResult;
        }
        private string DecimalToOctal(int decimalNumber)
        {
            string octalResult = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 8;
                octalResult = remainder + octalResult;
                decimalNumber = decimalNumber / 8;
            }
            return octalResult;
        }
        private string BinaryToDecimal(string binaryNumber)
        {
            int decimalResult = 0;
            int power = 0;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                decimalResult += (int)(int.Parse(binaryNumber[i].ToString()) * Math.Pow(2, power));
                power++;
            }
            return decimalResult.ToString();
        }
        private string BinaryToHexadecimal(string binaryNumber)
        {
            string decimalNumber = BinaryToDecimal(binaryNumber);
            return DecimalToHexadecimal(int.Parse(decimalNumber));
        }
        private string BinaryToOctal(string binaryNumber)
        {
            string decimalNumber = BinaryToDecimal(binaryNumber);
            return DecimalToOctal(int.Parse(decimalNumber));
        }
        private string OctalToDecimal(string octalNumber)
        {
            int decimalResult = 0;
            int power = 0;
            for (int i = octalNumber.Length - 1; i >= 0; i--)
            {
                decimalResult += (int)(int.Parse(octalNumber[i].ToString()) * Math.Pow(8, power));
                power++;
            }
            return decimalResult.ToString();
        }
        private string OctalToBinary(string octalNumber)
        {
            string decimalNumber = OctalToDecimal(octalNumber);
            return DecimalToBinary(int.Parse(decimalNumber));
        }
        private string OctalToHexadecimal(string octalNumber)
        {
            string decimalNumber = OctalToDecimal(octalNumber);
            return DecimalToHexadecimal(int.Parse(decimalNumber));
        }
        private string HexadecimalToDecimal(string hexNumber)
        {
            int decimalResult = 0;
            int power = 0;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
                {
                    decimalResult += (int)(int.Parse(hexNumber[i].ToString()) * Math.Pow(16, power));
                }
                else
                {
                    decimalResult += (int)((hexNumber[i] - 'A' + 10) * Math.Pow(16, power));
                }
                power++;
            }
            return decimalResult.ToString();
        }
        private string HexadecimalToBinary(string hexNumber)
        {
            string decimalNumber = HexadecimalToDecimal(hexNumber);
            return DecimalToBinary(int.Parse(decimalNumber));
        }
        private string HexadecimalToOctal(string hexNumber)
        {
            string decimalNumber = HexadecimalToDecimal(hexNumber);
            return DecimalToOctal(int.Parse(decimalNumber));
        }





        public Screen()
        {
            InitializeComponent();
        }
        private void One_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "1";
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "0";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "2";
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "3";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "4";
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "5";
        }
        private void Six_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "6";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "7";
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "8";
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Display.Text = "";
                isFirst = false;
            }
            Display.Text += "9";
        }
        private void Subtract_Click(object sender, EventArgs e)
        {
            op = '-';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            op = 'x';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Sum_Click(object sender, EventArgs e)
        {
            op = '+';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            op = '/';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            if (op != 's' || op != 'c' || op != 't')
            {
                num2 = double.Parse(Display.Text);
            }
            else
            {
                num2 = 0;
            }
            switch (op)
            {
                case '+':
                    {
                        Display.Text = (num1 + num2).ToString();
                        break;
                    }
                case '-':
                    {
                        Display.Text = (num1 - num2).ToString();
                        break;
                    }
                case 'x':
                    {
                        Display.Text = (num1 * num2).ToString();
                        break;
                    }
                case '/':
                    {
                        Display.Text = (num1 / num2).ToString();
                        break;
                    }
                case 's':
                    {
                        Display.Text = Sin(number1).ToString();
                        break;
                    }
                case 'c':
                    {
                        Display.Text = Cos(number1).ToString();
                        break;
                    }
                case 't':
                    {
                        Display.Text = Tan(number1).ToString();
                        break;
                    }
                case 'p':
                    {
                        Display.Text = Math.Pow(num1, num2).ToString();
                        break;
                    }
                case 'm':
                    {
                        Display.Text = (num1 % num2).ToString();
                        break;
                    }
                case 'f':
                    {
                        double result = 1;
                        for (int i = 1; i <= num1; i++)
                        {
                            result *= i;
                        }
                        Display.Text = result.ToString();
                        break;
                    }
                case 'S':
                    {
                        double result = 0;
                        result = Math.Sqrt(num1);
                        Display.Text = result.ToString();
                        break;
                    }
                case 'l':
                    {
                        Display.Text = Log(num1).ToString();
                        break;
                    }
                case 'L':
                    {
                        Display.Text = logxy(num1, num2).ToString();
                        break;
                    }
                case 'r':
                    {
                        Display.Text = Math.Pow(num2, 1 / num1).ToString();
                        break;
                    }
                case 'e':
                    {
                        double result = num1;
                        for (int i = 1; i <= num2; i++)
                        {
                            result *= 10;
                        }
                        Display.Text = result.ToString();
                        break;
                    }
            }
        }
        private void ClearText_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            isFirst = true;
        }
        private void SinButton_Click(object sender, EventArgs e)
        {
            op = 's';
            number1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
        }
        private void CosButton_Click(object sender, EventArgs e)
        {
            op = 'c';
            number1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void TanButton_Click(object sender, EventArgs e)
        {
            op = 't';
            number1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Screen_Load(object sender, EventArgs e)
        {

        }
        private void Power_Click(object sender, EventArgs e)
        {
            op = 'p';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void mod_Click(object sender, EventArgs e)
        {
            op = 'm';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            op = 'S';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void fictorial_Click(object sender, EventArgs e)
        {
            op = 'f';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void logrithmic_Click(object sender, EventArgs e)
        {
            op = 'l';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void D2B_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = DecimalToBinary((int)num1);
        }
        private void D2O_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = DecimalToOctal((int)num1);
        }
        private void D2H_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = DecimalToHexadecimal((int)num1);
        }
        private void B2D_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = BinaryToDecimal(num1.ToString());
        }
        private void B2O_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = BinaryToOctal(num1.ToString());
        }
        private void B2H_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = BinaryToHexadecimal(num1.ToString());
        }
        private void O2H_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = OctalToHexadecimal(num1.ToString());
        }
        private void O2D_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = OctalToDecimal(num1.ToString());
        }
        private void O2B_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = OctalToBinary(num1.ToString());
        }
        private void H2D_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = HexadecimalToDecimal(num1.ToString());
        }
        private void H2B_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = HexadecimalToBinary(num1.ToString());
        }
        private void H2O_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = HexadecimalToOctal(num1.ToString());
        }
        private void Ln_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = Math.Log(num1).ToString();
        }
        private void LOGxY_Click(object sender, EventArgs e)
        {
            op = 'L';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void ePowx_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = Math.Exp(num1).ToString();
        }
        private void inverse_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = (1 / num1).ToString();
        }
        private void anyroot_Click(object sender, EventArgs e)
        {
            op = 'r';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }
        private void exp_Click(object sender, EventArgs e)
        {
            op = 'e';
            num1 = double.Parse(Display.Text);
            isFirst = true;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
            }
        }
    }
}
