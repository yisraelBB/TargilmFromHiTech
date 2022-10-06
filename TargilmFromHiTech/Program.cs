namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //targil1();
            //targil2();
            //targil3();
            //targil4();
            //targil5();
            //targil6();
            //targil7();
            //targil8();
            //targil9();
            //targil10();
            //targil11();
            //targil12();
            //targil13();
            //targil14();
            targil15();
        }
        /// ////////   /////              

        static void targil1()//קליטה מהמשתמש
        {
            Console.WriteLine("Targil1");
            string name, age, cityname;
            int numage;
            Console.Write("users name:");//שם משתמש
            name = Console.ReadLine();
            Console.Write($"{name} your age:");//גיל המשתמש            
            age = Console.ReadLine();
            numage = int.Parse(age);//המרה מסטרינג לינת

            Console.Write($"{name} your city of residence:");//עיר מגורים
            cityname = Console.ReadLine();

            Console.WriteLine($"users name:{name} ,{name}'s age:{numage} ,{name}'s city:{cityname}");

        }


        public static void targil2()//מדפיס מספרים מ1 עד 100
        {
            Console.WriteLine("Targil2");
            int x = 0, y = 10;
            while (x < 100)
            {
                if (x == y)
                {
                    Console.WriteLine();
                    y += 10;
                }
                Console.Write($"{x + 1},");
                x++;
            }
            Console.WriteLine();
        }

        public static void targil3()//מחשבת את הסכום מ1 עד 100
        {//from yosef
            Console.WriteLine("Targil 3");
            int num = 1, sum = 0;
            while (num <= 100)
            {
                sum = sum + num;
                num++;
            }
            Console.WriteLine(sum);
        }

        public static void targil4()//מדפיסה את המספרים אי זוגי מ50 עד 200
        {
            Console.WriteLine("Targil4");
            int num = 50;
            while (num <= 200)
            {
                if (num % 2 != 0)
                {
                    Console.Write($"{num},");

                }
                num++;
            }
            Console.WriteLine();
        }

        public static void targil5()//לחשב עצרת 
        {
            string input;
            int num = 0, sum = 1;
            Console.WriteLine("Targil5");
            Console.WriteLine("write num");
            input = Console.ReadLine();
            num = int.Parse(input);

            while (num > 0)
            {
                sum *= num;
                num--;
            }
            Console.WriteLine($"An factorial of {input} is {sum}");
        }

        public static void targil6()//משפת איף
        {
            Console.WriteLine("Targil6");
            int num1, num2;
            string input;
            Console.WriteLine("Write a number");
            input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.WriteLine("Write a number");
            input = Console.ReadLine();
            num2 = int.Parse(input);

            if (num1 + num2 > 100)
            {
                Console.WriteLine("Bigger then 100");
            }
            else
            {
                Console.WriteLine($"{num1}+{num2}={num1 + num2} ");
            }

        }

        public static void targil7()//מיני מחשבון
        {
            Console.WriteLine("Targil7");
            int num1, num2, num3 = 0;
            string input, mat;

            while (num3 < 3)
            {
                Console.Write("Write a number: ");
                input = Console.ReadLine();
                num1 = int.Parse(input);
                Console.Write("Write a mat: ");
                mat = Console.ReadLine();
                Console.Write("Write a number: ");
                input = Console.ReadLine();
                num2 = int.Parse(input);

                if (mat == "+")
                {
                    Console.WriteLine($" {num1}+{num2}={num1 + num2} ");
                }
                else if (mat == "-")
                {
                    Console.WriteLine($" {num1}-{num2}={num1 - num2} ");
                }
                else if (mat == "*")
                {
                    Console.WriteLine($" {num1}*{num2}={num1 * num2} ");
                }
                else if (mat == "/")
                {
                    Console.WriteLine($" {num1}/{num2}={num1 / num2} ");
                }
                num3++;
            }
        }

        public static void targil8()
        {
            Console.WriteLine("Targil8");
            Console.WriteLine($"Rules: num1+num2 >10.5 && num1-num2 <5.5 ");
            double num1, num2;
            string input;
            Console.Write("Write a number: ");
            input = Console.ReadLine();
            num1 = double.Parse(input);
            Console.Write("Write a number: ");
            input = Console.ReadLine();
            num2 = double.Parse(input);

            if (num1 + num2 > 10.5 && num1 - num2 < 5.5)
            {
                Console.WriteLine($"{num1}+{num2}>10.5 and{num1}-{num2}<5.5");
            }
        }

        public static void targil9()//אופרטור הטרנארי
        {
            Console.WriteLine("Targil9");
            int num1, num2, num3, big;
            string input;

            Console.Write("Write a number  ");
            input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.Write("Write a number  ");
            input = Console.ReadLine();
            num2 = int.Parse(input);
            Console.Write("Write a number  ");
            input = Console.ReadLine();
            num3 = int.Parse(input);

            big = num1 > num2 ? num1 : num2;
            big = big > num3 ? big : num3;
            Console.WriteLine($"big number is {big}");
        }

        public static void targil10()//קליטת 10 מספרים ולהדפיס את הגדול מבניהם
        {
            Console.WriteLine("Targil10");
            int num, big = 0, i = 0;

            Console.Write("Write a number  ");
            num = int.Parse(Console.ReadLine());
            while (i < 9)
            {
                Console.Write("Write a number  ");
                num = int.Parse(Console.ReadLine());
                big = big > num ? big : num;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"The big number is :{big}");
        }

        public static void targil11()//
        {
            Console.WriteLine("Targil11");
            int num = 1;
            while (num < 100)
            {
                if (num % 2 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("Boom");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("2");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("3");
                }
                else
                {
                    Console.WriteLine(num);
                }
                num++;
            }

        }

        public static void targil12()
        {
            Console.WriteLine("Targil12"); //משחק הנחושים
            int secretnum, guess = 0, tot = 0;
            Console.WriteLine("Write secret number ");
            secretnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a number ");
            guess = int.Parse(Console.ReadLine());
            tot++;
            while (secretnum != guess)
            {

                if (secretnum < guess)
                {
                    Console.WriteLine("mistake,smaller");
                }
                else
                {
                    Console.WriteLine("mistake,bigger");
                }

                Console.WriteLine("Write a number ");
                guess = int.Parse(Console.ReadLine());
                tot++;
            }
            Console.WriteLine("true");
            Console.WriteLine($"secret number is {secretnum}");
            Console.WriteLine($"guessed the secret number using-{tot} attempts");

        }

        public static void targil13()
        {
            Console.WriteLine("Targil13");
            int tot = 0;
            Console.WriteLine("Write secret number");
            int secretNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a number");
            int guess = int.Parse(Console.ReadLine());
            tot++;
            int previousDifference = 0, currentDifference;
            while (guess != secretNum)
            {
                currentDifference = guess - secretNum;
                if (currentDifference < 0)
                {
                    currentDifference = -currentDifference;//אופרטר אביגציה
                }
                if (tot == 1 || currentDifference == previousDifference)
                {
                    Console.WriteLine("mistake");
                }
                //ניחושים שני ואילך
                else
                {
                    if (currentDifference < previousDifference)
                    {
                        Console.WriteLine("Mitchamem");
                    }
                    else
                    {
                        Console.WriteLine("Mitkarer");
                    }


                }
                Console.WriteLine("Write a number");
                guess = int.Parse(Console.ReadLine());
                tot++;
                previousDifference = currentDifference;

            }

            Console.WriteLine("true");
            Console.WriteLine($"secret number is {secretNum}");
            Console.WriteLine($"guessed the secret number using-{tot} attempts");
        }

        public static void targil14()//רישוני
        {
            Console.WriteLine("Targil14");
            int input, div = 2;
            Console.WriteLine("Write a number");
            input = int.Parse(Console.ReadLine());
            bool rishoni = true;
            while (rishoni && div < input)
            {
                if (input % div == 0)
                {
                    rishoni = false;
                }
                div++;
            }

            if (rishoni)
            {
                Console.WriteLine($"{input} is rishoni");
            }
            else
            {
                Console.WriteLine($"{input} is not rishoni");
            }
        }

        public static void targil15()
        {
            Console.WriteLine("Targil15");
            int num1, num2, tot = 0;
            Console.WriteLine("Write a number'1'");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a number'2'");
            num2 = int.Parse(Console.ReadLine());
            float input = 1;
            while (tot != num2)
            {
                input = input * num1;
                tot++;
            }
            Console.WriteLine($"{num1}^{num2}={input}");
        }
       
    }
}

