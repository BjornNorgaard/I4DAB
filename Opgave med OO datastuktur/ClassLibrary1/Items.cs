namespace ClassLibrary1
{
    public class ItemX
    {
        int Val1Y;
        string Val2Y;
        ItemY itemY;

        public void Associate(ItemY item)
        {
            itemY = item;
        }
    }

    public class ItemY
    {
        int Val1X;
        string Val2X;
        ItemX itemX;

        public void Associate(ItemX item)
        {
            itemX = item;
        }
    }
}