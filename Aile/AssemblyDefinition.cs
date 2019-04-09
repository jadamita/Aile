using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;
using Aile.Util;

namespace Aile
{
    public class AssemblyDefinition
    {
        private string _assemblyFilePath;

        private long _streamLength;

        private BinaryReader _binaryReader;

        public AssemblyDefinition(string assemblyFilePath)
        {
            try
            {
                _binaryReader = new BinaryReader(File.Open(assemblyFilePath, FileMode.Open));
                
                if (_binaryReader.BaseStream.Length > 0)
                    this._streamLength = _binaryReader.BaseStream.Length;

                if (_streamLength > 0)
                {
                    // start file processing here
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
