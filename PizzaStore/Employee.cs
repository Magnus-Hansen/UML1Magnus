namespace PizzaStore
{
    public class Employee
    {
        private string _name;
        private string _phone;
        private static int _countID = 0;
        private int _id;

        public string Name
        {
            get { return _name; }
        }
        public string Phone
        {
            get { return _phone; }
        }
        public int ID
        {
            get { return _id; }
        }

        public Employee(string name, string phone)
        {
            _name = name;
            _phone = phone;
            _countID++;
            _id = _countID;
        }
        public void getOrder()
        {

        }
        public void UpadteInfo(string name, string phone) 
        {
            _name = name;
            _phone = phone;
        }
        public override string ToString()
        {
            return ($"ID: {ID.ToString()} Name: {Name} Phone: {Phone}");
        }
    }
}
