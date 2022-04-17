/*3)	Make the Employee, MarketingExecutive and Manager class as Serializable
created in LitwareLib.dll .
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project7
{
    public class FileHandling
    {
      public  static void Main()
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText(@"D:\\filename.txt", writeText);  // Create a file and write the content of writeText to it
            string readText = File.ReadAllText(@"D:\filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
            // Created Copy
            File.Copy(@"D:\filename.txt", @"D:\Test.txt");
            File.AppendAllText(@"D:\Test.txt", "Appent this content");
            File.Copy(@"D:\Test.txt", @"D:\Test1.txt");
            //Delete File
            File.Delete(@"D:\Test1.txt");
            File.Encrypt(@"D:\Test.txt");
            //Decrypt the file
            File.Decrypt(@"D:\Test.txt");
            //Create File Info
            string myPath = @"D:\MyDir\hey.txt";
            FileInfo fileinfo = new FileInfo(myPath);
            // Created the file using FileInfo
            FileStream fs = fileinfo.Create();
            Console.WriteLine("created");          
            fs.Close();
            // to open the text file
            StreamReader sr = fileinfo.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
        }
    }
}
