using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryTests
    {
        [Fact]
        public void CreateCategory_WithValidName_ShouldCreate()
        {
            var category = new Category("Valid Category");
            Assert.Equal("Valid Category", category.Name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("ab")] // assuming minimum length is 3
        public void CreateCategory_WithInvalidName_ShouldThrowDomainExceptionValidation(string name)
        {
            Assert.Throws<DomainExceptionValidation>(() => new Category(name));
        }

        [Fact]
        public void UpdateCategory_WithValidName_ShouldUpdate()
        {
            var category = new Category("Initial");
            category.Update("Updated");
            Assert.Equal("Updated", category.Name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("ab")] // assuming minimum length is 3
        public void UpdateCategory_WithInvalidName_ShouldThrowDomainExceptionValidation(string name)
        {
            var category = new Category("Initial");
            Assert.Throws<DomainExceptionValidation>(() => category.Update(name));
        }

        [Fact]
        public void CreateCategory_WithValidIdAndName_ShouldCreateAndAssignId()
        {
            // Arrange & Act
            var category = new Category(10, "Valid Category");
            
            // Assert
            Assert.Equal(10, category.Id);
            Assert.Equal("Valid Category", category.Name);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void CreateCategory_WithInvalidId_ShouldThrowDomainExceptionValidation(int invalidId)
        {
            // Arrange & Act & Assert
            // O construtor com ID deve validar o ID antes do nome
            Assert.Throws<DomainExceptionValidation>(() => new Category(invalidId, "Valid Name"));
        }

    }
}