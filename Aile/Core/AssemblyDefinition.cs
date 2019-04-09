using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;
using Aile.Util;
using Aile.Core.Headers;

namespace Aile
{
    public class AssemblyDefinition
    {
        private string _assemblyFilePath;

        private long _streamLength;

        private BinaryReader _binaryReader;

        // Headers
        private DOSHeader _dosHeader;

        public AssemblyDefinition(string assemblyFilePath)
        {
            try
            {
                _binaryReader = new BinaryReader(File.Open(assemblyFilePath, FileMode.Open));
                
                if (_binaryReader.BaseStream.Length > 0)
                    this._streamLength = _binaryReader.BaseStream.Length;

                if (_streamLength > 0)
                {
                    if (FileParserUtils.IsWin32Binary(_binaryReader.ReadBytes(2)))
                    {
                        Debug.WriteLine("we got a valid file!");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        public BinaryReader GetBinaryReader()
        {
            return this._binaryReader;
        }

        public long GetFileLength()
        {
            return (this._streamLength);
        }

    }
}
