using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{ public interface IContainersRepository
    {
        Task<Guid> AddAsync(Container container, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Container container, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid containerId, CancellationToken cancellationToken);
    }
}