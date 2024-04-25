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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для RabotaSabonentamy.xaml
    /// </summary>
    public partial class RabotaSabonentamy : Window
    {
        public RabotaSabonentamy()
        {
            InitializeComponent();
        }

        private void support_btn_Click(object sender, RoutedEventArgs e)
        {
            header_l.Text = "Поддержка пользователей";
            support_dp.Visibility = Visibility.Visible;
            abonent_dp.Visibility = Visibility.Collapsed;
        }

        private void abonents_btn_Click(object sender, RoutedEventArgs e)
        {
            header_l.Text = "Абоненты";
            support_dp.Visibility = Visibility.Collapsed;
            abonent_dp.Visibility = Visibility.Visible;
        }
    }
}
