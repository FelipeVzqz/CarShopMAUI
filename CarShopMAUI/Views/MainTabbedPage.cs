
namespace CarShopMAUI.Views
{
    internal class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            Children.Add(item:new CarsForSale());
            Children.Add(item:new FavoriteCars());
            Children.Add(item:new AddCar());
        }
    }
}
