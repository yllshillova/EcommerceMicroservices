namespace Basket.API.Models
{
    public class ShoppingCart
    {
        public string Username { get; set; } = default!;
        public List<ShoppingCartItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(x => x.Price * x.Quantity);

        public ShoppingCart(string username)
        {
            Username = username;
        }
        //for mapping
        public ShoppingCart()
        {
            
        }

    }
}
