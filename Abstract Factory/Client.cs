using System;

namespace Design_Pattern_Abstract_Factory
{
    class Client
    {
        public void Order()
        {
           
            Console.WriteLine("Client: Figures made of * \n");;
            ClientMethod(new Factory1());
            

            Console.WriteLine("Client: Figures made of # \n");
            
            ClientMethod(new Factory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var square = factory.DrawSquare();
            var rectangle = factory.DrawRectangle();

            square.DrawSquare(5);
            rectangle.DrawRectangle(2, 3);
        }
    }
}
