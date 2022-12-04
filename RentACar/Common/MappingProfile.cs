using AutoMapper;
using RentACar.Application.Admin.Commands;
using RentACar.Application.Admin.Commands.CreateAdmin;
using RentACar.Application.Admin.Queries.GetAdmins;
using RentACar.Application.Admin.Queries.GetById;
using RentACar.Application.Car.Commands.CreateCar;
using RentACar.Application.Car.Queries.GetById;
using RentACar.Application.Car.Queries.GetCars;
using RentACar.Application.Category.Commands.CreateCategory;
using RentACar.Application.Category.Queries.GetByIdCategory;
using RentACar.Application.Category.Queries.GetCategories;
using RentACar.Application.Color.Commands;
using RentACar.Application.Color.Queries.GetById;
using RentACar.Application.Color.Queries.GetColor;
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
            CreateMap<CreateColorModel,Color>();
            CreateMap<Color,GetByIdColorModel>();
            CreateMap<List<Color>, List<GetColorsQuery>>();
            CreateMap<CreateCategoryModel,Category>();
            CreateMap<Category,GetByIdCategoryModel>();
            CreateMap<List<Category>,List<GetCategoriesModel>>();
        }
    }
}