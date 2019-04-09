using System;
using System.Collections.Generic;
using System.Text;

namespace Aile.Util
{
    public static class FileParserUtils
    {
        /// <summary>
        /// Checks if the given MS-DOS header contains the "magic number" 'MZ', which indicates it's a binary executable file.
        /// </summary>
        /// <returns></returns>
        public static bool IsWin32Binary(byte[] fileBytes)
        {
            if (fileBytes == null || fileBytes.Length < 2)
                return false;

            byte[] mzSignature = new byte[] { 0x4D, 0x5A };

            if (fileBytes[0].Equals(mzSignature[0]) && fileBytes[1].Equals(mzSignature[1]))
            {
                return true;
            }
            return false;
        }
    }
}
