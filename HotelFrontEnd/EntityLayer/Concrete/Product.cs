using System;
namespace BaseIdentity.EntityLayer.Concrete
{
	public class Product
	{
		public Product()
		{
		}

		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public int ProductStock { get; set; }
		public decimal ProductPrice { get; set; }
		public string ProductImage { get; set; }
		public int CategoryID { get; set; }
		public Category Category { get; set; }
	}
}

