using DesignPatternsTinder.Domain.Models;
using DesignPatternsTinder.Domain.Repository;
using System;
using System.Linq;

namespace DesignPatternsTinder.Infrastructure.Repository
{
    public class GeneralQuestionsRepository : IGeneralQuestionsRepository
    {
        public void Create(GeneralQuestion model)
        {
            throw new NotImplementedException();
        }

        public GeneralQuestion Get(int key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GeneralQuestion> Get()
        {
            throw new NotImplementedException();
        }
    }
}
