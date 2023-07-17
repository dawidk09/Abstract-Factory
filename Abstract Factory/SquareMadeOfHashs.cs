using System;

namespace Design_Pattern_Abstract_Factory
{
    class SquareMadeOfHashs: ISquare
    {
        public void DrawSquare(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("#");
                for (int j = 0; j < a-1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
