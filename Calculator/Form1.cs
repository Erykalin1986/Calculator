namespace Calculator
{
    public partial class Form1 : Form
    {
        private string act = "";
        private string tempParametr = "";
        private double tempMemory = 0;
        private bool flag = false;
        Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрывает приложение.
        /// </summary>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Разворачивет приложение на весь экран.
        /// </summary>
        private void MaxSizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaxSizeButton.Visible = false;
            this.NormalSizeButton.Visible = true;
        }

        /// <summary>
        /// Возвращает размеры приложения до нормальных значений.
        /// </summary>
        private void NormalSizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.NormalSizeButton.Visible = false;
            this.MaxSizeButton.Visible = true;
        }

        /// <summary>
        /// Сворачивет приложение.
        /// </summary>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Выводит на дисплей цифры и разделитель целых чисел.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            int tempNumber = 0;
            bool isNumber = int.TryParse(numButton.Text, out tempNumber);

            if (flag)
            {
                flag = false;
                textBox1.Text = "0";
            }

            if (textBox1.Text == "0" && isNumber) textBox1.Text = numButton.Text;
            else textBox1.Text = textBox1.Text + numButton.Text;
        }

        /// <summary>
        /// Очищает значение в поле ввода.
        /// </summary>
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        /// <summary>
        /// Очищает значения в поле ввода и введённое ранее его значение.
        /// </summary>
        private void ButtonC_Click(object sender, EventArgs e)
        {
            tempParametr = "";
            textBox1.Text = "0";
        }

        /// <summary>
        /// Удаляет последний символ из строки ввода.
        /// </summary>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.Length != 1) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else textBox1.Text = "0";
        }

        /// <summary>
        /// Разрешает писать в строке ввода только цифры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Аргументы события нажатия клавиши</param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char simbol = e.KeyChar;
            if (!Char.IsDigit(simbol)) e.Handled = true;
        }

        /// <summary>
        /// Действие с функциональными кнопками.
        /// </summary>
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Button buttonAct = (Button)sender;
            act = buttonAct.Text;
            tempParametr = textBox1.Text;
            flag = true;
        }

        /// <summary>
        /// Высчитывает необходимый процент от введённого ранее числа.
        /// </summary>
        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            double firstValue = 0;
            double secondValue = 0;
            double percent = 0;
            
            if (tempParametr != "")
            {
                double.TryParse(tempParametr, out firstValue);
                double.TryParse(textBox1.Text, out secondValue);
                percent = (firstValue * secondValue) / 100;
                textBox1.Text = percent.ToString();
            }
        }

        /// <summary>
        /// Высчитывает квадратный корень из числа.
        /// </summary>
        private void buttonRoot_Click(object sender, EventArgs e)
        {
            double value = 0;
            double.TryParse(textBox1.Text, out value);
            textBox1.Text = Math.Sqrt(value).ToString();
        }

        /// <summary>
        /// Возводит число в квадрат.
        /// </summary>
        private void buttonDegree_Click(object sender, EventArgs e)
        {
            double value = 0;
            double.TryParse(textBox1.Text, out value);
            textBox1.Text = (value * value).ToString();
        }

        /// <summary>
        /// Делит единичу на введённое число.
        /// </summary>
        private void button1X_Click(object sender, EventArgs e)
        {
            double value = 0;
            double.TryParse(textBox1.Text, out value);
            textBox1.Text = (1 / value).ToString();
        }

        /// <summary>
        /// Выводит результат вычисления.
        /// </summary>
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            double firstValue, secondValue, result = 0;

            double.TryParse(tempParametr, out firstValue);
            double.TryParse(textBox1.Text, out secondValue);

            if (act == "+") result = firstValue + secondValue;
            if (act == "-") result = firstValue - secondValue;
            if (act == "*") result = firstValue * secondValue;
            if (act == "/") result = firstValue / secondValue;

            textBox1.Text = result.ToString();
            flag = true;
        }

        /// <summary>
        /// Действие при движение мыши с зажатой левой клавишей.
        /// </summary>
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        /// <summary>
        /// Действие когда пользовтель отпустил левую кнопку мыши после перетаскивания.
        /// </summary>
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Делает отрицательным или наоборот значение в поле ввода.
        /// </summary>
        private void ButtonNegative_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                if (textBox1.Text.Contains("-")) textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = textBox1.Text.Insert(0, "-");
            }
        }

        /// <summary>
        /// Сохраняет число, отображенное в данный момент на дисплее калькулятора в память.
        /// </summary>
        private void ButtonMS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "0") double.TryParse(textBox1.Text, out tempMemory);
        }

        /// <summary>
        /// Вычитает из числа в памяти число, отображенное на дисплее калькулятора и результат записывает в память.
        /// </summary>
        private void ButtonMMinus_Click(object sender, EventArgs e)
        {
            double value = 0;

            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                double.TryParse(textBox1.Text, out value);
                tempMemory -= value;
            }
        }

        /// <summary>
        /// Прибавляет к числу из памяти число, отображенное на дисплее и результат записать в память вместо предыдущего.
        /// </summary>
        private void ButtonMPlus_Click(object sender, EventArgs e)
        {
            double value = 0;

            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                double.TryParse(textBox1.Text, out value);
                tempMemory += value;
            }
        }

        /// <summary>
        /// Считывает число из ячейки памяти и выводит его на дисплей.
        /// </summary>
        private void ButtonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = tempMemory.ToString();
        }

        /// <summary>
        /// Стерает данные из ячейки памяти.
        /// </summary>
        private void ButtonMC_Click(object sender, EventArgs e)
        {
            tempMemory = 0;
        }
    }
}