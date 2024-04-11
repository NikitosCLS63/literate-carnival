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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SatrudnikiTableAdapter adapter = new SatrudnikiTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Voyti_Click(object sender, RoutedEventArgs e)
        {
            var allogin = adapter.GetData();
            bool loginFound = false;
            for (int i = 0; i < allogin.Count; i++)
            {
                if (allogin[i][6].ToString() == LoginTbx.Text && allogin[i][4].ToString() == Passwordtbx.Password)
                {
                    int roleId = (int)allogin[i][5];
                    loginFound = true;
                    switch (roleId)
                    {
                        case 1: 
                            admin role = new admin();
                            role.ShowDialog();
                            
                            break;
                        case 2:
                            prodovec prrole = new prodovec();
                            prrole.ShowDialog();
                            
                            break;
                        case 3:
                            perekup kuprole = new perekup();
                            kuprole.ShowDialog();
                            
                            break;

                    }
              
                }
            }
            if (!loginFound)
            {

                MessageBox.Show("Неверный логин или пароль. Введите пожалуйста снова!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            
        }
    }
}
