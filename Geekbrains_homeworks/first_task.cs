            // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

            int num_A = Convert.ToInt32(Console.ReadLine());

            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число " + num_A + " больше, чем второе " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число " + num_B + " больше, чем первое " + num_A);
            }
            break;

            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Максимальное из введённых чисел -> " + max);
            break;

            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            }
            break;

            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            int i = 1;
            bool not = true;

            num = Convert.ToInt32(Console.ReadLine());

            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            break;

        default:
            begin = false;
            break;
    }
}