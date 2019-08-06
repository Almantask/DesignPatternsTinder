using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTinder.Domain.Repository
{
    public interface IReadOnlyRepository<TKey, TModel>
    {
        TModel Get(TKey key);
        IQueryable<TModel> Get();
    }
}
