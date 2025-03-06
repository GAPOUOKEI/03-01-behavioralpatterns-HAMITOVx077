namespace PayStateApp
{
    /*
     * ФИО студента: Хамитов Айнур Ильгизович
     * номер варианта: 8
     * условие задачи (скопировать из листа задания): 
     * 2 Разработайте приложение для оплаты, где можно находиться в состояниях (выбор услуги, ожидание оплаты, подтверждение оплаты). Доступные действия зависят от состояния.
     */
    internal class Program
    {
        private static IState _currentState;

        static void Main(string[] args)
        {
            _currentState = new ChoiceServiceState();

            Console.WriteLine("------------Приложение для оплаты------------");
            Console.WriteLine("Ккоманды: 1 - Выбрать услугу, 2 - Произвести оплату, 3 - Подтвердить оплату");

            while (true)
            {
                Console.Write("Введите команду: ");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        _currentState.ChoiceService();
                        if (_currentState is ChoiceServiceState)
                        {
                            _currentState = new WaitPaymentState();
                        }
                        break;
                    case "2":
                        _currentState.WaitPayment();
                        if (_currentState is WaitPaymentState)
                        {
                            _currentState = new ConfirmPaymentState();
                        }
                        break;
                    case "3":
                        _currentState.ConfirmPayment();
                        break;
                    default:
                        Console.WriteLine("Система не распознала команду");
                        break;
                }
            }
        }
    }
}
