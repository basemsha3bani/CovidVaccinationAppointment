﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataRepository.GateWay
{
    public class RepositoryGateWay<TModelRepository>:RecordListInterface<TModelRepository> where TModelRepository:class
    {
        DbConext dbConext = new DbConext();
       


        internal  void Add(Repository repository)
        {
            dbConext.Entry(repository).State = EntityState.Added;

            dbConext.SaveChanges();
        }
        internal  void Edit(Repository repository)
        {

            dbConext.Entry(repository).State = EntityState.Modified;
          
            dbConext.SaveChanges();
            

         
        }

        public static explicit operator RepositoryGateWay<TModelRepository>(RepositoryGateWay<Repository> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator RepositoryGateWay<TModelRepository>(RepositoryGateWay<RegistrarsRepository> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator RepositoryGateWay<TModelRepository>(RepositoryGateWay<VaccinationReservationRepository> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator RepositoryGateWay<TModelRepository>(RepositoryGateWay<VaccinationTypesRepository> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator RepositoryGateWay<TModelRepository>(RepositoryGateWay<SystemSettingsRepository> v)
        {
            throw new NotImplementedException();
        }

        internal void Edit(Repository repository, Repository withnewvalues)
        {
            dbConext.Entry(repository).State = EntityState.Detached;

            dbConext.Entry(withnewvalues).State = EntityState.Modified;
            dbConext.SaveChanges();
           
        }

        internal  void Delete(Repository repository)
        {
            dbConext.Entry(repository).State = EntityState.Deleted;

            dbConext.SaveChanges();
        }

        internal TModelRepository GetById(Expression<Func<TModelRepository, bool>> predicate)
        {
            return dbConext.Set<TModelRepository>().Where(predicate).FirstOrDefault();

           
        }

        internal List<TModelRepository> List()
        {
          return  dbConext.Set<TModelRepository>().ToList();

           
        }






    }
    
}
