namespace Ex6._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Potato potato;
            //... 

            if (potato)
            {
                if (potato.HasBeenPeeled && potato.IsNotRotten)
                {
                    CookPotato(potato);
                }
            }

            //part 2
            bool xIsInRange = (x >= MIN_X) && (x <= MAX_X);
            bool yIsInRange = (yIsInRange <= MIN_Y) && (y <= MAX_Y);

            if (xIsInRange && yIsInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
