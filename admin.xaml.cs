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
using PRR5AVTOsalon.DataSet1TableAdapters;


namespace PRR5AVTOsalon
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        private AvtosalonVipDataBaseEntities db = new AvtosalonVipDataBaseEntities();
        public admin()
        {
            InitializeComponent();
            adminDGR.ItemsSource = db.Satrudniki.ToList();
            Filter.ItemsSource = db.Rolu.ToList();
        }

        private void FdminDGR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (adminDGR.SelectedItem != null) {

                var danneye = adminDGR.SelectedItem as Satrudniki;

            
            
            
            }
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filter.SelectedItem != null)
            {
                var dinney = Filter.SelectedItem as Rolu;
                adminDGR.ItemsSource = db.Satrudniki.ToList().Where(item => item.Rolu.NazvanieRolu == dinney.NazvanieRolu);
                
            }

        }

        private void Dob_Click(object sender, RoutedEventArgs e)
        {
            bool isNumeric = Parolbx.Text.All(char.IsDigit);

            if (!isNumeric)
            {
                MessageBox.Show("Пароль должен содержать только цифры. Пожалуйста, введите правильный пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Parolbx.Text = ""; // Очистить поле ввода пароля
                return;
            }

            if (string.IsNullOrEmpty(Namebx.Text) || string.IsNullOrEmpty(Surnamebx.Text) || string.IsNullOrEmpty(Middlenamebx.Text) || string.IsNullOrEmpty(Parolbx.Text) || string.IsNullOrEmpty(Rolubx.Text) || string.IsNullOrEmpty(LoginSatbx.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var ca = new PRR5AVTOsalon.Satrudniki();

            ca.Nickname = Namebx.Text;
            ca.Surname = Surnamebx.Text;
            ca.Middlename = Middlenamebx.Text;
            ca.Parol = Parolbx.Text;
            ca.IDroli = Convert.ToInt32(Rolubx.Text); 
            ca.LoginSat = LoginSatbx.Text;

            db.Satrudniki.Add(ca);
            db.SaveChanges();
            adminDGR.ItemsSource = db.Satrudniki.ToList();
        }
    }
}
