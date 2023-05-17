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

namespace InvManSys4RS
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
        //1. DB Created
        //2. EF Core installed
        //3. Model Classes generated

        //variables declaration
        string chosenTable = "Inventory";
        //add
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        //delete
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        //edit
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
        //display
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Crud crud = new Crud();
            txtMainBox.Text = crud.Read(table);

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            chosenTable = "Inventory";
            txtInfo.Text = chosenTable;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            chosenTable = "Suppliers";
            txtInfo.Text = chosenTable;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
