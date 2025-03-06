using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayStateApp
{
    public class ChoiceServiceState : IState
    {
        public ChoiceServiceState()
        {
        }

        public void ChoiceService()
        {
            Console.WriteLine("Услуга выбрана, производим переход в состояние ожидания оплаты.");
        }

        public void WaitPayment()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: сначала выберите услугу");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ConfirmPayment()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: сначала выберите услугу и произведите оплату");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
