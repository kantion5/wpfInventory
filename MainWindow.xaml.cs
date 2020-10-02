using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InventorySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
      

        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Item> items = new ObservableCollection<Item>();
            items.Add(new Item(50, 23.3, "abc123"));
            items.Add(new Item(48, 55.3, "cba123"));
            items.Add(new Item(27, 22.8, "abc123"));
            this.DataContext = items;
            
        }

    }
}
