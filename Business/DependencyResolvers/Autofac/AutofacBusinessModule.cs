using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Abstract;
namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IzinManager>().As<IIzinService>();
            builder.RegisterType<IzinDal>().As<IIzinDal>();


            builder.RegisterType<PersonelManager>().As<IPersonelService>();
            builder.RegisterType<PersonelDal>().As<IPersonelDal>();
        }
    }
}
