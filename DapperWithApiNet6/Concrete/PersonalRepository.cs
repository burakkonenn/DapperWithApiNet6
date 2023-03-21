using Dapper;
using DapperWithApiNet6.Context;
using DapperWithApiNet6.Entities;
using DapperWithApiNet6.Services;

namespace DapperWithApiNet6.Concrete
{
    public class PersonalRepository: IPersonalRepository
    {
        private readonly DapperContext _context;
        public PersonalRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Personal>> GetPersonals()
        {
            var query = "SELECT * FROM Personal";

            using (var connection = _context.CreateConnection())
            {
                var personals = await connection.QueryAsync<Personal>(query);

                return personals.ToList();

            }
        }
    }
}
