/*1)Write a console application which will read text files from mentioned file system location. 
 * And list subdirectories from mentioned folder on file system using System.IO namespace and 
 * use DirectoryInfo, Directory, File and FileInfo Classes with all the methods present in these classes.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project7
{
    class Directories
    {
        static void Main()
        {
            // Create Directory
            string path = @"D:\MyDir";
            string directoryPath = @"D:\MyNewDir";
            // Created directory using Directory  
            DirectoryInfo dir = Directory.CreateDirectory(directoryPath);
            //gives dir fullname
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Name);
            //Create directory using DirectoryInfo
            DirectoryInfo dirs = new DirectoryInfo(path);
            // Delete directory
            dirs.Delete(true);
            //Create Directory
            dirs.Create();
            // Directory moved to path2
            dirs.MoveTo(directoryPath);
            // create subDirectory
            dirs.CreateSubdirectory("MysubDir");
            Console.WriteLine("Directory Created");
            Console.ReadLine();
        }
    }
}
