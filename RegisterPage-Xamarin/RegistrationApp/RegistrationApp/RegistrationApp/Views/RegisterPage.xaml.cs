﻿using RegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistrationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            btnSubmit.IsEnabled = e.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            User user = new User()
            {
                FirstName = entryFristName.Text,
                LastName = entryLastName.Text,
                Password = entryPassword.Text,
                Email = entryEmail.Text,
                Age = Convert.ToInt32(entryAge.Text),
                Gender = pickerGender.SelectedItem.ToString(),
                Phone = entryPhone.Text
            };
            Navigation.PushAsync(new ProfilePage(user));
        }
    }
}