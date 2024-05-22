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

namespace Prog122_L11_Notes_Week8
{
    /// <summary>
    /// Interaction logic for MyNewWindow.xaml
    /// </summary>
    public partial class MyNewWindow : Window
    {
        public MyNewWindow()
        {
            InitializeComponent();//<--Don't delete this and keep at the top of MyNewWindow()
            //attach field name from Data class to the label
            lblBusinessName.Content = Data.BusinessName;
            //attach obserable collection from Data class to list box (ItemSource)
            lbShowNames.ItemsSource = Data.names;
        }//end of MyNewWindow()
    }//end of class
}//end of namespace
