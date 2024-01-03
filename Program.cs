using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudentData
{
    internal class Program
    {
        public static void openAndReadFile()
        {
            bool result = File.Exists(@"C:\Practice Project 2\RetrieveStudentData\studentData.txt");
            if (result == true)
            {
                try
                {
                    FileStream readStream = new FileStream(@"C:\Practice Project 2\RetrieveStudentData\studentData.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(readStream);
                    string str = reader.ReadToEnd();
                    Console.WriteLine(str);
                    reader.Close();
                    readStream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File not exists!!");
                FileStream writeStream = new FileStream(@"C:\Practice Project 2\RetrieveStudentData\studentData.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(writeStream);
                writer.WriteLine("This file contains the details of student \n Student data.");
                writer.Close();
                writeStream.Close();
            }
        }
        static void Main(string[] args)
        {
            openAndReadFile();
            Console.ReadLine();
        }
    }
}
