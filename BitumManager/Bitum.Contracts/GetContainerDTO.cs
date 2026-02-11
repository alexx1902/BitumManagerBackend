using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitum.Contracts
{
    public record GetContainerDTO(string Search, int page, int limit)
    { }
}