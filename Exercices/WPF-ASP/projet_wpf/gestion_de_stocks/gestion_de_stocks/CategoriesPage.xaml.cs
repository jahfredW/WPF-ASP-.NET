using gestion_de_stocks.Controllers;
using gestion_de_stocks.Models;
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

namespace gestion_de_stocks
{
    /// <summary>
    /// Logique d'interaction pour CategoriesPage.xaml
    /// </summary>
    public partial class CategoriesPage : Window
    {
        private CategoriesController _controller;
        private stockContext _stockContext;
        public CategoriesPage()
        {
            InitializeComponent();
            _stockContext = new stockContext();
            _controller = new CategoriesController(_stockContext);
            dtg_categories.ItemsSource = _controller.GetAllCategories();
        }
    }
}
