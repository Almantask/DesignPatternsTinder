﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTinder.Infrastructure.Repository.Entities
{
    public interface IWithId
    {
        uint Id { get; }
    }
}
