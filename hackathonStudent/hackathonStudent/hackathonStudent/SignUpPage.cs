using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hackathon2015
{
    class SignUpPage : ContentPage
    {
        StackLayout loggerLayout = new StackLayout();
        Button buttonSignUp, buttonSignIn;
        Label labelEmail, labelPassword;
        // champ email/mdp

        public SignUpPage()
        {
            labelEmail = new Label
            {
                Text = "E-mail"
            };
            labelPassword = new Label
            {
                Text = "Mot de passe"
            };

            // Create the Button and attach Clicked handler.
            buttonSignUp = new Button
            {
                Text = "S'inscrire"
            };
            buttonSignUp.Clicked += OnButtonClicked;
            this.Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

            buttonSignIn = new Button
            {
                Text = "Se connecter"
            };
            buttonSignIn.Clicked += OnButtonClicked;
            this.Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);



            // Assemble the page.
            this.Content = new StackLayout
            {
                Children =
                 {
                    labelEmail,labelPassword,buttonSignIn,buttonSignUp,
                    new ScrollView
                    {
                         VerticalOptions = LayoutOptions.FillAndExpand,
                         Content = loggerLayout
                    }
                }

            };
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            if (button == buttonSignIn)
            {
                // Add Label to scrollable StackLayout.
                loggerLayout.Children.Add(new Label
                {
                    Text = "S'inscrire " + DateTime.Now.ToString("T")
                });
            }
            else if (button == buttonSignUp)
            {
                loggerLayout.Children.Add(new Label
                {
                    Text = "Se connecter " + DateTime.Now.ToString("T")
                });
            }
        }

    }
}
