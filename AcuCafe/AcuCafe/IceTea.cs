namespace AcuCafe
{
    public class IceTea : IDrink
    {
        public string GetDescription()
        {
             return "Ice tea"; 
        }

        public double GetCost()
        {
            double cost = 1.5;

            return cost;
        }
    }
}