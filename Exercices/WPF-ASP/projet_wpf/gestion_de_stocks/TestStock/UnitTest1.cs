using gestion_de_stocks.Controllers;
using gestion_de_stocks.Models;
using gestion_de_stocks.Models.Dtos;
using gestion_de_stocks.Models.Services;
using System.Collections.ObjectModel;
using Moq;

namespace TestStock
{
    public class Tests
    {
        private ArticlesController _articlesController;
        private stockContext _stockContext;

        [SetUp]
        public void Setup()
        {
            _stockContext = new stockContext();
            _articlesController = new ArticlesController(_stockContext);
        }

        [Test]
        // test de la récupération de tous les articles 
        public void GetAllArticlesTest()
        {
            var result = _articlesController.GetAllArticles();

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<ObservableCollection<ArticleDtoOut>>(result);

        }

        [Test]
        // test de la récupération d'un article
        public void GetOneArticleTtest()
        {
            int id = 1;
            var articleItem = _articlesController.GetArticleById(id);

            Assert.IsNotNull(articleItem);
            Assert.That(articleItem.IdArticles, Is.EqualTo(id), "Id Ne correspond pas");
            
        }
    }
}