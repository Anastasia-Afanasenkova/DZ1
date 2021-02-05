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

namespace DZ1
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Class1> class1s = new List<Class1>();
            Class1 c1 = new Class1();
            c1.N = "aa";
            c1.M = "aaa";
            c1.Index = 1;
            class1s.Add(c1);
            Class1 c2 = new Class1();
            c2.N = "bb";
            c2.M = "bbb";
            c2.Index = 2;
            class1s.Add(c2);
            Class1 c3 = new Class1();
            c3.N = "cc";
            c3.M = "ccc";
            c3.Index = 3;
            class1s.Add(c3);

            lvList.ItemsSource =class1s;
        }
      
    }
}
