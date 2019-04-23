using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public abstract class DrinkDecorator : IDrink
    {
        IDrink _drink;

        protected string _name = "undefined condiment";
        protected double _price = 0.0;

        public DrinkDecorator(IDrink drink)
        {
            _drink = drink;
        }

        public string GetDescription()
        {
            return string.Format("{0}, with {1}", _drink.GetDescription(), _name);
        }

        public double GetCost()
        {
            return _drink.GetCost() + _price;
        }
    }

    public class MilkDecorator : DrinkDecorator
    {
        public MilkDecorator(IDrink coffee)
            : base(coffee)
        {
            _name = "Milk";
            _price = 0.5;
        }
    }

    public class SugarDecorator : DrinkDecorator
    {
        public SugarDecorator(IDrink drink)
            : base(drink)
        {
            _name = "Sugar";
            _price = 0.5;
        }
    }

    public class ChocolateDecorator : DrinkDecorator
    {
        public ChocolateDecorator(IDrink drink)
            : base(drink)
        {
            _name = "Chocolate";
            _price = 0.5;
        }
    }
}
