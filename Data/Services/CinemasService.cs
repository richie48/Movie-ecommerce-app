using Microsoft.EntityFrameworkCore;
using new_testapp.Data.Base;
using new_testapp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace new_testapp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
