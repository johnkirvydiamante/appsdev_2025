using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Masahista", "This Guy's Inlove With u Mare", "Bantatay", "Ang Probinsyano", };
            Kirb1.Items.AddRange(movies);
            Kirb1.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Kirb1.Items)
            {
                bool isSelected = Kirb1.GetItemChecked(Kirb1.Items.IndexOf(item));
                if (isSelected && !Kirb2.Items.Contains(item))
                {
                    Kirb2.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kirb2.Items.Remove(Kirb2.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            Kirb2.Items.Clear();
        }
    }
}
