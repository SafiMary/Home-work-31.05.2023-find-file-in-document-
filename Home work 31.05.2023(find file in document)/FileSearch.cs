using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_31._05._2023_find_file_in_document_
{
    internal class FileSearch
    {

        public FileSearch()//конструктор, одновременно задает параметры поиска файла
        {
            StartDate = this.SetStartDate();
            StopDate = this.SetStopDate();
        
        }
      
        public DateTime StartDate;
        public DateTime StopDate;
        public DateTime SetStartDate()//дата создания файла от пользователя
        {
            Console.Write("Для поиска файла необходимо ввести временной диапазон поиска.\nВведите стартовую дату поиска.\n");
            Console.Write("Введите месяц  в формате ММ: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Введите день в формате ДД: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Введите год в формате ГГГГ: ");
            int year = int.Parse(Console.ReadLine());
            DateTime StartDate = new DateTime(year, month, day);
            return StartDate;
        }
        public DateTime SetStopDate()//дата последних изменений в файле от пользователя
        {
            Console.Write("Для поиска файла необходимо ввести временной диапазон поиска.\nВведите конечную дату поиска.\n");
            Console.Write("Введите месяц  в формате ММ: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Введите день в формате ДД: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Введите год в формате ГГГГ: ");
            int year = int.Parse(Console.ReadLine());
            DateTime StopDate = new DateTime(year, month, day);
            return StopDate;
        }
      
        public string[] Signature_File()
        {
            Console.WriteLine("\nВведите  минимум 12 символов, содержащихся в файле:");
           
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в int
            string[] Signature = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nВведите строку размером 12 символов №{0}:    ", i + 1);
                Signature[i] = Console.ReadLine(); //Заполняем его
            }
            Console.WriteLine("Вы ввели следующие строки:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Signature[i]);
            }
            return Signature;

        }
        public string[] str2Arr(string text)//разделитель строк
        {
            string[] _arr = text.Split(' ');
            return _arr;
        }
        public void File_Search(FileSearch one)//поиск файла в зависимости от выбора пользователя
        {
            
            Console.WriteLine("Выберите где будет поиск файла?\n 1. Мои документы 2.Мой компьютер 3. Моя музыка 4.Мои рисунки");
            int input;
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    foreach (var filename in Directory.EnumerateFiles(myDocuments, "*.txt"))
                    {
                        FileInfo fileInfo = new FileInfo(filename);
                        StreamReader streamReader = new StreamReader(filename);
                        if (one.StartDate <= fileInfo.LastWriteTime & fileInfo.LastWriteTime < one.StopDate)
                        {
                            Console.WriteLine($"{filename} " +
                                $"создан {fileInfo.CreationTime.ToString("yyyy.MM.dd")}" +
                                $" изменён {fileInfo.LastWriteTime.ToString("yyyy.MM.dd")}");
                        }
                        var file = str2Arr(streamReader.ReadToEnd());
                        try
                        {
                           string  match = Signature_File().Intersect(file).FirstOrDefault();
                            Console.WriteLine($"{match}" +
                                $"содержится в файле {filename}");
                        }
                        catch (Exception e00)
                        {
                            Console.WriteLine(e00.Message);
                        }
                        streamReader.Close();
                    }
                    break;
                case 2:
                    string myComputer = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                    foreach (var filename in Directory.EnumerateFiles(myComputer, "*.txt"))
                    {
                        FileInfo fileInfo = new FileInfo(filename);
                        StreamReader streamReader = new StreamReader(filename);
                        if (one.StartDate <= fileInfo.LastWriteTime & fileInfo.LastWriteTime < one.StopDate)
                        {
                            Console.WriteLine($"{filename} " +
                                $"создан {fileInfo.CreationTime.ToString("yyyy.MM.dd")}" +
                                $" изменён {fileInfo.LastWriteTime.ToString("yyyy.MM.dd")}");
                        }
                        var file = str2Arr(streamReader.ReadToEnd());
                        try
                        {
                            string match = Signature_File().Intersect(file).FirstOrDefault();
                            Console.WriteLine($"{match}" +
                                $"содержится в файле {filename}");
                        }
                        catch (Exception e00)
                        {
                            Console.WriteLine(e00.Message);
                        }
                        streamReader.Close();
                    }
                    break;
                case 3:
                    string myMusic = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    foreach (var filename in Directory.EnumerateFiles(myMusic, "*.txt"))
                    {
                        FileInfo fileInfo = new FileInfo(filename);
                        StreamReader streamReader = new StreamReader(filename);
                        if (one.StartDate <= fileInfo.LastWriteTime & fileInfo.LastWriteTime < one.StopDate)
                        {
                            Console.WriteLine($"{filename} " +
                                $"создан {fileInfo.CreationTime.ToString("yyyy.MM.dd")}" +
                                $" изменён {fileInfo.LastWriteTime.ToString("yyyy.MM.dd")}");
                        }
                        var file = str2Arr(streamReader.ReadToEnd());
                        try
                        {
                            string match = Signature_File().Intersect(file).FirstOrDefault();
                            Console.WriteLine($"{match}" +
                                $"содержится в файле {filename}");
                        }
                        catch (Exception e00)
                        {
                            Console.WriteLine(e00.Message);
                        }
                        streamReader.Close();
                    }
                    break;
                case 4:
                    string myPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    foreach (var filename in Directory.EnumerateFiles(myPictures, "*.txt"))
                    {
                        FileInfo fileInfo = new FileInfo(filename);
                        StreamReader streamReader = new StreamReader(filename);
                        if (one.StartDate <= fileInfo.LastWriteTime & fileInfo.LastWriteTime < one.StopDate)
                        {
                            Console.WriteLine($"{filename} " +
                                $"создан {fileInfo.CreationTime.ToString("yyyy.MM.dd")}" +
                                $" изменён {fileInfo.LastWriteTime.ToString("yyyy.MM.dd")}");
                        }
                        var file = str2Arr(streamReader.ReadToEnd());
                        try
                        {
                            string match = Signature_File().Intersect(file).FirstOrDefault();
                            Console.WriteLine($"{match}" +
                                $"содержится в файле {filename}");
                        }
                        catch (Exception e00)
                        {
                            Console.WriteLine(e00.Message);
                        }
                        streamReader.Close();
                    }
                    break;
                
                default:
                    Console.WriteLine("Что ты наделал?Неправильный ввод!!");
                    break;
            }
           
       
   


        } } }
    
