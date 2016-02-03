using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Context
    {
        List<ItemX> listX = new List<ItemX>();
        List<ItemY> listY = new List<ItemY>();

        public void Add(ItemX item)
        {
            listX.Add(item);
        }

        public void Add(ItemY item)
        {
            listY.Add(item);
        }
    }
}
