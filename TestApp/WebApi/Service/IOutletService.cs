using WebApi.Models;

namespace WebApi.Service
{
    public interface IOutletService
    {
        ResponseModel Get(string city, int page);
    }
}
