using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayStateApp
{
    public interface IState
    {
        void ChoiceService();
        void WaitPayment();
        void ConfirmPayment();
    }
}
