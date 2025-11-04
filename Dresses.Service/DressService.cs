using Dresses.Core.Entities;
using Dresses.Core.Repositories;
using Dresses.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresses.Service
{
    public class DressService : IDressService
    {
        private readonly IDressRepository _dressRepository;
        public DressService(IDressRepository dressRepository)
        {
            _dressRepository = dressRepository;
        }
        public List<Dress> GetDresses()
        {
            //פה נכתוב את הלוגיקה העיסקית של המערכת
            return _dressRepository.GetAll();
        }
    }
}
//123456