using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о студентах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Данные о студентах обработаны: подсчитаны средние баллы.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет о студентах отформатирован в таблицу.");
        }
    }
}
