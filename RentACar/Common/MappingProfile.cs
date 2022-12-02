using AutoMapper;
using RentACar.Application.Admin.Commands;
using RentACar.Application.Admin.Commands.CreateAdmin;
using RentACar.Application.Admin.Queries.GetAdmins;
using RentACar.Application.Admin.Queries.GetById;
using RentACar.Application.Car.Commands.CreateCar;
using RentACar.Application.Car.Queries.GetById;
using RentACar.Application.Car.Queries.GetCars;
using RentACar.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCarModel, Car>();
            CreateMap<Car, GetByIdCarModel>();
            CreateMap<List<Car>, List<GetCarsModel>>();
            CreateMap<CreateAdminModel, Admin>();
            CreateMap<List<Admin>, List<GetAdminsModel>>();
            CreateMap<Admin, GetByIdAdminModel>();

        }
    }
}