using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для perekup.xaml
    /// </summary>
    public partial class perekup : Window
    {
        private AvtosalonVipDataBaseEntities ff = new AvtosalonVipDataBaseEntities();

        public perekup()
        {
            InitializeComponent();

            perekupDGR.ItemsSource = ff.ServiseRecords.ToList();
            ViborModel.ItemsSource = ff.MarkaAvtomobila.ToList();

        }

        private void perekupDGR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {





            var danneyeMarki = perekupDGR.SelectedItem as ServiseRecords;
            VvodMarka.Text = danneyeMarki.Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki;

            var danneyeModeli = perekupDGR.SelectedItem as ServiseRecords;
            VvodModeli.Text = danneyeModeli.Avtomobili.ModeliAvtomobila.NazvaniyeModeli;

            var danneyeAvtomobili = perekupDGR.SelectedItem as ServiseRecords;
            VvodPrice.Text = danneyeAvtomobili.Avtomobili.Price.ToString();



        }
        private void ViborModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViborModel.SelectedItem != null)
            {
                var dinney = ViborModel.SelectedItem as MarkaAvtomobila;
                perekupDGR.ItemsSource = ff.Avtomobili.ToList().Where(item => item.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki == dinney.NazvaniyeMarki);
            }
        }

        private void Dobavit_Click(object sender, RoutedEventArgs e)
        {



            if (string.IsNullOrWhiteSpace(VvodMarka.Text) || string.IsNullOrWhiteSpace(VvodModeli.Text) || string.IsNullOrWhiteSpace(VvodPrice.Text))
            {
                MessageBox.Show("Значения не должны быть пустыми.");
                return;
            }

            var cs = new PRR5AVTOsalon.ServiseRecords();
            cs.Opisaniyerabot = "сюда описание работы";
            cs.idAvtomobilya = "сюда id автомобиля из комбобокса";

            if (DateTime.TryParse(VvodPrice.Text, out DateTime date))
            {
                cs.Dataobslujivaniya = date.ToString();
            }
            else
            {
                MessageBox.Show("Некорректное значение для цены.");
                return;
            }

            ff.ServiseRecords.Add(cs);
            ff.SaveChanges();

            perekupDGR.ItemsSource = ff.ServiseRecords.ToList();






            //var cs = new PRR5AVTOsalon.ServiseRecords();
            //cs.Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki = VvodMarka.Text;

            //ff.SaveChanges();

            //cs.Avtomobili.ModeliAvtomobila.NazvaniyeModeli = VvodModeli.Text;

            //ff.SaveChanges();

            //cs.Avtomobili.Price = Convert.ToDecimal(VvodPrice.Text);
            //ff.ServiseRecords.Add(cs);
            //ff.SaveChanges();

            //perekupDGR.ItemsSource = ff.ServiseRecords.ToList();
        }



        private void Izmenit_Click_1(object sender, RoutedEventArgs e)
        {
            if (perekupDGR.SelectedItem != null)
            {
                var ca = perekupDGR.SelectedItem as ServiseRecords;

                decimal newPrice;
                if (Decimal.TryParse(VvodPrice.Text, out newPrice))
                {
                    if (newPrice >= 0) // Проверяем, что новая цена не отрицательная
                    {
                        if (ca.Avtomobili.Price != newPrice)
                        {
                            ca.Avtomobili.Price = newPrice;
                            ff.SaveChanges();
                            MessageBox.Show("Цена успешно изменена.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Цена не может быть отрицательной.");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректное числовое значение для цены.");
                }

                if (ca.Avtomobili.ModeliAvtomobila.NazvaniyeModeli != VvodModeli.Text)
                {
                    ca.Avtomobili.ModeliAvtomobila.NazvaniyeModeli = VvodModeli.Text;
                    ff.SaveChanges();
                    MessageBox.Show("Модель успешно изменена.");
                }

                if (Regex.IsMatch(VvodMarka.Text, @"^[a-zA-Z]+$"))
                {
                    if (ca.Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki != VvodMarka.Text)
                    {
                        ca.Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki = VvodMarka.Text;
                        ff.SaveChanges();
                        MessageBox.Show("Марка успешно изменена.");
                    }
                }
                else
                {
                    MessageBox.Show("Марка автомобиля должна содержать только буквы.");
                }

                perekupDGR.ItemsSource = ff.ServiseRecords.ToList();
            }


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var ca = perekupDGR.SelectedItem as ServiseRecords;

            ff.ServiseRecords.Remove(ca);
            ff.SaveChanges();
            perekupDGR.ItemsSource = ff.ServiseRecords.ToList();

        }

        private void Nayti_Click(object sender, RoutedEventArgs e)
        {
            var text = Naytibb.Text;
            perekupDGR.ItemsSource = ff.ServiseRecords.ToList().Where(item => item.Avtomobili.ModeliAvtomobila.NazvaniyeModeli.Contains(text));

        }

        private void Ochidtka_Click(object sender, RoutedEventArgs e)
        {
            perekupDGR.ItemsSource = ff.ServiseRecords.ToList();

        }

        private void Clooose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}




