using DesignPatternsTinder.Domain.Models;
using DesignPatternsTinder.Domain.Repository;
using System;
using System.Linq;

namespace DesignPatternsTinder.Infrastructure.Repository
{
    public class SpecializedQuestionsRepository : ISpecializedQuestionsRepository
    {
        public void Create(SpecializedQuestion model)
        {
            throw new NotImplementedException();
        }

        public SpecializedQuestion Get(int key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SpecializedQuestion> Get()
        {
            throw new NotImplementedException();
        }
    }
}
