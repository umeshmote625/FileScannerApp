using FileScannerApp;

class Program
{
    static async Task Main(string[] args)
    {
        //For test manually assign path of folder to scan
        //string baseDirectory = @"C:\Users\umesh\source\repos\Test";
        if (args.Length < 1)
        {
            Console.WriteLine("Please specify the base directory path.");
            return;
        }

        string baseDirectory = args[0];
        var fileScanner = new FileScanner();
        var projectManager = new ProjectManager();

        var fileExtensions = new[] { ".c", ".h", ".cpp", ".rc" };
        var files = await fileScanner.ScanFilesAsync(baseDirectory, fileExtensions);
        var projects = projectManager.GroupFilesByProjects(files);

        foreach (var project in projects)
        {
            Console.WriteLine($"Project: {project.Key}");
            foreach (var file in project.Value)
            {
                Console.WriteLine($"  {file}");
            }
        }
    }
}