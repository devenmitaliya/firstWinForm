using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private NpgsqlConnection cn = new NpgsqlConnection("<YOUR-CONNECTION-STRING-HERE>");
        private System.Windows.Forms.Label lblMessage;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            string inputEmail = textBox1.Text.Trim();
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("<GMAIL-ID>");
            msg.To.Add(textBox1.Text.Trim());
            msg.Subject = "✅ Forgot Password Notification";

            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            smt.Port = 587;
            smt.EnableSsl = true;
            NetworkCredential ntcd = new NetworkCredential();
            ntcd.UserName = "<GMAIL-ADDRESS>";
            ntcd.Password = "<GMAIL-PASSKEY>";
            smt.Credentials = ntcd;

            using (NpgsqlConnection connection = new NpgsqlConnection("<YOUR-CONNECTION-STRING-HERE>"))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT c_signuppassword FROM t_signup WHERE c_signupemail = @Email";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Email", inputEmail);

                        object result = command.ExecuteScalar();

                        if (result != null) // Check if the result is not null before using it
                        {
                            msg.Body = $"Dear User,\n\n" +
            $"We received a request to retrieve your password.\n\n" +
            $"Your Password is: {result?.ToString()}\n\n" +
            $"If you did not make this request, please ignore this email.\n\n" +
            $"Best regards,\nGroup D Project";

                            smt.Send(msg);
                        }
                        else
                        {
                            MessageBox.Show("Email not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e)
    {
        string inputEmail = textBox1.Text.Trim();

        if (string.IsNullOrEmpty(inputEmail))
        {
            label7.Text = "Email is Required";
        }
        else
        {
            label7.Text = ""; // Clear the error message when there is content in the text box
        }
    }
    private void textBox2_KeyUp(object sender, KeyEventArgs e)
    {
        string inputPassword = textBox2.Text.Trim();

        if (string.IsNullOrEmpty(inputPassword))
        {
            label6.Text = "Password is Required";
        }
        else
        {
            label6.Text = ""; // Clear the error message when there is content in the text box
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string inputEmail = textBox1.Text.Trim();
        string inputPassword = textBox2.Text;

        if (string.IsNullOrEmpty(inputEmail) || string.IsNullOrEmpty(inputPassword))
        {
            MessageBox.Show("Please enter both email and password to check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            label6.Text = "Password required";
            label7.Text = "Email is Required";
            return;
        }

        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("<GMAIL-ADDRESS>");
        msg.To.Add(textBox1.Text.Trim());
        msg.Subject = "✅ Successful Login Notification";
        msg.Body = $@"Dear User,
I hope this message finds you well. We wanted to inform you that a successful login has been recorded for your account on Group D Project. 
We take the security of your account seriously and wanted to ensure that you are aware of this activity.

If you have recently accessed your account and recognize this login, there is no cause for concern. 
However, if you did not initiate this login or if you notice any suspicious activity, please contact our support team immediately at tailoranup071@gmail.com.

As always, we recommend regularly reviewing your account activity and updating your password to ensure the security of your account. 
If you have any questions or concerns, feel free to reach out to us at tailoranup071@gmail.com.

Thank you for choosing Group D Project.

Best regards,
Group D,
Deven Mitaliya.";

        MailMessage msg2 = new MailMessage();
        msg2.From = new MailAddress("<GMAIL-ADDRESS>");
        msg2.To.Add(textBox1.Text.Trim());
        msg2.Subject = "⚠️🛑 Suspicious Login Attempt Notification 🛑⚠️";
        msg2.Body = $@"Dear User,
We detected a login attempt on your Group D Project account that appears to be suspicious. 

If you recognize this login attempt and initiated it, you can disregard this message. However, if you did not attempt to log in or find this activity suspicious, please contact our support team immediately at tailoranup071@gmail.com.
For your account's safety, we recommend changing your password and enabling any additional security features available on your account.

Thank you for your attention to this matter.

Best regards,
Group D
Deven Mitaliya";



        SmtpClient smt = new SmtpClient();
        smt.Host = "smtp.gmail.com";
        smt.Port = 587;
        smt.EnableSsl = true;
        NetworkCredential ntcd = new NetworkCredential();
        ntcd.UserName = "<GMAIL-ADDRESS>";
        ntcd.Password = "<GMAIL-PASSKEY>";
        smt.Credentials = ntcd;



        using (NpgsqlConnection connection = new NpgsqlConnection("<YOUR-CONNECTION-STRING-HERE>"))
        {
            try
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM t_signup WHERE c_signupemail = @Email AND c_signuppassword = @Password";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Email", inputEmail);
                    command.Parameters.AddWithValue("@Password", inputPassword);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        smt.Send(msg);

                        //MessageBox.Show("Credentials match in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        smt.Send(msg2);
                        label6.Text = "** Incorrect password";
                        // MessageBox.Show("Credentials do not match in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void pictureBoxEye_Click(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;

        // Toggle the UseSystemPasswordChar property of the password TextBox
        textBox2.UseSystemPasswordChar = !isPasswordVisible;

        // Change the eye icon based on the visibility state
        pictureBoxEye.Image = isPasswordVisible ? System.Drawing.Image.FromFile("openeye.png") : System.Drawing.Image.FromFile("closeeye.png");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }
    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
        // Validate email format when the text changes
        ValidateEmail();
    }
    private void ValidateEmail()
    {
        string email = textBox1.Text.Trim();
        bool isValid = IsValidEmail(email);

        if (isValid)
        {
            // Clear the error if the email is valid
            errorProvider.SetError(textBox1, string.Empty);
        }
        else
        {
            // Display an error if the email is invalid
            errorProvider.SetError(textBox1, "Invalid email format");
        }
    }
    private bool IsValidEmail(string email)
    {
        // Use a regular expression for basic email validation
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, emailPattern);
    }

}
}
