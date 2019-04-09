using System;
using System.Collections.Generic;
using System.Text;

namespace Aile.Core.Headers.Fields
{
    public class ReservedHeaderField : IHeaderField
    {
        private int _fieldSize;
        private byte[] _headerBytes;

        public ReservedHeaderField(int fieldSize, byte[] headerBytes)
        {
            this._fieldSize = fieldSize;
            this._headerBytes = headerBytes;
        }

        public int GetFieldSize()
        {
            return this._fieldSize;
        }

        public string GetHeaderName()
        {
            return "RESERVED";
        }
    }
}
