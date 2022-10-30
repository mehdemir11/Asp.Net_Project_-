using Data_Access_Layer.Abstract;
using Data_Access_Layer.Repository;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EntityFramework
{
    public class EFServiceDAL:GenericRepository<Service>,IServiceDAL
    {
    }
}
