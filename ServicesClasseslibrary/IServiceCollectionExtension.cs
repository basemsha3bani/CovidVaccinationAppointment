﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DataRepository.ModelMappers;
using DataRepository.ModelMappers.Interface;
using DataRepository;
using DataRepository.GateWay;

namespace ServicesClasseslibrary
{
    public static  class IServiceCollectionExtension
    {
        public static IServiceCollection AddServicesOnWhichServiceClassLibaryDepend(this IServiceCollection services)
        {


            services.AddScoped<ISystemSettingsModelMapper, SystemSettingsModelMapper>();
            services.AddScoped<IRegistrarsModelMapper, RegistrarsModelMapper>();
            services.AddScoped<IVaccinationTypesModelMapper, VaccinationTypesModelMapper>();
            services.AddScoped<IVaccinationAppointmentModelMapper, VaccinationAppointmentModelMapper>();
            //services.AddScoped<RecordListInterface<RegistrarsRepository>, RepositoryGateWay<RegistrarsRepository>>();
            //services.AddScoped<RecordListInterface<VaccinationTypesRepository>, RepositoryGateWay<VaccinationTypesRepository>>();
            //services.AddScoped<RecordListInterface<VaccinationReservationRepository>, RepositoryGateWay<VaccinationReservationRepository>>();
            //services.AddScoped<RecordListInterface<SystemSettingsRepository>, RepositoryGateWay<SystemSettingsRepository>>();
            return services;
        }
       
    }
}
