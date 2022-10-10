using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    public class Files_Demo
    {
        string path1 = "C:\\Users\\EI13124\\Task17_a.txt";
        string path2 = "C:\\Users\\EI13124\\Task17_b.txt";
        string path3 = "C:\\Users\\EI13124\\Task17_c.txt";
        /// <summary>
        /// Write contents into the file using StreamWriter class
        /// </summary>
        public void Write()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(path1);
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
           

            try
            {
                int j, i, n;
                Console.Write("\n\n");
                Console.Write("Display the multiplication table vertically from 1 to n:\n");
                Console.Write("---------------------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input upto the table number starting from 1 : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Multiplication table from 1 to {0} \n", n);
                for (i = 1; i <= 10; i++)
                {
                    for (j = 1; j <= n; j++)
                    {
                        if (j <= n - 1)
                            writer.Write("{0}x{1} = {2}, ", j, i, i * j);
                        else
                            writer.Write("{0}x{1} = {2}", j, i, i * j);
                         
                    }

                  
                    writer.Write("\n");
                }
                writer.Write("TABLES");

                

                //File.Move(path3, path2);
                //File.Copy(path1, path3);
                //File.Delete(path2);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
       

        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(path1);
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
                
                Console.WriteLine(".................................................................");
                string[] lines = File.ReadAllLines(path2);
                Console.Write("FIRST LINE FROM TXT FILE\n"+lines[0]);
                Console.WriteLine("\n");
                using (StreamReader sr = File.OpenText(path2))
                {
                    int count = 0;
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        count++;
                    }
                    Console.WriteLine("no of lines:"+ count);
                    
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }






    }
    internal class File1
    {
        public static void Main()
        {
            Files_Demo demo = new Files_Demo();
            demo.Write();
            demo.read();
        }
    }
}


