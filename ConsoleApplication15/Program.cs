/*1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год. 
 * Создать коллекцию элементов Book и заполнить тестовыми данными. С помощью класса BinaryFormatter сохранить
 *  состояние приложения в двоичный файл.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = "Куприн";
            book.Name = "Рассказы";
            book.realaeseDate = 1972;
            string fileName = @"C:\root\binary.bat";
         //   SaveAsBinaryFormat(book, fileName);
            LoadFromBinaryFile(fileName);
            Console.ReadLine();
        }
        static void SaveAsBinaryFormat(object graph, string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName,
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, graph);
            }
            Console.WriteLine("=> Saved  in binary format!");
        }
        static void LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                Book book = (Book)binFormat.Deserialize(fStream);
                Console.WriteLine("Name - {0}", book.Name);
            }
        }
    }
}
