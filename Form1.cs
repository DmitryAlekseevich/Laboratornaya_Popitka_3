namespace Программа_весокосный_год__форма__3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, t;
            n = int.Parse(textBox1.Text);
            t = (n % 4);
            if (t == 0)
                textBox1.Text = "Ееееееееееее Год високосный!";
            else
                textBox1.Text = "Год не високосный :(";
        }
    }
}