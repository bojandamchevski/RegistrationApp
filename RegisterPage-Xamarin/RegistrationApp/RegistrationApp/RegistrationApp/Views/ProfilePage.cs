using RegistrationApp.Models;

using Xamarin.Forms;

namespace RegistrationApp.Views
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage(User user)
        {
            Title = "Profile";
            Padding = new Thickness(40);
            FormattedString formattedString = new FormattedString();
            formattedString.Spans.Add(new Span() { Text = "Welcome to ", TextColor = Color.LightBlue, FontSize = 25 });
            formattedString.Spans.Add(new Span() { Text = "Seavus Education and Development Center", TextColor = Color.Blue, FontSize = 30, TextDecorations = TextDecorations.Underline });

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hi " + user.FirstName, TextColor = Color.Black, FontSize = 20 },
                    //new Label { Text = "Welcome to your profile", TextColor = Color.Black, FontSize = 24 },
                    new Label {FormattedText = formattedString},
                    new Label { Text = "Your Information: ", TextColor = Color.LightBlue, FontSize = 25, VerticalOptions = LayoutOptions.EndAndExpand },
                    new Label { Text = $"First Name: {user.FirstName} ", TextColor = Color.Black, FontSize = 20 },
                    new Label { Text = $"Last Name: {user.LastName} ", TextColor = Color.Black, FontSize = 20 },
                    new Label { Text = $"Age: {user.Age} ", TextColor = Color.Black, FontSize = 20 },
                    new Label { Text = $"Gender: {user.Gender} ", TextColor = Color.Black, FontSize = 20 },
                    new Label { Text = $"E-mail: {user.Email} ", TextColor = Color.Black, FontSize = 20 },
                    new Label { Text = $"Phone number: {user.Phone} ", TextColor = Color.Black, FontSize = 20 },
                }
            };
        }
    }
}