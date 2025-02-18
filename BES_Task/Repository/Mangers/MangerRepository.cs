using BES_Task.Data.Context;
using BES_Task.Data.Models;
using BES_Task.Repository.GenericRepository;
using System;

namespace BES_Task.Repository.Mangers
{
    public class MangerRepository : Repository<Manager>,IManagerRepository
    {
        public MangerRepository(ApplicationDBContext context) : base(context) { }

    }
}
