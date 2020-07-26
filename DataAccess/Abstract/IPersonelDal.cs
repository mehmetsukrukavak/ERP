using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;
using Core.DataAccess;
namespace DataAccess.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personel>
    {
        bool IzinHakkiSorgula(long personelId, int istenenIzinGun);
    }
}
