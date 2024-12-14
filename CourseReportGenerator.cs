using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    // Класс для генерации отчета по курсам
    public class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о курсах.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Данные о курсах обработаны: подсчитано количество записей на курсы.");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет о курсах отформатирован в список.");
        }
    }
}
