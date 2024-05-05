using MoneyBook.Model;

namespace MoneyBook.UI.Data
{
    public class InstitutionDataService : IInstitutionDataService
    {
        public IEnumerable<Institution> GetAll()
        {
            yield return new Institution() { Name = "Bank", Description = string.Empty };
            yield return new Institution() { Name = "Credit Union", Description = string.Empty };
        }
    }
}
