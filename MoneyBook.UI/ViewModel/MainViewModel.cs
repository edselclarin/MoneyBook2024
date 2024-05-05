using MoneyBook.Model;
using MoneyBook.UI.Data;
using System.Collections.ObjectModel;

namespace MoneyBook.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IInstitutionDataService institutionDataService_;

        private Institution selectedInstitution_;
        public Institution SelectedInstitution
        {
            get => selectedInstitution_;
            set
            {
                selectedInstitution_ = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Institution> Institutions { get; set; }

        public MainViewModel(IInstitutionDataService institutionDataService)
        {
            Institutions = new ObservableCollection<Institution>();
            institutionDataService_ = institutionDataService;
        }

        public void Load()
        {
            Institutions.Clear();
            var institutions = institutionDataService_.GetAll();
            foreach (var institution in institutions)
            {
                Institutions.Add(institution);
            }
        }  
    }
}
