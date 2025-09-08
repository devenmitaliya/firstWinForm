namespace FirstWinForm;

public partial class CalcDemo : Form
{   
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textbox1;
    private TextBox textbox2;
    private TextBox textbox3;
    private Button btn_1;
    private Button btn_2;
    private Button btn_3;
    private Button btn_4;

    public CalcDemo()
    {
        InitializeComponent();
    }
    private void button_Click(object sender, EventArgs e)
    {
        Button clickedButton = sender as Button;

        if (clickedButton != null)
        {
            double num1 = double.Parse(textbox1.Text);
            double num2 = double.Parse(textbox2.Text);
            double result = 0;

            // Perform the corresponding operation based on the button text
            switch (clickedButton.Text)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Check for division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
            }

            // Display the result in textBox3
            textbox3.Text = result.ToString();
        }
    }
}
