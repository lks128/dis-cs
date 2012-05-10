using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_13_3
{
    class Наблюдатель2
    {
        public void РеакцияНаСобытие(object v_источник)
        {
            Console.WriteLine("Объект класса Наблюдатель2 сообщение принял");
        }
    }
}
