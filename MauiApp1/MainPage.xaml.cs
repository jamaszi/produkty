namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        readonly System.Random _rnd = new System.Random();

        public System.Collections.ObjectModel.ObservableCollection<Product> Products { get; } =
            new System.Collections.ObjectModel.ObservableCollection<Product>
            {
                new Product { Name = "Pomidor", Category = "Warzywa", Price = 3.50m, Quantity = 10 },
                new Product { Name = "Mleko", Category = "Nabiał", Price = 4.20m, Quantity = 5 },
                new Product { Name = "Chleb", Category = "Piekarnia", Price = 2.80m, Quantity = 8 }
            };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnChangeColorClicked(object? sender, EventArgs e)
        {
            // Generate random RGB values
            int r = _rnd.Next(0, 256);
            int g = _rnd.Next(0, 256);
            int b = _rnd.Next(0, 256);

            // Apply new color to the search label
            SearchLabel.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(r, g, b);
        }
    }
}
