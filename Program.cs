using System;
using Template_Method;

namespace ReportingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Генерация отчета по студентам
            ReportGenerator studentReport = new StudentReportGenerator();
            Console.WriteLine("Генерация отчета по студентам:");
            studentReport.GenerateReport();

            Console.WriteLine();

            // Генерация отчета по курсам
            ReportGenerator courseReport = new CourseReportGenerator();
            Console.WriteLine("Генерация отчета по курсам:");
            courseReport.GenerateReport();
        }
    }
}

