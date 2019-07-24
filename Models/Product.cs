namespace myRetailApi.Models
{
	public class Product
	{
		public double Id { get; set; }
		public string Name { get; set; }
		public PriceDetail Price { get; set; }
	}
}