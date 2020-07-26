using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDal personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            this.personelDal = personelDal;
        }

        public IResult IzinHakkiSorgula(long personelId, int istenenIzinGun)
        {
            if (personelDal.IzinHakkiSorgula(personelId, istenenIzinGun))
                return new SuccessResult(SuccessMessages.IzinHakkiYeterli);

            return new ErrorResult(ErrorMessages.IzinHakkiYeterliDegil);
           
        }

        public IDataResult<Personel> PersonelGetir(long personelId)
        {
            var personel = personelDal.Get(p => p.Id == personelId);
            if (personel != null)
                return new SuccessDataResult<Personel>(personel,SuccessMessages.PersonelBulundu);

            return new ErrorDataResult<Personel>(null,ErrorMessages.PersonelBulunamadi);
        }

        public IResult PersonelUpdate(Personel personel)
        {
            personelDal.Update(personel);
            return new SuccessResult(SuccessMessages.PersonelUpdateEdildi);
        }
    }
}
