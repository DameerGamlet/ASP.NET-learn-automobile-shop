using ACP_learn.Models;

namespace ACP_learn.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> allCaterories {get;}
    }
}