using Spacium.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;
using System.Windows.Controls;

namespace Spacium.Views.Pages
{
    public partial class GestionnairePage : Page, INavigableView<GestionnaireViewModel>
    {
        public GestionnaireViewModel ViewModel { get; }

        public GestionnairePage(GestionnaireViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}

