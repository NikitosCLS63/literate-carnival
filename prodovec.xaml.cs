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
using System.IO;


namespace PRR5AVTOsalon
{
    /// <summary>
    /// Логика взаимодействия для prodovec.xaml
    /// </summary>
    public partial class prodovec : Window
    {
        private AvtosalonVipDataBaseEntities dd = new AvtosalonVipDataBaseEntities();
        public prodovec()
        {
            InitializeComponent();
            prodovecDgr.ItemsSource = dd.ServiseRecords.ToList();

        }

        private void prodovecDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var danneyeMarki = prodovecDgr.SelectedItem as ServiseRecords;
            markabox.Text = danneyeMarki.Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki;

            var danneyeModeli = prodovecDgr.SelectedItem as ServiseRecords;
            modelbox.Text = danneyeModeli.Avtomobili.ModeliAvtomobila.NazvaniyeModeli;

            var danneyeAvtomobili = prodovecDgr.SelectedItem as ServiseRecords;
            pricebox.Text = danneyeAvtomobili.Avtomobili.Price.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //private void Chek_Click(object sender, RoutedEventArgs e)
        //{
        //    int fullAmount = Convert.ToInt32(pricebox.Text); // Получаем сумму к оплате, введенную пользователем
        //    int vneseno = Convert.ToInt32(dali.Text); // Сумма, внесенная пользователем

        //    int sdacha = fullAmount - vneseno; // Расчет сдачи

        //    string checkContent = $"Название программы\nКассовый чек №123\n\n" +
        //                          $"{markabox.Text} - {modelbox.Text} - {pricebox.Text}\n\n" +
        //                          $"Итого к оплате: {fullAmount}\n" +
        //                          $"Внесено: {vneseno}\n" +
        //                          $"Сдача: {sdacha}";



        //   sdachabox.Text = $"Сдача: {sdacha}";
        //}

    }
}
