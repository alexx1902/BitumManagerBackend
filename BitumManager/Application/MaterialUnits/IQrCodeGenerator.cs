using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitum.Application.MaterialUnits
{
    public interface IQrCodeGenerator
    {
        byte[] Generate(string content);
    }
}
