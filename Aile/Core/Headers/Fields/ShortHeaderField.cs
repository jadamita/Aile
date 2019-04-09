using System;
using System.Collections.Generic;
using System.Text;

namespace Aile.Core.Headers.Fields
{
    public class ShortHeaderField : IHeaderField
    {
        private byte[] _headerBytes;
        private string _fieldName;

        public ShortHeaderField(string fieldName, byte[] headerBytes)
        {
            this._headerBytes = headerBytes;
        }

        public int GetFieldSize()
        {
            return 2;
        }

        public string GetHeaderName()
        {
            return this._fieldName;
        }
    }
}
