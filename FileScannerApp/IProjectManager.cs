using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileScannerApp
{
    public interface IProjectManager
    {
        Dictionary<string, List<string>> GroupFilesByProjects(IEnumerable<string> files);
    }
}
