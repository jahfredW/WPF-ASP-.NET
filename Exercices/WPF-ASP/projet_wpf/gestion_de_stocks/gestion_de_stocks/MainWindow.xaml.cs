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

namespace gestion_de_stocks
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            ArticlesPage articleWindow = new ArticlesPage();
            this.Opacity = 0.7;
            articleWindow.ShowDialog();
            this.Opacity = 1;

        }

        private void Categories_Click(object sender, RoutedEventArgs e)
        {

            CategoriesPage categoryWindow = new CategoriesPage();
            this.Opacity = 0.7;
            categoryWindow.ShowDialog();
            this.Opacity = 1;

        }

        private void TypesProduits_Click(object sender, RoutedEventArgs e)
        {

            TypesproduitPage typesproduitWindow = new TypesproduitPage();
            this.Opacity = 0.7;
            typesproduitWindow.ShowDialog();
            this.Opacity = 1;

        }
    }
}
