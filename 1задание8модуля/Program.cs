using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                pathDir();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: "+ex.Message); 
            }
        }
        static void pathDir()
        {
            Console.WriteLine("Введите путь директории:");
            string dirName = Console.ReadLine();
            try
            {
                if (Directory.Exists(dirName));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            {
                    string[] dirs = Directory.GetDirectories(dirName);
                    string[] files = Directory.GetFiles(dirName);
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        if (Directory.Exists(dirs[i]))
                        {
                            DateTime d = Directory.GetCreationTime(dirs[i]) + TimeSpan.FromMinutes(1); // 1 минута за место 30
                            if (d <= DateTime.Now)
                            {
                                Directory.Delete(dirs[i], true);
                                Console.WriteLine($"Папка по пути удалена, т. к. не использовалась 1 мин: {dirs[i]}");
                            }
                        }
                    }
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (File.Exists(files[i]))
                        {
                            DateTime d = File.GetCreationTime(files[i]) + TimeSpan.FromMinutes(1); // 1 минута за место 30
                            if (d <= DateTime.Now)
                            {
                                File.Delete(files[i]);
                                Console.WriteLine($"файл по пути удален, т. к. не использовался 1 мин: {files[i]}");
                            }
                        }
                    }
                }
           

        }
    }
}