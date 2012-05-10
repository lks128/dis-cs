using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_13_3
{
    class Наблюдатель1
    {
        public void РеакцияНаСобытие(object v_источник)
        {
            Console.WriteLine("Объект класса Наблюдатель1 сообщение принял");
            ((Источник) v_источник).Информация();
        }
    }
}
