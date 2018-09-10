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

namespace WpfAppToDos
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstTodos.Items.Add(txtInput.Text);
            txtInput.Text = "";
        }


        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text == "")
            { lstTodos.Items.Remove(lstTodos.SelectedItem); }
            else
            {
                lstTodos.Items.Remove(txtInput.Text);
                txtInput.Text = "";
            }
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtInput_GotFocus(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }
    }
}
