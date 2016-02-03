using ClassLibrary1;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemX myItemX = new ItemX();
            ItemY myItemY = new ItemY();

            myItemX.Associate(myItemY);
            myItemY.Associate(myItemX);

            Context myContext = new Context();
            myContext.Add(myItemX);
            myContext.Add(myItemY);
        }
    }
}
