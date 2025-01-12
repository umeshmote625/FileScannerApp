using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileScannerApp
{
    public interface IFileScanner
    {
        Task<IEnumerable<string>> ScanFilesAsync(string baseDirectory, string[] fileExtensions);

    }
}
