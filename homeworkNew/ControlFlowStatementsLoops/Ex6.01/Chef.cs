namespace Ex6._01
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            //... 
        }
        private Carrot GetCarrot()
        {
            //...
        }
        private void Cut(Vegetable potato)
        {
            //...
        }
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;
            Peel(potato);

            Peel(carrot);
            bowl = GetBowl();
            Cut(potato);
            Cut(carrot);
            bowl.Add(carrot);

            bowl.Add(potato);
        }
        private Potato GetPotato()
        {
            //...
        }
    }
}
