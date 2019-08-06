using DesignPatternsTinder.Domain.Models;
using DesignPatternsTinder.Domain.Repository;
using System;
using System.Linq;

namespace DesignPatternsTinder.Infrastructure.Repository
{
    public class AnswerRepository : IAnswersRepository
    {
        public void Create(Answer model)
        {
            throw new NotImplementedException();
        }

        public Answer Get(int key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Answer> Get()
        {
            throw new NotImplementedException();
        }
    }
}
