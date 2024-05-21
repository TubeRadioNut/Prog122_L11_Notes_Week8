using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_L11_Notes_Week8
{
    public class Data
    {
        //Static Fields
        public static string BusinessName = "Mike's Sandwich Shop";

        public static ObservableCollection<string> names = new ObservableCollection<string>();

        //Static Constructor
        static Data()
        {
            names.Add("Rafael");
            names.Add("Charles");
            names.Add("Toivo");
            names.Add("Will");
        }

        //Static Properties

        //Static Method
        public static void AddName(string name)
        {
            names.Add(name);
        }

    }//end of class

}//end of namespace
