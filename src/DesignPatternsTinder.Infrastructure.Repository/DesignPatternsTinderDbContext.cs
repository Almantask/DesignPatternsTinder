using DesignPatternsTinder.Infrastructure.Repository.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DesignPatternsTinder.Infrastructure.Repository
{
    public class DesignPatternsTinderDbContext: DbContext
    {
        public virtual List<GeneralQuestion> GeneralQuestions { get; set; }
        public virtual List<SpecializedQuestion> SpecializedQuestions { get; set; }
        public virtual List<DesignPattern> DesignPatterns { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}
