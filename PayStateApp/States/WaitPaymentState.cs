using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayStateApp
{
    public class WaitPaymentState : IState
    {
        public WaitPaymentState()
        {
        }

        public void ChoiceService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: услуга уже выбрана");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WaitPayment()
        {
            Console.WriteLine("Оплата произведена, производим переход в состояние подтверждения оплаты.");
        }

        public void ConfirmPayment()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: сначала произведите оплату");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
