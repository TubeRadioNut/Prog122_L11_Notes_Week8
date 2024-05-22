//Charles Milender
//5-20-2024
//Programming 122
//Lecture 11 Notes
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
            InitializeComponent();//<--Don't delete this and keep at the top of MainWindow()

            //attach obserable collection from Data class to list box(ItemSource)
            lbShowNames.ItemsSource = Data.names;
            //attach the field from our static, Data.cs, class
            lblBusinessName.Content = Data.BusinessName;
        }//end of MainWindow()

        private void btnOpenNewWindow_Click(object sender, RoutedEventArgs e)
        {
            //How to open the new window we created
            //When you create a new window, you are creating a new instanced object to call
            MyNewWindow myNewWindow = new MyNewWindow();

            //To open it, you call the .Show of the myNew
            myNewWindow.Show();
        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            //get user input from textbox
            String name = txtName.Text;
            //add user input to obserable collection in the Data class
            //Data.names.Add(name);
            //add user input to obserable collection in the Data class using method AddName
            Data.AddName(name);
        }
    }//end of class
}//end of namespace