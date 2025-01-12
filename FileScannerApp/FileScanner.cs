using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileScannerApp
{
    public class FileScanner : IFileScanner
    {
        public async Task<IEnumerable<string>> ScanFilesAsync(string baseDirectory, string[] fileExtensions)
        {
            var files = new List<string>();

            await Task.Run(() =>
            {
                foreach (var file in Directory.GetFiles(baseDirectory, "*.*", SearchOption.AllDirectories))
                {
                    if (fileExtensions.Contains(Path.GetExtension(file).ToLower()))
                    {
                        files.Add(file);
                    }
                }
            });

            return files;
        }
    }
}
