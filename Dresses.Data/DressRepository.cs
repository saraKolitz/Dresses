using Dresses.Core.Entities;
using Dresses.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresses.Data
{
    public class DressRepository : IDressRepository
    {
        private readonly DataContext _context;
        public DressRepository(DataContext context) 
        { 
            _context = context;
        }

        public List<Dress> GetAll()
        {
            return _context.Dresses.ToList();
        }
    }
}
