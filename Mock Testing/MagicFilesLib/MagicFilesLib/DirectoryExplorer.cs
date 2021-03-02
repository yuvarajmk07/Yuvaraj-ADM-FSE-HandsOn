using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace MagicFilesLib
{
    public interface IDirectoryExplorer

    {

        ICollection<string> GetFiles(string path);

    }
    public class DirectoryExplorer : IDirectoryExplorer

    {

        public ICollection<string> GetFiles(string path)

        {

            string[] files = Directory.GetFiles(path);

            return files;

        }

    }



    public class Program
    {
        IDirectoryExplorer directoryExplorer;
        public Program(IDirectoryExplorer directoryExplorer)
        {
            this.directoryExplorer = directoryExplorer;
        }
        public ICollection<string> GetFiles(string path)
        {
            ICollection<string> files = directoryExplorer.GetFiles(path);
            return files;
        }
    }
}
