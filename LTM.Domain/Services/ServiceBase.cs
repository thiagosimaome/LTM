using LTM.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace LTM.Domain.Services
{
    public class ServiceBase<Tentity> : IDisposable, IServiceBase<Tentity> where Tentity : class
    {
        private readonly IRepositoryBase<Tentity> _repositorio;

        public ServiceBase(IRepositoryBase<Tentity> repositorio)
        {
            _repositorio = repositorio;
        }

        public void add(Tentity obj)
        {
            _repositorio.add(obj);
        }

        public IEnumerable<Tentity> Getall()
        {
            return _repositorio.Getall();
        }

        public Tentity GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Remove(Tentity obj)
        {
            _repositorio.Remove(obj);
        }

        public void Update(Tentity obj)
        {
            _repositorio.Update(obj);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }
    }
}
