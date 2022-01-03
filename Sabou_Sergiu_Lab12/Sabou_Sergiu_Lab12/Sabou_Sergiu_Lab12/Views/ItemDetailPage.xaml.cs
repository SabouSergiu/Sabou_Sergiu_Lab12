using Sabou_Sergiu_Lab12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Sabou_Sergiu_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}