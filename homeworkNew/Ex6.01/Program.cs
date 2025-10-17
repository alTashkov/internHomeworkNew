namespace Ex6._01
{
    public class Chef
    {
        private Potato GetPotato()
        {
            //...
        }

        private void PeelPotato()
        {
            //...
        }

        private void CutPotato(Vegetable potato)
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private void PeelCarrot()
        {
            //...
        }

        private void CutCarrot(Vegetable carrot)
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            PeelPotato(potato);
            CutPotato(potato);

            Carrot carrot = GetCarrot();
            PeelCarrot(carrot);
            CutCarrot(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);
        }
    }
}
