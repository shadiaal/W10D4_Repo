using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace ProductApi.Tests
{
	public class ProductApiTests
	{
		// Fake product data
		private static readonly Product[] Products = new Product[]
		{
			new Product { Id = 1, Name = "Product 1", Price = 10.99 },
			new Product { Id = 2, Name = "Product 2", Price = 20.99 }
		};

		//Test to return all products
		[Fact]
		public void GetAllProducts_ReturnsAllProducts()
		{
			//Simulation of the product return process
			var allProducts = Products;

			//Make sure the number is correct
			Assert.Equal(2, allProducts.Length); // Make sure there are two products

			//Ensure product names are present
			Assert.Contains(allProducts, p => p.Name == "Product 1");
			Assert.Contains(allProducts, p => p.Name == "Product 2");
		}

		//Test to retrieve a product by ID
		[Fact]
		public void GetProductById_ReturnsCorrectProduct()
		{
			//Specify the expected identifier
			var expectedProductId = 1;

			// Simulation of the product search process
			var product = FindProductById(expectedProductId);

			// Ensure that the returned product is the same as the expected product.
			Assert.NotNull(product);
			Assert.Equal(expectedProductId, product.Id);
			Assert.Equal("Product 1", product.Name);
		}

		//Test to add a new product
		[Fact]
		public void AddProduct_ReturnsNewProduct()
		{
			//Create a new product
			var newProduct = new Product { Id = 3, Name = "New Product", Price = 19.99 };

			// Simulate adding the product to the list
			var addedProduct = AddProduct(newProduct);

			//Ensure the product has been added successfully.
			Assert.NotNull(addedProduct);
			Assert.Equal(newProduct.Name, addedProduct.Name);
			Assert.Equal(newProduct.Price, addedProduct.Price);
		}

		// Simulation of the process of searching for a product by ID
		private Product FindProductById(int id)
		{
			return Products.FirstOrDefault(p => p.Id == id);
		}

		//Simulation of adding a new product
		private Product AddProduct(Product product)
		{
			var newList = Products.ToList();
			newList.Add(product);
			return product; //New Product Return Simulation
		}
	}

	//Product Data Model
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}
}

	
	