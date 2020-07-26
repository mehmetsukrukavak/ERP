using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccess.Concrete
{
    public class PersonelDal : EntityRepositoryBase<Personel, ErpContext>, IPersonelDal
    {
        public bool IzinHakkiSorgula(long personelId, int istenenIzinGun)
        {
            using (var context = new ErpContext())
            {
                var izinHakki = context.Personel.Where(p => p.Id == personelId && p.KalanİzinGunu >= istenenIzinGun).FirstOrDefault();

                if (izinHakki != null)
                    return true;

                return false;

            }
        }
    }
}