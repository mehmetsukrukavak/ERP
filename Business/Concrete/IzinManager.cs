using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class IzinManager : IIzinService
    {
        private readonly IIzinDal izinDal;
        private readonly IPersonelService personelService;

        public IzinManager(
            IIzinDal izinDal,
            IPersonelService personelService)
        {
            this.izinDal = izinDal;
            this.personelService = personelService;
        }

        public IResult IzinGiris(Izin izin)
        {
            try
            {
                if (izin.IzinBitisTarihi < izin.IzinBaslamaTarihi)
                    throw new Exception("Başlama Tarihi Bitiş Tarihinden büyük olamaz");

                //personelId li personeli kontrol et
                var personel = personelService.PersonelGetir(izin.PersonelId);
                if (!personel.Success)
                    return personel;

                //personelin istenen izin gün sayısını hesapla
                var isteneIzinGunSayisi = (izin.IzinBitisTarihi - izin.IzinBaslamaTarihi).Days;

                //personelin istenen izin gün sayısı kadar izni var mı hesapla
                var izinVarmi = personelService.IzinHakkiSorgula(izin.PersonelId, isteneIzinGunSayisi);

                if (!izinVarmi.Success)
                    return izinVarmi;

                //izni varsa 
                //personelin iznini gir
                izinDal.Add(izin);

                //personelin kalan izin gün sayısını update
                personel.Data.KalanİzinGunu -= isteneIzinGunSayisi;
                personelService.PersonelUpdate(personel.Data);

                return new SuccessResult(SuccessMessages.IzinGirildi);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }



        }
    }
}
