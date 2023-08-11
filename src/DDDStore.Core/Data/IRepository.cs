using DDDStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDStore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggrateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
        
}
