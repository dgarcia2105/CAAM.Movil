
using MM.CAAM.Movil.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace MM.CAAM.Movil.ViewModels
{
    public class SurveyDetailsViewModel : BaseViewModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { 
                name = value;
                OnPropertyChanged();
            }
        }

        private string favoriteFood;

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }

        public ICommand SaveCommand { get; set; }

        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(() => 
            {
                var newSurvey = new Survey() { Name = this.Name, FavoriteFood = this.FavoriteFood };
                MessagingCenter.Send(this, "SaveSurvey", newSurvey);
            });
        }

    }
}
