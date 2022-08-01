namespace Calculator
{
    public partial class Form1 : Form
    {
        private string act = "";
        private string tempParametr = "";
        private bool flag = false;

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
        /// Очищает значение в поле ввода и память.
        /// </summary>
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            tempParametr = "";
            textBox1.Text = "0";
        }

        /// <summary>
        /// Очищает значения в поле ввода.
        /// </summary>
        private void ButtonC_Click(object sender, EventArgs e)
        {
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
            decimal firstValue = 0;
            decimal secondValue = 0;
            decimal percent = 0;
            
            if (tempParametr != "")
            {
                Decimal.TryParse(tempParametr, out firstValue);
                Decimal.TryParse(textBox1.Text, out secondValue);
                percent = (firstValue * secondValue) / 100;
                textBox1.Text = percent.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void buttonRoot_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Возводит число в квадрат.
        /// </summary>
        private void buttonDegree_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            Decimal.TryParse(textBox1.Text, out value);
            textBox1.Text = (value * value).ToString();
        }

        /// <summary>
        /// Делит единичу на введённое число.
        /// </summary>
        private void button1X_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            Decimal.TryParse(textBox1.Text, out value);
            textBox1.Text = (1 / value).ToString();
        }

        /// <summary>
        /// Выводит результат вычисления.
        /// </summary>
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            decimal firstValue, secondValue, result = 0;

            Decimal.TryParse(tempParametr, out firstValue);
            Decimal.TryParse(textBox1.Text, out secondValue);

            if (act == "+") result = firstValue + secondValue;
            if (act == "-") result = firstValue - secondValue;
            if (act == "*") result = firstValue * secondValue;
            if (act == "/") result = firstValue / secondValue;

            textBox1.Text = result.ToString();
            flag = true;
        }

        Point lastPoint;
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
    }
}