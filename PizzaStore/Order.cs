namespace PizzaStore
{
    public class Order
    {
        private bool _takeAway = false;
        private int _customerDiscount = 0;
        private List<Pizza> _pizzaList = new List<Pizza>();
        private List<int> _totalPricePizza = new List<int>();
        private List<int> _totalPriceTopping = new List<int>();
        private double _totalPrice = 0;

        public Order() 
        {
            
        }

        public void MakeOrder()
        {
            int pizzaNumber = -1;
            Console.WriteLine("enter 1 for finishing order, 2 for new pizza");
            while (GetIntWithLimit(2) == 2)
            {
                Console.Clear();
                _pizzaList.Add(new Pizza());
                pizzaNumber++;
                Pizza pizza = _pizzaList[pizzaNumber];
                pizza.PrintMenu();
                pizza.AddPizza(GetIntWithLimit(27));
                Console.Clear();
                Console.WriteLine("enter 1 for finishing order, 2 for new pizza");
            }
            Console.Clear();
        }
        public void DeleteOrder()
        {

        }
        public void FinalizeOrder()
        {
            for (int i = 0; i < _pizzaList.Count; i++)
            {
                Pizza pizza = _pizzaList[i];
                _totalPricePizza.Add(pizza.Price);
                Console.WriteLine(pizza.ToString());
                _totalPriceTopping = pizza.TotalPriceTopping;

            }
            _totalPrice = _totalPricePizza.Sum() + _totalPriceTopping.Sum();
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return ($"SubTotal: {_totalPrice} Total: {CalculateTotalPrice()}");
        }

        public double CalculateTotalPrice()
        {
            if (_totalPrice > 0)
                return _totalPrice + 40;
            return 0;
        }

        int GetIntWithLimit(int limit)
        {
            string number = Console.ReadLine();
            while (!int.TryParse(number, out _) || limit < int.Parse(number) || int.Parse(number) < 1)
            {
                number = Console.ReadLine();
            }
            return int.Parse(number);
        }
    }
}
