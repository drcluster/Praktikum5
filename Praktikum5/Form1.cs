namespace Praktikum5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int number;
        public Form1()
        {
            InitializeComponent();
            number = rnd.Next(101);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            if (guess < number) {
                label2.Text = "Too low, try again!";
            } else if (guess > number)
            {
                label2.Text = "Too high, try again!";
            } else
            {
                label2.Text = "Correct! The number was: " + number.ToString() + ". New number is generated.";
                number = rnd.Next(101);
            }
        }
    }
}
