using gestion_de_stocks.Controllers;
using gestion_de_stocks.Models;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models.Dtos;
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
    /// Logique d'interaction pour ArticleAddPage.xaml
    /// </summary>
    public partial class ArticleAddPage : Window
    {
        private ArticlesController _controller;
        private CategoriesController _categoriesController;
        private stockContext _stockContext;
       
        // ici on défini l'id sélectionné en tant que membre privé, afin de tout le temps l'avoir à disposition  
        private int _articleId;

        public ArticleAddPage()
        {
            InitializeComponent();
            // init du context et des controllers
            _stockContext = new stockContext();
            _controller = new ArticlesController(_stockContext);
            _categoriesController = new CategoriesController(_stockContext);
            

            // récupération de toutes les catégories 
            cmb_categorie.ItemsSource = _categoriesController.GetAllCategories();


        }

        private void cmb_articles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void Add_Article(object sender, RoutedEventArgs e)
        {
            // Création d'un articla DtoIn 
            ArticleDtoIn articleDtoIn = new ArticleDtoIn();
            articleDtoIn.LibelleArticle = article_Name.Text;
            articleDtoIn.QuantiteStockee = Int32.Parse(article_Quantity.Text);

            // récupération de la catégorie sélectionnée 
            CategoryDtoOut selectedCategory = (CategoryDtoOut)cmb_categorie.SelectedItem;

            articleDtoIn.IdCategories = selectedCategory.IdCategories;

            // sauvegarde en base de données
            _controller.CreateArticle(articleDtoIn);


            
        }
    }
}
