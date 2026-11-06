using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WinFormsApp8
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void saveChangesButton_Click(object? sender, EventArgs e)
        {
            string name = fullNameTextBox.Text.Trim();
            string username = usernameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(this, "Enter both your full name and username.", "Check account details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _ = new MailAddress(email);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Enter a valid email address.", "Check account details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                return;
            }

            MessageBox.Show(this, "Account details are valid. No database connection is configured, so changes remain local.",
                "Account details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updatePasswordButton_Click(object? sender, EventArgs e)
        {
            string currentPassword = currentPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmation = confirmPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                ShowPasswordValidationMessage("Enter your current password.", currentPasswordTextBox);
                return;
            }

            if (!Regex.IsMatch(newPassword, @"^(?=.*[A-Za-z])(?=.*\d).{8,}$"))
            {
                ShowPasswordValidationMessage("Use at least 8 characters, including a letter and a number.", newPasswordTextBox);
                return;
            }

            if (!string.Equals(newPassword, confirmation, StringComparison.Ordinal))
            {
                passwordMismatchLabel.Text = "Passwords do not match";
                passwordMismatchLabel.Visible = true;
                passwordMismatchIconLabel.Visible = true;
                confirmPasswordTextBox.BackColor = Color.FromArgb(255, 248, 248);
                confirmPasswordTextBox.Focus();
                return;
            }

            passwordMismatchLabel.Visible = false;
            passwordMismatchIconLabel.Visible = false;
            confirmPasswordTextBox.BackColor = Color.White;
            MessageBox.Show(this, "Password fields are valid. No password service is configured, so no password was changed.",
                "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void passwordFields_TextChanged(object? sender, EventArgs e)
        {
            bool hasConfirmation = !string.IsNullOrEmpty(confirmPasswordTextBox.Text);
            bool passwordsMatch = string.Equals(newPasswordTextBox.Text, confirmPasswordTextBox.Text, StringComparison.Ordinal);
            bool showMismatch = hasConfirmation && !passwordsMatch;

            passwordMismatchLabel.Visible = showMismatch;
            passwordMismatchIconLabel.Visible = showMismatch;
            confirmPasswordTextBox.BackColor = showMismatch ? Color.FromArgb(255, 248, 248) : Color.White;
        }

        private void ShowPasswordValidationMessage(string message, TextBox textBox)
        {
            MessageBox.Show(this, message, "Check password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
        }
    }
}
