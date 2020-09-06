using System.Collections.Generic;

namespace DataAccess
{
    public interface ICompanies : IList<ICompany>
    {
        List<ICompany> ListOfCompanies { get; set; }
        string[] GetIds();
    }
}