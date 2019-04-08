using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
