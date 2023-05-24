using System;

namespace LWork_3_switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int s=5;
            try
            {
                Console.Write("Введите номер студента в журнале: ");
                s = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception mytry)
            {
                Console.Write(mytry.Message);
            }
            switch (s)
            {
                case 1:
                    {
                        Console.Write("{0} - Бордюг",s);
                        break;
                    }
                case 2:
                    {
                        Console.Write("{0} - Верещака", s);
                        break;
                    }
                case 3:
                    {
                        Console.Write("{0} - Докторович", s);
                        break;
                    }
                case 4:
                    {
                        Console.Write("{0} - Иванов", s);
                        break;
                    }
                case 5:
                    {
                        Console.Write("{0} - Лень", s);
                        break;
                    }
                case 6:
                    {
                        Console.Write("{0} - Никитченко", s);
                        break;
                    }
                case 7:
                    {
                        Console.Write("{0} - Пантус", s);
                        break;
                    }
                case 8:
                    {
                        Console.Write("{0} - Пантус", s);
                        break;
                    }
                case 9:
                    {
                        Console.Write("{0} - Сорокотяга", s);
                        break;
                    }
                case 10:
                    {
                        Console.Write("{0} - Трохимец", s);
                        break;
                    }
                case 11:
                    {
                        Console.Write("{0} - Ульянич", s);
                        break;
                    }
            }
        }
    }
}
