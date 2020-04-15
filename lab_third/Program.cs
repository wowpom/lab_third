using System;

namespace lab_third
{
    class Program
    {
        private delegate double MyDelegate(double x);

        static void Menu()
        {
            MyDelegate[] mydelegate = new MyDelegate[10];
            Random rnd = new Random();
            MathematicalOperation meth = new MathematicalOperation();
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(rnd.Next(1, 5));
                switch (a)
                {
                    case 1:
                        mydelegate[i] = meth.Add;
                        break;
                    case 2:
                        mydelegate[i] = meth.Multiply;
                        break;
                    case 3:
                        mydelegate[i] = meth.Division;
                        break;
                    case 4:
                        mydelegate[i] = meth.Subtraction;
                        break;
                    case 5:
                        mydelegate[i] = meth.Pow;
                        break;

                }
            }
            Console.WriteLine("Введите число");
            double num = double.Parse(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            {
                num = mydelegate[j](num);

            }
            Console.WriteLine("Вы хотите ввести ещё одно число? \n Введите 1 если да");
            if (Console.ReadLine() == "1")
                Menu();
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
