using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA_LEC_13_3
{
    class Источник
    {
        private Делегат v_подписчики = null;

        public void РегистрацияДелегата(Делегат v_делегат)
        {
            v_подписчики += v_делегат;
        }

        public void ОтказОтРегистрации(Делегат v_делегат)
        {
            v_подписчики -= v_делегат;
        }

        public void Оповещение(string s_сообщение)
        {
            Console.WriteLine("\nИсточник оповещает о событии <{0}>", s_сообщение);

            if(v_подписчики != null)
                v_подписчики(this);
        }

        public void Информация()
        {
            Console.WriteLine("Получение информации о состоянии источника...");
        }
    }
}
