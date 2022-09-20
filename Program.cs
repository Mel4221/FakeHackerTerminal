using System;
using QuickTools;

namespace FakeHackerScreen
{
    class MainClass
    {
        static int X = Console.BufferWidth;
        static int Y = Console.BufferHeight;
        static int Cx = New.RandomInt(1, X - 1);
        static int Cy = New.RandomInt(1, Y - 1);
        static int Interval = 100;
       // static bool R = true; 
        public static void Main(string[] args)
        {
            


           
            Get.Clear();
            Console.Title = "Hacking";
            Action ChangeTitle = () => 
            {

                switch (Console.Title)
                {
                    case "Hacking...":
                        Console.Title = "Hacking.."; 
                        break;
                    case "Hacking..":
                        Console.Title = "Hacking.";
                        break;
                    case "Hacking.":
                        Console.Title = "Hacking";
                        break;
                    case "Hacking":
                        Console.Title = "Hacking...";
                        break;

                }
            }; 
            Func<string> type = () => 
            {
                string text = null; 
                if(args.Length > 0 )
                {
                    switch(args[0])
                    {
                        case "n":
                            text = New.Pin(X*Y); 
                        break;
                        case "-n":
                            text = New.Pin(int.Parse(args[1])); 
                            break;
                        case "t":
                            Interval = int.Parse(args[1]); 
                            break;
                             
                    }

                    return text;
                }
                else
                {
                    return New.Password(X * Y);
                }


            };

            while (true)
            {
                Console.SetCursorPosition(Cx, Cy);
                ChangeTitle(); 
                string randomText = type(); //New.Pin(X*Y+100).ToString();//
                Color.Green(randomText);
                Get.WaitTime(Interval);
            }


        }
    }
}
