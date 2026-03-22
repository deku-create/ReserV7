using Spacium.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;
using System.Windows.Controls;

namespace Spacium.Views.Pages
{
    public partial class BookRoomPage : Page, INavigableView<BookRoomViewModel>
    {
        public BookRoomViewModel ViewModel { get; }

        public BookRoomPage(BookRoomViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}

