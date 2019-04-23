namespace AcuCafe
{
    public class Expresso : IDrink
    {
        public string GetDescription()
        {
          return "Expresso"; 
        }

        public bool HasChocolateTopping { get; set; }

        public double GetCost()
        {
            double cost = 1.8;

            return cost;
        }
    }
}