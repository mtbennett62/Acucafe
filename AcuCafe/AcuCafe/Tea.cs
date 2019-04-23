namespace AcuCafe
{
    public class Tea : IDrink
    {
        public string GetDescription()
        {
            return "Hot tea"; 
        }

        public double GetCost()
        {
            double cost = 1;

            return cost;
        }
    }
}