using MM.CAAM.Movil.ViewModels;
using Xamarin.Forms;

namespace MM.CAAM.Movil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<MainPageViewModel>(this, "AddSurvey", async (a) => 
            {
                await Navigation.PushModalAsync(new SurveyDetailsView());
            });
        }
    }
}
