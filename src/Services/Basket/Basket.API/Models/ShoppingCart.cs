namespace Basket.API.Models
{
    public class ShoppingCart
    {
        public string UserName { get; set; } = default!;
        public List<ShoppingCartItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(x => x.Price * x.Quantity);

        public ShoppingCart(string username)
        {
            UserName = username;
        }
        //for mapping
        public ShoppingCart()
        {
            
        }

    }
}
