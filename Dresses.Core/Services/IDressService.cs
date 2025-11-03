using Dresses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresses.Core.Services
{
    public interface IDressService
    {
        public List<Dress> GetDresses();
    }
}
