using DesignPatternsTinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTinder.Domain.Repository
{
    public interface ICreateOnlyRepository<T> where T: IWithId
    {
        void Create(T model);
    }
}
