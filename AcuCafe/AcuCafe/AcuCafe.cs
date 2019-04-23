using System;

namespace AcuCafe
{
    public class AcuCafe
    {
        public static IDrink OrderDrink(IDrink drink, bool hasMilk, bool hasSugar, bool? hasChocolateTopping = null)
        {
            try
            {
                if (hasSugar)
                    drink = new SugarDecorator(drink);
                if (hasChocolateTopping == true)
                {
                    if (typeof(Expresso) == drink.GetType())
                        drink = new ChocolateDecorator(drink);
                    else
                        throw new ArgumentException("You cannot add chocolate to this drink");
                }
                if (hasMilk)
                {
                    if (drink.GetType() == typeof(IceTea))
                        throw new ArgumentException("You cannot add milk to Ice Tea");
                    else
                        drink = new MilkDecorator(drink);
                }
                Console.WriteLine($"We are preparing the following drink for you: {drink.GetDescription()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"We are unable to prepare your drink. Reason: {ex.Message}");
            }

            return drink;
        }
    }
}