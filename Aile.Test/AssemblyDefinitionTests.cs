using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aile.Util;

namespace Aile.Test
{
    [TestClass]
    public class AssemblyDefinitionTests
    {
        // Testing methods should follow: <method>_Should<expected>_When<condition>

        [TestMethod]
        public void Constructor_ShouldThrow_WhenInvalid()
        {
            FileNotFoundException expectedException = null;

            try
            {
                AssemblyDefinition assemblyDefinition = new AssemblyDefinition("Does_Not_Exist.exe");
            }
            catch (FileNotFoundException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void Constructor_ShouldParse_WhenValid()
        {
            AssemblyDefinition assemblyDefinition = new AssemblyDefinition("Aile.TestFile.exe");
            Assert.AreEqual(assemblyDefinition.GetFileLength(), 4608);
        }

        [TestMethod]
        public void IsWin32Binary_ShouldReturnTrue_WhenValid()
        {
            byte[] validBinaryFileBytes = new byte[] { 0x4D, 0x5A }; // Valid MZ Signature

            bool isValid = FileParserUtils.IsWin32Binary(validBinaryFileBytes);

            Assert.AreEqual(isValid, true);
        }

        [TestMethod]
        public void IsWin32Binary_ShouldReturnFalse_WhenInvalid()
        {
            byte[] invalidBinaryFileBytes = new byte[] { 0xCA, 0xFE }; // Invalid signature (.class file)

            bool isValid = FileParserUtils.IsWin32Binary(invalidBinaryFileBytes);

            Assert.AreEqual(isValid, false);
        }
    }
}
