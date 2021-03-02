using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicFilesLib;
using NUnit.Framework;
using Moq;
namespace DirectoryExplorerTests
{
    [TestFixture]
    public class MoqTests
    {
        Mock<IDirectoryExplorer> directoryExplorer;
        Program programTest;
        private readonly string _file1 = "test1.txt";
        private readonly string _file2 = "test2.txt";
        
        [OneTimeSetUp]
        public void setUp()
        {

            directoryExplorer = new Mock<IDirectoryExplorer>();
            directoryExplorer.Setup(x => x.GetFiles(It.IsAny<string>()))
                                        .Returns((string x) => new List<string> { _file1, _file2 });
            programTest = new Program(directoryExplorer.Object);
            
        }

        [Test]
        [TestCase(@"C:\")]
        [TestCase(@"D:\")]
        public void GetFiles_Test(string path)
        {
            ICollection<string> files =programTest.GetFiles(path);
            Assert.IsNotNull(files);
            Assert.IsTrue(files.Count == 2);
            Assert.IsTrue(files.Contains(_file1));
        }
    }
}
