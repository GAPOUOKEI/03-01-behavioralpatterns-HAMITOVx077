using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateReportApp
{
    public class ReportWordCreate : ReportCreate
    {
        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета в Word");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("Отчет сохранен в формате Word");
        }
    }
}
