using DapperWithApiNet6.Context;
using DapperWithApiNet6.Entities;

namespace DapperWithApiNet6.Services
{
    public interface IPersonalRepository 
    {
      Task<IEnumerable<Personal>> GetPersonals();

    }
}
