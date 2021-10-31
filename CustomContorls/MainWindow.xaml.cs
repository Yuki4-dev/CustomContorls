using System.Windows;
using System.Windows.Controls;

namespace CustomContorls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Page _CustomScrolbarPage = new CustomScrolbarPage();
        private readonly Page _CustomComboBoxPage = new CustomComboBoxPage();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScrolBar_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = _CustomScrolbarPage;
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = _CustomComboBoxPage;
        }
    }
}
