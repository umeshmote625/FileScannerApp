<h3 align="left">Overview</h3>
The FileScanner project is a console application that scans a given directory (and its subdirectories) to identify 
source files of specific types: .c, .h, .cpp, and .rc. The program groups files by the projects (folders) they belong 
to and displays them in a hierarchical format. Files that appear in multiple projects are listed under each relevant project. 
The program provides an output in the console Window

<h3 align="left">Key Features</h3>
Scan a directory and its subdirectories for .c, .h, .cpp, and .rc files.
Group and display files by the projects (folders) they are part of.
Output is presented in a readable format with project names followed by the respective files, indented by one tab.
Simple Undersatndable format Console view result showing the directory path.

<h3 align="left">Limitations and Considerations</h3>
1. The program is not multithreaded. If a directory has many files or deep nesting, the scanning process could be slower.
2. There is no practical limit on the number of files, projects, or folder depth, but performance may degrade with extremely big datasets on systems with 
   limited resources.

<h3 align="left">Future Improvements (Multithreading Consideration)</h3>
1. Multithreading could be used to scan multiple folders or projects concurrently. For example, scanning different directories could be parallelized using the 
   Task class to speed up the process.
