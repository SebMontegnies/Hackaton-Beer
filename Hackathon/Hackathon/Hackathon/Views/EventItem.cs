﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hackathon.Views
{
    public class EventItem : ViewCell
    {
        public EventItem()
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Start
            };
            image.SetBinding(Image.SourceProperty, new Binding("ImageUri"));
            image.WidthRequest = image.HeightRequest = 40;

            var nameLayout = CreateNameLayout();

            var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { image, nameLayout }
            };

            View = viewLayout;
        }

        static StackLayout CreateNameLayout()
        {
            var nameLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            nameLabel.SetBinding(Label.TextProperty, "DisplayName");

            var twitterLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand//,
                //Font = Fonts.Twitter
            };

            twitterLabel.SetBinding(Label.TextProperty, "Twitter");

            var nameLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { nameLabel, twitterLabel }
            };

            return nameLayout;
        }
    }
}
