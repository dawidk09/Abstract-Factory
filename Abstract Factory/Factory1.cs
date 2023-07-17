using System;


namespace Design_Pattern_Abstract_Factory
{
    class Factory1: IAbstractFactory
    {

        public ISquare DrawSquare()
        {
            return new SquareMadeOfStars();
        }

        public IRectangle DrawRectangle()
        {
            return new RectangleMadeOfStars();
        }
    }
}
