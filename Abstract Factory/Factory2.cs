
namespace Design_Pattern_Abstract_Factory
{
    class Factory2: IAbstractFactory
    {
       
        public ISquare DrawSquare()
        {  
            return new SquareMadeOfHashs();
        }

        public IRectangle DrawRectangle()
        {
            return new RectangleMadeOfHashs();
        }
    }
}
