using System; 

namespace Sharp { }

class Program {

    static void Main() {

        
        
        Console.WriteLine(" Введите 2 числа для сравнения: ");
        Console.Write(" 1) ");
        float n1 = Convert.ToSingle(Console.ReadLine());
        Console.Write(" 2) ");
        float n2 = Convert.ToSingle(Console.ReadLine());

        if (n1 == n2)
        {
            Console.WriteLine(" {0} равно {1} ", n1, n2);
        }
        else if (n1 > n2)
        {
            //float r1 = n1 - n2;
            float r1 = (float)Math.Round(n1 - n2, 4);
            float q1 = (float)Math.Round(n1 / n2, 4);

            Console.WriteLine($" {0} больше {1} на {2} и в {3} раз ");
        }
        else if (n1 < n2)
        {
            //float r2 = n2 - n1;
            float r2 = (float)Math.Round((n2 - n1), 4);
            float q2 = (float)Math.Round((n2 / n1), 4);


            Console.WriteLine($" {0} больше {1} на {2} в {3} раз ");
        }




        //q1 = Convert.ToDouble(Console.ReadLine()) - ошибка, т.к переменная не double

        //for (float i = 300; i > 2; i /= 3) {
        //  Console.WriteLine("eee {0}", i);

        //выведем в консоль значения введеных пользователем символов Console.WriteLine()
        // при  n1 = Console.ReadLine(); - выдает ошибку, нужно ковертировать Convert. 
        // тип файла int в тип файла sring  с помощью метода ToInt32 (для int)


        /*
         
          bool HA = true;
        while (HA)
        {
            string end = Console.ReadLine();
            if(end == "loh") 
                HA = false;
        }

        Console.WriteLine("введите радиус:");
        float n1 = Convert.ToSingle(Console.ReadLine());
        float n2 = Math.Abs(n1);
        float n3 = 3f;
        Console.WriteLine("круг с радиусом {0} равен {1} а число Пи равно {2}", n1, n2, n3); 
         
        float user;
        user = float.Parse(Console.ReadLine());
        Console.WriteLine(user);

        float res;
        res = user + 10f;
        Console.WriteLine(res);
        
        /*
        Вывод информации (Console.)
          WriteLine() - с переносом ,Write()  - без
          ReadKey - символ, ReadLine - энтер.
        Типы данных
          int num1 = 6; float num2 = 2.353f; string wr1 = "ЕЕЕ";  
          char wr2 = 'Е'; bool IH = true;
        нужно конвертировать строку для "целого числа"
        с помощью Convert.ToDouble


        */



    }

}
 