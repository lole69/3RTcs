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
using System.Drawing;
using System.ComponentModel;
using System.Data;


namespace zadatki_za_test_s_operacijskih
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        int brojac = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random rand = new Random();
            int broj = rand.Next(0,10);
            int broj2 = rand.Next(0, 10);
            int zbroj=0;
            textbox.Text = broj.ToString();
            textbox2.Text = broj2.ToString();
            if ((bool)minus.IsChecked)
            {
                labela1.Content = "-";
                zbroj = broj - broj2;

            }
            if ((bool)plus.IsChecked)
            {
                labela1.Content = "+";
                zbroj = broj + broj2;

            }
            if(brojac==0)
            {
                labela1.Content = "+";
                zbroj = broj + broj2;
            }
            
           

            textbox3.Text = zbroj.ToString();
            labela2.Content = "=";
            listbox1.Items.Add(broj.ToString()+labela1.Content+broj2.ToString()+labela2.Content+zbroj.ToString());
            brojac++;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            labela1.Content = "-";
            int prvi = Int32.Parse(textbox.Text);
            int drugi = Int32.Parse(textbox2.Text);
            int zbroj2 = prvi - drugi;
            textbox3.Text = zbroj2.ToString();
            listbox1.Items.Add(prvi.ToString() + labela1.Content + drugi.ToString() + labela2.Content + zbroj2.ToString());


        }

        private void plus_Checked(object sender, RoutedEventArgs e)
        {
            labela1.Content = "+";
            int prvi = Int32.Parse(textbox.Text);
            int drugi = Int32.Parse(textbox2.Text);
            int zbroj2 = prvi + drugi;
            textbox3.Text = zbroj2.ToString();
        }

        private void brisanje(object sender, MouseButtonEventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void zuto(object sender, MouseEventArgs e)
        {
            Brush br = Brushes.Yellow;
            listbox1.Background = br;

        }

        private void zeleno(object sender, MouseEventArgs e)
        {
            Brush br = Brushes.Green;
            listbox1.Background = br;
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if(listbox1.SelectedItem!=null)
                textbox4.Text = listbox1.SelectedItem.ToString();
            }
            catch
            {

            }

        }
    }
}
