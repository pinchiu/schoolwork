using System.Drawing;
using System.Windows.Forms;

namespace 萬事如意
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);
        }
    }
}