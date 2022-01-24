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
using BodyMassIndex;

namespace BodyMassIndex
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnÜbernehmen_Click(object sender, RoutedEventArgs e)
        {
            string eingabe = txtGewicht.Text;
            double gewichtseingabe = Convert.ToDouble(eingabe);

            string eingabe2 = txtGroesse.Text;
            double groesseseingabe = Convert.ToDouble(eingabe2);

            double bmi = gewichtseingabe / (groesseseingabe * groesseseingabe);

            string ausgabe = $"BMI : {Math.Round(bmi,2)}";

            Ausgabe.Content = ausgabe;

            



        }
    }
}
