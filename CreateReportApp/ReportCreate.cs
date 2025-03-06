using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateReportApp
{
    public abstract class ReportCreate
    {
        public void CreateReport()
        {
            FormatProccesing();
            FormatReport();
            SaveReport();
        }

        protected virtual void FormatProccesing()
        {
            Console.WriteLine("Обработка формата для сохранения");
        }
        protected abstract void FormatReport();

        protected abstract void SaveReport();
    }
}
