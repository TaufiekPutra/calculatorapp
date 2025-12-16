using TestingForm.Repository;

namespace TestingForm
{
    public partial class MainForm : Form
    {
        public int numberTextBoxValueInt = 0;
        public string numberTextBoxValueStr = string.Empty;
        public CalculatorRepository calculatorRepo = new CalculatorRepository();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Designer Function
        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (calculatorRepo.IsValidInputChar(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int result = calculatorRepo.Calculate(numberTextBoxValueInt);
            int reverseNumber = calculatorRepo.ReverseNumber(numberTextBoxValueInt);

            MessageBox.Show(
                $"Submit Number: {numberTextBoxValueInt}\n" +
                $"Reverse Number:  {reverseNumber}\n" +
                $"Result Number: {Math.Abs(result)}",
                "Calculation Result Number",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                numberTextBoxValueStr = textBox.Text ?? string.Empty;
            }

            numberTextBoxValueInt = calculatorRepo.CleanInput(numberTextBoxValueStr);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void LabelNumber_Click(object sender, EventArgs e) { }
        #endregion

    }
}
