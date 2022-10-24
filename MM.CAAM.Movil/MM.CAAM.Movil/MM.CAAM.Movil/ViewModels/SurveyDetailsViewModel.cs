
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


    }
}
