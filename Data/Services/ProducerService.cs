using new_testapp.Data.Base;
using new_testapp.Models;

namespace new_testapp.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>,IProducersService
    {
        public ProducerService(AppDbContext context) : base(context)
        {

        }
    }
}
