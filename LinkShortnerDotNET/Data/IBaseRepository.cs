using LinkShortnerDotNET.Models;
using System.Threading.Tasks;

namespace LinkShortnerDotNET.Data
{
    public interface IBaseRepository
    {
        Task<LinkSet> LookUp(string id);
        Task StoreId(LinkSet Set);

    }
}
