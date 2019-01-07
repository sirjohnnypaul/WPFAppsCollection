using ContactsApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for ContactDetailsWindow.xaml
    /// </summary>
    public partial class ContactDetailsWindow : Window
    {
        Contact contact;

        public ContactDetailsWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;

            //Set details fields
            nameBox.Text = contact.Name;
            surnameBox.Text = contact.Surname;
            initialsBox.Text = contact.Initials;
            emailBox.Text = contact.Email;
            phoneNumberBox.Text = contact.Phone;
            StreetBox.Text = contact.Street;
            cityBox.Text = contact.city;
            cityCodeBox.Text = contact.cityCode;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            //Update contact values
            contact.Name = nameBox.Text;
            contact.Surname = surnameBox.Text;
            contact.Initials = initialsBox.Text;
            contact.Email = emailBox.Text;
            contact.Phone = phoneNumberBox.Text;
            contact.Street = StreetBox.Text;
            contact.city = cityBox.Text;
            contact.cityCode = cityCodeBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Contact>();
                connection.Update(contact);
            }
            Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Contact>();
                connection.Delete(contact);
            }

            Close();
        }
    }
}
