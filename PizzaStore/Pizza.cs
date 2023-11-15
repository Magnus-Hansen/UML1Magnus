namespace PizzaStore
{
    public class Pizza
    {
        private string _name;
        private int _price;
        private int _id;
        private string _ingredients;
        private string[] _arrayName;
        private int[] _arrayPrice;
        private string[] _arrayIngredients;
        private List<Topping> _toppingList = new List<Topping>();
        private List<int> _totalPriceTopping = new List<int>();

        public int Price
        {
            get { return _price; }
        }
        public List<int> TotalPriceTopping
        {
            get { return _totalPriceTopping; }
        }

        public Pizza()
        {
            string[] arrayName = { "Margherita", "Vesuvio", "Capricciosa", "Calzone", "Quattro Stagioni", "Marinara", "Vegetariana", "Italiana", "Gorgonzola", "Contadina", "Napoli", "Vichinga", "Calzone Speciale", "Esotica", "Tonno", "Sardegna", "Romana", "Sole", "Big Mamma", "La salami", "Rocco", "Marco", "KoKKode", "Antonello", "Pasqualino", "Felix", "Bambino" };
            _arrayName = arrayName;

            int[] arrayPrice = { 77, 88, 93, 93, 95, 93, 92, 88, 95, 87, 89, 93, 92, 92, 95, 92, 93, 93, 95, 92, 95, 95, 95, 95, 99, 59, 63 };
            _arrayPrice = arrayPrice;

            string[] arrayIngredients = { "Tomat & ost", "Tomat, ost & skinke", "Tomat, ost, skinke & champignon", "Indbagt pizza med tomat, ost, skinke & champignon", "Tomat, ost, skinke, champignon, rejer & paprika", "Tomat, ost, rejer, muslinger & hvidløg", "Tomat, ost & grønsager", "Tomat, ost, løg & kødsauce", "Tomat, gorgonzola, løg & champignon", "Tomat, ost, champignon & oliven", "Tomat, ost, ansjoser & oliven", "Tomat, ost, skinke, champignon, paprika, hvidløg & chili (stærk)", "(Ikke indbagt) tomat, ost, rejer, skinke & kødsauce", "Tomat, ost, skinke, rejer & ananas", "Tomat, ost, tun & rejer", "Tomat, ost, cocktailpølser, bacon, løg & æg", "Tomat, ost, skinke, bacon & løg", "Tomat, ost, skinke, bacon & æg", "Tomat, gorgonzola, rejer, asparges og parmaskinke", "Tomat, ost, salami & skinke", "Tomat, ost, kødstrimler, løg, chili, paprika & hvidløg", "Tomat, ost, skinke, champignon, løg & kødstrimler", "(Ny) tomat, ost, kyllingefilet, ærter & pancetta (italiensk bacon)", "Tomat, ost, skinke, kødsauce, cocktailpølser & løg", "Tomat, ost, pepperoni & ananas", "Tomat, ost & pepperoni", "skinke/ost eller peperoni/ost eller kødsovs/ost samt nutella"};
            _arrayIngredients = arrayIngredients;
        }

        public void AddPizza(int id)
        {
            _id = id - 1;

            _name = _arrayName[_id];
            _price = _arrayPrice[_id];
            _ingredients = _arrayIngredients[_id];

            int toppingNumber = -1;
            Console.Clear();
            Console.WriteLine("want topping?? no = 1  yes = 2");
            while (GetIntWithLimit(2) == 2)
            {
                Console.Clear();

                _toppingList.Add(new Topping());
                toppingNumber++;
                Topping topping = _toppingList[toppingNumber];
                topping.PrintMenu();
                topping.AddTopping(GetIntWithLimit(28));
                Console.Clear();

                Console.WriteLine("want topping?? no = 1  yes = 2");
            }
        }
        public void RemovePizza()
        {

        }
        public override string ToString()
        {
            return ($"{_id + 1}. {_name} - {_price} Ingredients: {_ingredients}");
        }
        public void PrintMenu()
        {
            for (int i = 0; i < _arrayName.Length; i++)
                Console.WriteLine($"{i + 1}. {_arrayName[i]} - {_arrayPrice[i]} -- {_arrayIngredients[i]}");
        }
        public void CalCulatePrice()
        {
            for (int f = 0; f < _toppingList.Count; f++)
            {
                Topping topping = _toppingList[f];
                _totalPriceTopping.Add(topping.Price);
                Console.WriteLine(topping.ToString());
            }
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
