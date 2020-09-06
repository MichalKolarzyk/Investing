using System.Collections;

namespace DataAccess
{
    public interface ICompany
    {
        string FullName { get; set; }
        string ID { get; set; }
        Prices Prices { get; set; }
    }
}