using RouteCards.Data;
using RouteCards.Infrastructure;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AuthorizationForm : Form
    {
        UserRepo repo = new UserRepo();

        IEnumerable<User> items;

        public AuthorizationForm()
        {
            InitializeComponent();

            Text += " v" + VersionService.Get();

            GetItems();

            // Выделяем последнего пользователя
            var settingsService = new SettingsService();
            var settings = settingsService.Load();

            var item = items.Where(x => x.Id == settings.LastUserId).FirstOrDefault();
            if (item != null)
            {
                var idx = itemsListBox.Items.IndexOf(item);
                itemsListBox.SelectedIndex = idx;
            }
        }

        void GetItems()
        {
            items = repo.GetAll();
            itemsListBox.DataSource = items;
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        void Filter()
        {
            itemsListBox.DataSource = items.Where(x => x.Name.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var item = itemsListBox.SelectedItem as User;
            if (item == null) return;

            string password = passwordTextBox.Text;
            bool isCorrectPsd = repo.CheckPassword(item.Id, password);

            if (!isCorrectPsd)
            {
                MessageBox.Show("Неправильный пароль", "Внимание");
                passwordTextBox.Clear();
                return;
            }

            AuthorizationService.User = item;

            var settingsService = new SettingsService();
            var settings = settingsService.Load();
            settings.LastUserId = item.Id;
            settingsService.Save(settings);

            this.Visible = false;
            new Form1().ShowDialog();
            //this.Visible = true;
            //passwordTextBox.Clear();
            this.Close();
        }

        void SwitchKeyboardLanguage()
        {
            var language = InputLanguage.InstalledInputLanguages.OfType<InputLanguage>().Where(x => x.Culture.Name.StartsWith("en")).FirstOrDefault();
            if (language != null)
            {
                InputLanguage.CurrentInputLanguage = language;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e) => SwitchKeyboardLanguage();

        private void AuthorizationForm_Activated(object sender, EventArgs e)
        {
            passwordTextBox.Select();
            SwitchKeyboardLanguage();
        }
    }
}
