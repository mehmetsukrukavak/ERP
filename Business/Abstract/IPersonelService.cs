using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
namespace Business.Abstract
{
    public  interface IPersonelService
    {
       IResult IzinHakkiSorgula(long personelId, int istenenIzinGun);

        IDataResult<Personel> PersonelGetir(long personelId);

        IResult PersonelUpdate(Personel personel);
    }
}
