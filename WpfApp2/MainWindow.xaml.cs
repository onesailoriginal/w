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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            start();
            }
        void start()
        {
            AddButton.Click += ClickEvent;
        }
        void ClickEvent(Object s, EventArgs e)
        {
            Label oneLabel = new Label() { Content = texxtBox.Text, HorizontalAlignment = HorizontalAlignment.Center };
            RightPanel.Children.Add(oneLabel);

        }
    }
}
