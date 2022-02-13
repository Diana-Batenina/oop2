using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskoop5
{
    public struct Record
    {
        public int ClientID; // идентификационный номер клиента
        public int Year; // год
        public int Duration; // продолжительность занятий
                             // в данном году (в часах)
    }
    class Program
    {
        static void Main(string[] args)
        {
            Record firstRecord = new Record();
            firstRecord.ClientID = 1;
            firstRecord.Year = 2002;
            firstRecord.Duration = 5;

            Record secondRecord = new Record();
            secondRecord.ClientID = 2;
            secondRecord.Year = 2002;
            secondRecord.Duration = 10;

            Record thirdRecord = new Record();
            thirdRecord.ClientID = 3;
            thirdRecord.Year = 2003;
            thirdRecord.Duration = 12;

            Record forthRecord = new Record();
            forthRecord.ClientID = 4;
            forthRecord.Year = 2001;
            forthRecord.Duration = 10;

            List<Record> RecordList = new List<Record>() { firstRecord, secondRecord, thirdRecord, forthRecord };

            string myResult = MaxYearAndDuration(RecordList);

            Console.WriteLine(myResult);

            Console.ReadKey();
        }



        public static string MaxYearAndDuration(List<Record> rlist)
        {
            SortedDictionary<int, int> yearList = new SortedDictionary<int, int>();

            foreach (Record record in rlist)
            {
                if (!yearList.ContainsKey(record.Year))
                {
                    yearList.Add(record.Year, record.Duration);
                }
                else
                {
                    yearList[record.Year] = (yearList[record.Year] + record.Duration);
                }
            }

            int maxValue = yearList.Values.Max();
            int maxYear = new int();

            for (int i = 0; i < yearList.Count; i++)
            {
                if (yearList.ElementAt(i).Value == maxValue)
                {
                    maxYear = yearList.ElementAt(i).Key;
                    break;
                }
            }

            return ($"Наибольшая суммарная продолжительность занятий была в {maxYear}. Суммарное время всех занятий составило {maxValue} часов.");
        }
}
}
