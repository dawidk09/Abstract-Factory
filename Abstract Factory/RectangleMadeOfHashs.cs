using System;

namespace Design_Pattern_Abstract_Factory
{
    class RectangleMadeOfHashs: IRectangle
    {
        public void DrawRectangle(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("#");
                for (int j = 1; j < b; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
