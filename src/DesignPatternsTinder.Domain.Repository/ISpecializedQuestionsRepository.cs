using DesignPatternsTinder.Domain.Models;

namespace DesignPatternsTinder.Domain.Repository
{
    public interface ISpecializedQuestionsRepository : ICreateOnlyRepository<SpecializedQuestion>, IReadOnlyRepository<int, SpecializedQuestion>
    {
    }
}
