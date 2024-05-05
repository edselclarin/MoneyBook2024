using MoneyBook.Model;

namespace MoneyBook.UI.Data
{
    public interface IInstitutionDataService
    {
        IEnumerable<Institution> GetAll();
    }
}