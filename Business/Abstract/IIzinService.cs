using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
namespace Business.Abstract
{
    public interface IIzinService
    {
        IResult IzinGiris(Izin izin);
    }
}
