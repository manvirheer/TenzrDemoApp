using TenzrDemoApp.Models;
using TenzrDemoApp.PageModels;

namespace TenzrDemoApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}