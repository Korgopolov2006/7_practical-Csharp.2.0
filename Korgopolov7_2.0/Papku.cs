using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korgopolov7_2._0
{
    internal class Papku
    {
        public static void Dirs(string s)
        {
            //try {  
            if (Directory.Exists(s))
                {
                    
                    while (true)
                    {

                        Console.Clear();
                        //Console.SetCursorPosition(35, 0);
                        //Console.WriteLine("Выбранная папка: " + selectedItem);
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("".PadRight(120, '-'));
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine($"{"Escape - Вернуться назад",110}");
                        Console.SetCursorPosition(0, 3);
                        Console.WriteLine($"{"F1 - Добавление файла",110}");
                        Console.SetCursorPosition(0, 4);
                        Console.WriteLine($"{"F2 - Добавление директории",110}");
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine($"{"F3 - Удаление файла",110}");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine($"{"F4 - Удаление директории",110}");
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine($"{"Название",15} {"Дата создания",38} {"Тип",19}");

                        string[] Directories = Directory.GetDirectories(s);
                        for (int i1 = 0; i1 < Directories.Length; i1++)
                        {
                            string Direct = Directories[i1];
                            Console.Write("  " + Path.GetFileName(Direct));
                            Console.SetCursorPosition(30, i1 + 3);
                            Console.WriteLine("\t\t" + Directory.GetCreationTime(Direct));
                        }

                        string[] files = Directory.GetFiles(s);
                            for (int i2 = 0; i2 < files.Length; i2++)
                            {
                                string file = files[i2];
                                string fileName = Path.GetFileName(file); // Получаем имя файла без пути

                                Console.Write("  " + fileName);

                                Console.SetCursorPosition(30, i2 + 3 + Directories.Length);
                                string fileExtension = Path.GetExtension(file);
                                Console.WriteLine("\t\t" + Directory.GetCreationTime(file) + "\t\t" + fileExtension);
                            }

                        //for (int i = 1; i < 300; i++)
                        //{
                        //    Console.SetCursorPosition(80, i);
                        //    Console.WriteLine("|");
                       // }


                    int position = Arrow.Arrows(2, Directories.Length + files.Length + 3);

                        if (position == -99)
                            return;

                        else if (position == -111)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название файла ,который хотите создать");
                            DP.DP1(s);
                        }

                        else if (position == -222)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название папки, которую хотите создать");
                            DP.DP2(s);
                        }

                        else if (position == -333)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название файла , которую хотите удалить");
                            DP.DP4(s);
                        }
                        else if (position == -444)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название папки , которую хотите удалить");
                            DP.DP3(s);
                        }

                        else if (position-3 < Directories.Length)
                            Dirs(Directories[position - 3]);
                        else
                            Dirs(files[position - 3 - Directories.Length]);
                        //Dirs(Directories[position - 3]);
                        //Dirs(files[position - Directories.Length - 3]);


                    }
                }
                else
                {

                    Process.Start(new ProcessStartInfo { FileName = s, UseShellExecute = true });
                }
            //}
            //catch (System.Exception e)
            //{
                  //Console.Clear() ;
               //Console.WriteLine($"Error: {e.Message}");

            //}
        }
    }
}
 
