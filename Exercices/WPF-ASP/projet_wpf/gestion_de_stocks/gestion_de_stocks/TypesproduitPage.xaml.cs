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
    /// Logique d'interaction pour TypesproduitPage.xaml
    /// </summary>
    public partial class TypesproduitPage : Window
    {
        private stockContext _context;
        private TypesproduitsController _controller;

        public TypesproduitPage()
        {
            this._context = new stockContext();
            this._controller = new TypesproduitsController(_context);
            InitializeComponent();
            dtg_typesproduit.ItemsSource = this._controller.GetAllTypesproduits();

        }
    }
}
