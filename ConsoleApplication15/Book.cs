/*1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год. 
/**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication15
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Author { get; set; }
        public int realaeseDate { get; set; }             
    }
}
