using System.ComponentModel;
using Xamarin.Forms;
using RoutineReminder.ViewModels;

namespace RoutineReminder.Views
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