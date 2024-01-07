using gestion_de_stocks.Controllers;
using gestion_de_stocks.Models;
using gestion_de_stocks.Models.Data;
using gestion_de_stocks.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Text.Json.Serialization.Metadata;
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
    /// Logique d'interaction pour ArticlesPage.xaml
    /// </summary>
    public partial class ArticlesPage : Window
    {
        private ArticlesController _controller;
        private CategoriesController _categoriesController;
        private stockContext _stockContext;
        // ici on défini l'id sélectionné en tant que membre privé, afin de tout le temps l'avoir à disposition  
        private int _articleId;

        public ArticlesPage()
        {
            InitializeComponent();
            // init du context et des controllers
            _stockContext = new stockContext();
            _controller = new ArticlesController(_stockContext);
            _categoriesController = new CategoriesController(_stockContext);
            // on remplit les dtg et les combobox
            dtg_articles.ItemsSource = _controller.GetAllArticles();
            cmb_articles.ItemsSource = _controller.GetAllArticles();
            cmb_category.ItemsSource = _categoriesController.GetAllCategories();
            _articleId = 0;
        }

        /**
         * gestion du changement de focus du dataGrid 
         */
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Cast du sender en datagrid
            DataGrid datagrid = (DataGrid)sender;

            if (datagrid.SelectedItem != null)
            {
                int selectedArticleId = ((ArticleDtoOut)datagrid.SelectedItem).IdArticles;
                string selectingName = ((ArticleDtoOut)datagrid.SelectedItem).LibelleArticle;
                string selectedCategory = ((ArticleDtoOut)datagrid.SelectedItem).LaCategorie;

                // OfType filtre les éléments d'une séquence en fonction d'un type spécifique. , Cast effectue uen conversion de type explicite sur tous les élements d'une séquence. 
                // firstOrDefautl renvoie le premier élement correspondant 
                cmb_articles.SelectedItem = cmb_articles.Items.OfType<ArticleDtoOut>().FirstOrDefault(item => item.LibelleArticle == selectingName);
                cmb_category.SelectedItem = cmb_category.Items.OfType<CategoryDtoOut>().FirstOrDefault(item => item.LibelleCategorie == selectedCategory);

                // mise à jour de l'id sélectionné 
                this._articleId = selectedArticleId;
            }

        }

        /**
         * Gestion des events sur le combobox des articles 
         */
        private void cmb_articles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
    
            ArticleDtoOut selectedArticle = (ArticleDtoOut)cmb_articles.SelectedItem;

            if(selectedArticle != null)
            {
                int quantity = (int)selectedArticle.QuantiteStockee;
                string category = selectedArticle.LaCategorie;

                this._articleId = (int)selectedArticle.IdArticles;
                tbx_quantity.Text = quantity.ToString();
                tbx_category.Text = category.ToString();


            }

        }

        /**
         * 
         * Gestion du bouton d'update 
         */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string categoryName;

            // update en base de données de l'article correspondant 
            ArticleDtoOut current_article = (ArticleDtoOut)cmb_articles.SelectedItem;
            if (current_article != null)
            {
                ArticleDtoIn inArticle = new ArticleDtoIn();

                inArticle.QuantiteStockee = int.Parse(tbx_quantity.Text.ToString());
                CategoryDtoOut current_category = (CategoryDtoOut)cmb_category.SelectedItem;
                inArticle.IdCategories = current_category.IdCategories;
                inArticle.LibelleArticle = current_article.LibelleArticle;


                _controller.UpdateArticle(this._articleId, inArticle);

                this.UpdateDataGrid();
                this.UpdateComboBox();
            }
        }

        // méthode de mise à jour de la dataGrid
        private void UpdateDataGrid()
        {
            dtg_articles.ItemsSource = _controller.GetAllArticles();
        }

        // méthode de mise à jour de la comboBox 
        private void UpdateComboBox()
        {
            cmb_articles.ItemsSource = _controller.GetAllArticles();
        }

        // permet d'effectuer des actionsd lorsque la page est chargée 
        private void Article_Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid();
            UpdateComboBox();
        }

        // permet d'effectuer des actions lorsque la fenêtre est activée 
        private void Window_Activated(object sender, EventArgs e)
        {
            UpdateDataGrid();
            UpdateComboBox();
        }
    

        private void Delete_article(object sender, RoutedEventArgs e)
        {
            // récupérer la sélection 
            ArticleDtoOut selectedArticle = (ArticleDtoOut)dtg_articles.SelectedItem;

            if (selectedArticle != null)
            {
                _controller.DeleteArticle(selectedArticle.IdArticles);
                this.UpdateDataGrid();
                this.UpdateComboBox();
            }
        }

        private void Add_article(object sender, RoutedEventArgs e)
        {
            ArticleAddPage articleAddPage = new ArticleAddPage();
            this.Opacity = 0.7;
            articleAddPage.ShowDialog();
            this.Opacity = 1;
            

        }
    }
}
