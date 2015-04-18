using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hackathon
{
    public class Login : ContentPage
    {
        public Login() {

        //    Padding = new Thickness(20);

        //var red = new Label
        //{
        //    Text = "Stop",
        //    BackgroundColor = Color.Red,
        //    Font = Font.SystemFontOfSize (20)
        //};
        //var yellow = new Label
        //{
        //    Text = "Slow down",
        //    BackgroundColor = Color.Yellow,
        //    Font = Font.SystemFontOfSize (20)
        //};
        //var green = new Label
        //{
        //    Text = "Go",
        //    BackgroundColor = Color.Green,
        //    Font = Font.SystemFontOfSize (20)
        //};

        //var button = new Button
        //{
        //    Text = "Je suis un bouton"
        //};
            
        //    button.Clicked += onButtonClicked;

        //    /*Content = new StackLayout
        //    {
        //        Spacing = 10,
        //        Children = { red, yellow, green, button }
        //    };*/

        //    var absLayout = new AbsoluteLayout();

        //    absLayout.Children.Add(red, new Point(20, 20));
        //    absLayout.Children.Add(yellow, new Point(60, 80));
        //    absLayout.Children.Add(button, new Point(100, 100));

        //    Content = absLayout;

            var listView = new ListView()
            {
                RowHeight = 40
            };
            listView.ItemsSource = new string[]
            {
                "Ca",
                "Ceci",
                "Caci",
                "Et ça"
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };

        }


        private void onButtonClicked(Object sender, EventArgs args)
        {
            ((Button)sender).Text = "Click!";
            DisplayAlert("Hello", "J'ai été cliqué", "OK");
        }
    }
}
