namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbCharacters.Items.Add("Spongebob");
            cmbCharacters.Items.Add("Patrick");
            cmbCharacters.Items.Add("Mr. Krabs");
            cmbCharacters.Items.Add("Sandy");
        }

        private void CmbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (cmbCharacters.SelectedItem != null)
            {
                string selectedCharacter = cmbCharacters.SelectedItem.ToString();
                switch (selectedCharacter)
                {
                    case "Spongebob":
                        pbCharacter.Image = Properties.Resources.SpongeBob;
                        break;
                    case "Patrick":
                        pbCharacter.Image = Properties.Resources.Patrick;
                        break;
                    case "Mr. Krabs":
                        pbCharacter.Image = Properties.Resources.Mr__Krabs;
                        break;
                    case "Sandy":
                        pbCharacter.Image = Properties.Resources.Sandy;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a character first");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            pbCharacter.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}




