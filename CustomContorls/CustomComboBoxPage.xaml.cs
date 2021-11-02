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

namespace CustomContorls
{
    /// <summary>
    /// CustomComboBoxPage.xaml の相互作用ロジック
    /// </summary>
    public partial class CustomComboBoxPage : Page
    {
        public List<String> Items { get; } = new();

        public CustomComboBoxPage()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
                Items.Add($"custom{i}");


            this.DataContext = this;
        }
    }
}
