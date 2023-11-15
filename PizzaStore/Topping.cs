namespace PizzaStore
{
    public class Topping
    {
        private string[] _nameArray;
        private string _name;
        private int _price;
        private int _id;
        private int ten = 9;
        private int fithteen = 17;

        public int Price
        {
            get { return _price; }
        }

        public Topping()
        {
/*            string[] nameArray1 = { "Ananas", "artiskok", "paprika", "løg", "oliven", "asparges", "pesto", "chili", "hvidløg i bæger" }; //skal koste 10
            string[] nameArray2 = { "Ost", "skinke", "champignon", "bacon", "cocktailpølser", "rucola", "friske tomater", "parmigiano" }; //skal koste 15
            string[] nameArray3 = { "Gorgonzola", "pepperoni", "ansjoser", "rejer", "kødstrimler", "kødsauce", "frisk mozzarella", "parmaskinke", "salat med tomat", "agurk og dressing", "blandede svampe", "Gorgonzola", "pepperoni", "ansjoser", "rejer", "kødstrimler", "kødsauce", "frisk mozzarella" }; //skal koste 20
*/
            string[] nameArray = { "Ananas", "artiskok", "paprika", "løg", "oliven", "asparges", "pesto", "chili", "hvidløg i bæger", "Ost", "skinke", "champignon", "bacon", "cocktailpølser", "rucola", "friske tomater", "parmigiano", "parmaskinke", "salat med tomat", "agurk og dressing", "blandede svampe", "Gorgonzola", "pepperoni", "ansjoser", "rejer", "kødstrimler", "kødsauce", "frisk mozzarella" };
            _nameArray = nameArray;
        }
        public void AddTopping(int id)
        {
            _id = id - 1;
            _name = _nameArray[_id];
            checkPrice(_id);
        }
        public void RemoveTopping()
        {

        }
        public override string ToString()
        {
            return ($"{_name} - {_price}");
        }
        public void PrintMenu()
        {
            for (int i = 0; i < _nameArray.Length; i++)
            {
                checkPrice(i + 1);
                Console.WriteLine($"{i + 1}. {_nameArray[i]} - {_price}");
            }
        }

        public void checkPrice(int number)
        {
            if (number <= ten)
            {
                _price = 10;
            }
            else if (number <= fithteen)
            {
                _price = 15;
            }
            else _price = 20;
        }
    }
}
