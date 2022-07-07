using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Demo2
{
    public class SignUpDialogBox
    {
        private TextBox usernameTextBox = new TextBox();
        private TextBox passwordTextBox = new TextBox();
        private CheckBox agreeToTermsCheckBox = new CheckBox();
        private Button signUpButton = new Button();

        public SignUpDialogBox()
        {
            //usernameTextBox.AddEventHandler();
            //passwordTextBox.AddEventHandler();
            //agreeToTermsCheckBox.AddEventHandler();

            //usernameTextBox.addEventHandler(this::controlChanged);
            //passwordTextBox.addEventHandler(this::controlChanged);
            //agreeToTermsCheckBox.addEventHandler(this::controlChanged);
        }

        private void ControlChanged() => signUpButton.SetEnabled(IsFormValid());
        private bool IsFormValid() => 
            !usernameTextBox.IsEmpty() && !passwordTextBox.IsEmpty() && agreeToTermsCheckBox.IsChecked();

        public void SimulateUserInteraction()
        {
            // Initially the button should be disabled
            Console.WriteLine("Initially: " + signUpButton.IsEnabled());

            // The user enters their username, the button is still disabled
            usernameTextBox.SetContent("username");
            Console.WriteLine("After setting the username: " + signUpButton.IsEnabled());

            // The user enters their password, the button is still disabled
            passwordTextBox.SetContent("password");
            Console.WriteLine("After setting the password: " + signUpButton.IsEnabled());

            // The agrees to the terms, the button becomes enabled
            agreeToTermsCheckBox.SetChecked(true);
            Console.WriteLine("After agreeing to terms: " + signUpButton.IsEnabled());

            // The user removes the password, the button becomes disabled
            passwordTextBox.SetContent("");
            Console.WriteLine("After removing the password: " + signUpButton.IsEnabled());

            // The user enters the password again, the button becomes enabled
            passwordTextBox.SetContent("password");
            Console.WriteLine("After re-setting the password: " + signUpButton.IsEnabled());
        }
    }
}

