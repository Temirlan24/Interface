using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public class House
    {
        public Basement Basement { get; set; }
        public Door Door { get; set; }

        public Roof Roof { get; set; }

        public Wall Wall { get; set; }

        public Window Window { get; set; }
        public House()
        {
            Basement = new Basement();
            Door = new Door();
            Roof = new Roof();
            Wall = new Wall();
            Window = new Window();
        }
        public void Show(int side)
        {
            for (int i = 0; i < 6; i++)
                Console.Write(Roof.IsBuilt ? "^" : "NOT");

            Console.WriteLine(" ");

            for (int i = 0; i < 8; i++)
                Console.Write(Roof.IsBuilt ? "^" : "NOT");

            Console.WriteLine(" ");


            for (int i = 0; i < 10; i++)
                Console.Write(Roof.IsBuilt ? "^" : "NOT");

            Console.WriteLine(" ");
            if (side == 0)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Basement.IsBuilt ? "=" : "NOT");

                Console.WriteLine("\n ");

                Console.WriteLine(Window.IsBuilt ? "|      |" : "NOT");
                Console.WriteLine(Window.IsBuilt ? "|      |" : "NOT");

                Console.WriteLine("\n ");

                Console.WriteLine(Door.IsBuilt ? "|----o|" : "NOT");

                Console.WriteLine("\nПеред");
            }
            else if (side == 1)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Basement.IsBuilt ? "=" : "");


                Console.WriteLine("\n ");

                Console.WriteLine(Window.IsBuilt ? "      " : "");
                Console.WriteLine(Window.IsBuilt ? "      " : "");

                Console.WriteLine("Право");
            }
            else if (side == 2)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Basement.IsBuilt ? "=" : "");
                Console.WriteLine("\n ");

                Console.WriteLine(Window.IsBuilt ? "|      |" : "NOT");
                Console.WriteLine(Window.IsBuilt ? "|      |" : "NOT");

                Console.WriteLine("\nЛево");
            }
            else if (side == 3)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Wall.IsBuilt ? "B" : "NOT");

                Console.WriteLine(" ");

                for (int i = 0; i < 10; i++)
                    Console.Write(Basement.IsBuilt ? "=" : "");
                Console.WriteLine("\n ");

                Console.WriteLine(Window.IsBuilt ? "|      |" : "NOT");
                Console.WriteLine(Window.IsBuilt ? "|      |" : "NOT");

                Console.WriteLine("Сзади");
            }
        }
    }
}
