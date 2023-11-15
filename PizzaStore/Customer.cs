namespace PizzaStore
{
    public class Customer
    {
        private string _name;
        private string _phone;
        private string _email;
        private bool _customerClub = false;
        private Order order = new Order();

        public Customer(string name, string phone, string email)
        {
            _name = name;
            _phone = phone;
            _email = email;
        }
        /*
        public void MakeAccount(string name, string phone, string email)
        {
        } to be implemented */
        public void UpdateInfo(string name, string phone, string email)
        {
            _name = name;
            _phone = phone;
            _email = email;
        }
        public void JoinCustomerClub()
        {
            _customerClub = true;
        }
        public void LeaveCustomerClub() 
        { 
            _customerClub = false; 
        }
        public override string ToString()
        {
            return ($"Name: {_name} Phone: {_phone} Email: {_email} CustomerClub: {_customerClub}");
        }

        public void MakeOrder()
        {
            order.MakeOrder();
            Console.WriteLine(ToString());
            order.FinalizeOrder();
        }
    }
}
