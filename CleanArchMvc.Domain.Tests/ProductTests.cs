using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductTest
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ShouldCreateProduct()
        {
            // Arrange & Act
            var product = new Product(1, "Notebook", "Notebook Gamer", 2500.50m, 10, "notebook.png");

            // Assert
            Assert.NotNull(product);
            Assert.Equal(1, product.Id);
            Assert.Equal("Notebook", product.Name);
            Assert.Equal("Notebook Gamer", product.Description);
            Assert.Equal(2500.50m, product.Price);
            Assert.Equal(10, product.Stock);
            Assert.Equal("notebook.png", product.ImageUrl);
        }

        [Fact]
        public void CreateProduct_WithoutId_WithValidParameters_ShouldCreateProduct()
        {
            // Arrange & Act
            var product = new Product("Notebook", "Notebook Gamer", 2500.50m, 10, "notebook.png");

            // Assert
            Assert.NotNull(product);
            Assert.Equal("Notebook", product.Name);
            Assert.Equal("Notebook Gamer", product.Description);
            Assert.Equal(2500.50m, product.Price);
            Assert.Equal(10, product.Stock);
            Assert.Equal("notebook.png", product.ImageUrl);
        }

        [Fact]
        public void CreateProduct_NegativeId_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product(-1, "Notebook", "Notebook Gamer", 2500.50m, 10, "notebook.png"));
        }

        [Fact]
        public void CreateProduct_NullOrEmptyName_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("", "Valid Description", 10m, 1, "img.png"));

            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("", "Valid Description", 10m, 1, "img.png"));
        }

        [Fact]
        public void CreateProduct_NameTooShort_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("No", "Valid Description", 10m, 1, "img.png"));
        }

        [Fact]
        public void CreateProduct_NullOrEmptyDescription_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("Product", "", 10m, 1, "img.png"));

            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("Product", null!, 10m, 1, "img.png"));
        }
        
        [Fact]
        public void CreateProduct_DescriptionTooShort_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("Product", "Shrt", 10m, 1, "img.png"));
        }

        [Fact]
        public void CreateProduct_NegativePrice_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("Product", "Valid Description", -1m, 1, "img.png"));
        }

        [Fact]
        public void CreateProduct_NegativeStock_ShouldThrowException()
        {
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("Product", "Valid Description", 10m, -5, "img.png"));
        }

        [Fact]
        public void CreateProduct_ImageNameTooLong_ShouldThrowException()
        {
            var longImageName = new string('a', 251);
            Assert.Throws<DomainExceptionValidation>(() =>
                new Product("Product", "Valid Description", 10m, 1, longImageName));
        }
    }
}