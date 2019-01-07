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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            ReadDB();
        }

        private void NewContact_Btn(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog();

            ReadDB();
        }

        void ReadDB()
        {
           
            using(SQLite.SQLiteConnection con = new SQLite.SQLiteConnection(App.dbPath))
            {
                con.CreateTable<Contact>();
                contacts = (con.Table<Contact>().ToList()).OrderBy(c => c.Name).ToList();
            }
            if(contacts != null)
            {
                contactsListView.ItemsSource = contacts;
             }
            }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchBox = sender as TextBox;
            var filteredContacts = contacts.Where(c => c.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();

            var filteredContacts2 = (from c2 in contacts
                                    where c2.Name.ToLower().Contains(searchBox.Text.ToLower())
                                    orderby c2.Email
                                    select c2).ToList();
            contactsListView.ItemsSource = filteredContacts;
        }

        private void contactsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact = (Contact)contactsListView.SelectedItem;

            if(selectedContact != null)
            {
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();
            }
            ReadDB();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Contact selectedContact = (Contact)contactsListView.SelectedItem;

            if (selectedContact != null)
            {
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();
            }
            ReadDB();
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            Contact selectedContact = (Contact)contactsListView.SelectedItem;

            if (selectedContact != null)
            {
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();
            }
            ReadDB();
        }
    }
    }
