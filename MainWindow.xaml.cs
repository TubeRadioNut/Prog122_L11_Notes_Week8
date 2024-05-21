using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_L11_Notes_Week8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    
    
    public partial class MainWindow : Window
    {
        // obserable collection
        
        public MainWindow()
        {
            InitializeComponent();

            
            lbShowNames.ItemsSource = Data.names;
            //attach the field from our static, Data.cs, class
            lblBusinessName.Content = Data.BusinessName;
        }

        private void rtnOpenNewWindow_Click(object sender, RoutedEventArgs e)
        {
            //How to open the new window we created
            //When you create a new window, you are creating a new instanced object to call
            MyNewWindow myNewWindow = new MyNewWindow();

            //To open it, you call the .Show of the myNew
            myNewWindow.Show();
        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            String name = txtName.Text;
            Data.names.Add(name);
        }
    }
}