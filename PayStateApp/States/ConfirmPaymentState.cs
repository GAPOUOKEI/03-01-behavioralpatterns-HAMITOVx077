using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayStateApp
{
    public class ConfirmPaymentState : IState
    {
        public ConfirmPaymentState()
        {
        }

        public void ChoiceService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: Оплата не потверждена");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WaitPayment()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: Оплата не потверждена");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ConfirmPayment()
        {
            Console.WriteLine("Оплата успешно подтверждена");
        }
    }
}
