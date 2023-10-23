namespace TestForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            double First, Second, Third;
            if (!double.TryParse(FirstTextBox.Text, out First) || !double.TryParse(SecondTextBox.Text, out Second) || !double.TryParse(ThirdTextBox.Text, out Third))
            {
                ResoltLable.Text = "Некорретные значения";
            }
            else if (First <= 0 || Second <= 0 || Third <= 0)
            {
                ResoltLable.Text = "Введены числа равные нулю или меньше";
            }
            else if (First + Second <= Third || First + Third <= Second || Second + Third <= First)
            {
                ResoltLable.Text = "Данного треугольника не существует";
            }
            else if (First == Second && First == Third)
            {
                ResoltLable.Text = "Данный треугольник равносторонний";
            }
            else if (First == Second || First == Third || Second == Third)
            {
                ResoltLable.Text = "Данный треугольник равнобедренный";
            }
            else
            {
                ResoltLable.Text = "Данный треугольник неравносторонний";
            }
        }
    }
}