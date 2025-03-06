namespace CreateReportApp
{
    /*
     * ФИО студента: Хамитов Айнур Ильгизович
     * номер варианта: 8
     * условие задачи (скопировать из листа задания): 
     * 1 Реализуйте генератор отчетов, где отчеты могут быть различных форматов (PDF, Word, Excel), и используйте шаблонный метод для обработки общих шагов.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Генератор отчетов---------------");
            Console.WriteLine("Выберите формат отчета: 1 - PDF, 2 - Word, 3 - Excel");

            int num = Convert.ToInt32(Console.ReadLine());

            ReportCreate report = null;

            switch (num)
            {
                case 1:
                    report = new ReportPdfCreate();
                    break;
                case 2:
                    report = new ReportWordCreate();
                    break;
                case 3:
                    report = new ReportExcelCreate();
                    break;
            }

            if (report != null)
            {
                Console.WriteLine("...Генерация отчёта...");
                report.CreateReport();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Сохранение прошло успешно");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка выбора формата");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
