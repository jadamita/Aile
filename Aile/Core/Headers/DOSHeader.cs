using Aile.Core.Headers.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aile.Core.Headers
{
    public class DOSHeader
    {
        private byte[] _headerBytes;

        private List<IHeaderField> dosHeaders;

        public DOSHeader(byte[] headerBytes)
        {
            dosHeaders = new List<IHeaderField>();
        }

        private void InitializeHeaders()
        {
            dosHeaders.Add(new ShortHeaderField("Magic Number", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Last Block Byte Count", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Block Count", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Relocation Entry Count", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Paragraph Header Count", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Maximum Paragraph Count", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Stack Segment Relative value", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Initial SP Register Value", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Word Checksum", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Initial IP Register Value", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Initial CS Register Value", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("First Relocation Offset", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("Overlay Number", _headerBytes));

            dosHeaders.Add(new ReservedHeaderField(8, _headerBytes));

            dosHeaders.Add(new ShortHeaderField("OEM ID", _headerBytes));
            dosHeaders.Add(new ShortHeaderField("OEM Info", _headerBytes));

            dosHeaders.Add(new ReservedHeaderField(20, _headerBytes));
            dosHeaders.Add(new LongHeaderField("PE Header Offset", _headerBytes));
        }

        public void BeginRead()
        {

        }
    }
}
