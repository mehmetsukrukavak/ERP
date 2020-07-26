using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
namespace DataAccess.Concrete
{
    public class IzinDal : EntityRepositoryBase<Izin, ErpContext>, IIzinDal
    {
       
    }
}
