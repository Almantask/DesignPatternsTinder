using DesignPatternsTinder.Domain.Models;
using DesignPatternsTinder.Domain.Repository;
using System;
using System.Linq;

namespace DesignPatternsTinder.Infrastructure.Repository
{
    public class DesignPatternsRepository : IDesignPatternsRepository
    {
        public void Create(DesignPattern model)
        {
            throw new NotImplementedException();
        }

        public DesignPattern Get(uint key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DesignPattern> Get()
        {
            throw new NotImplementedException();
        }
    }
}
