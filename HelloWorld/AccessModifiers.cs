namespace HelloWorld
{
    public class AccessModifiers
    {
        public string Name {  get; set; }
        public string  Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public AccessModifiers(DateTime birthdate)
        {
            Birthdate = birthdate;
            Name = ""; // Initialize Name and Username here
            Username = "";
        }
        //this field  can be set just once from the construtor

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
