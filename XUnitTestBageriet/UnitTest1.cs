using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using System;
using Xunit;

namespace XUnitTestBageriet
{
	public class UnitTest1
	{
        [Fact]

        public void ProductViewModelNotNull()
        {
            PiesListViewModel productList = new PiesListViewModel();

            Assert.NotNull(productList);
        }

        [Fact]
        public void Home_ViewmodelNotNull()
        {
            HomeViewModel homeViewModel = new HomeViewModel();


            Assert.NotNull(homeViewModel);
        }

        [Fact]
        public void Test2()
        {
            var modeler = new Category();
            var result = new Category();

            Assert.NotEqual(modeler, result);
        }
    }
}
