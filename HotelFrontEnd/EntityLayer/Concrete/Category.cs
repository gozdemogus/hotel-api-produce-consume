using System;
namespace BaseIdentity.EntityLayer.Concrete
{
	public class Category
	{
		public Category()
		{
		}
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public List<Product> Products { get; set; }
	}
}

