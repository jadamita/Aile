using System;
using System.Collections.Generic;
using System.Text;

namespace Aile.Core.Headers
{
    public interface IHeaderField
    {
        int GetFieldSize();

        string GetHeaderName();

        byte[] Parse();
    }
}
