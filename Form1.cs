namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passLenghtText.Text = passLenght.Value.ToString();
            passLenght.ValueChanged += Passlenght_ValueChanged;

        }

        private void Passlenght_ValueChanged(object sender, EventArgs e)
        {
            passLenghtText.Text = passLenght.Value.ToString();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            GenerateConfig config = getGenerateConfig();
            passBox.Text = PasswordGenHelper.GeneratePassword(config);
        }

        private GenerateConfig getGenerateConfig()
        {
            GenerateConfig config = new GenerateConfig();
            config.Lenght = passLenght.Value;
            config.IsLower = lowerCheck.Checked;
            config.IsUpper = upperCheck.Checked;
            config.IsDigit = digitCheck.Checked;
            config.IsSymbol = symbolCheck.Checked;
            return config;
        }

        // Event handler for the copy button
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        // Copies the password from passBox to clipboard
        private void CopyToClipboard()
        {
            if (!string.IsNullOrEmpty(passBox.Text))
            {
                Clipboard.SetText(passBox.Text);
                MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No password to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
