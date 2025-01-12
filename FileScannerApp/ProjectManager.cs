using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileScannerApp
{
    public class ProjectManager : IProjectManager
    {
        public Dictionary<string, List<string>> GroupFilesByProjects(IEnumerable<string> files)
        {
            var projects = new Dictionary<string, List<string>>();

            foreach (var file in files)
            {
                var projectFolder = Path.GetDirectoryName(file);
                if (!projects.ContainsKey(projectFolder))
                {
                    projects[projectFolder] = new List<string>();
                }

                projects[projectFolder].Add(file);
            }

            return projects;
        }
    }
}
