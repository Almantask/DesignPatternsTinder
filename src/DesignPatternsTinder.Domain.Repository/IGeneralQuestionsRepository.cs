using DesignPatternsTinder.Domain.Models;

namespace DesignPatternsTinder.Domain.Repository
{
    public interface IGeneralQuestionsRepository : ICreateOnlyRepository<GeneralQuestion>, IReadOnlyRepository<int, GeneralQuestion>
    {
    }
}
