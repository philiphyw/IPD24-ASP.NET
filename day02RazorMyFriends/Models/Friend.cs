namespace day02RazorMyFriends.Models
{
    public class Friend
    {
        private int _age;
        private string _name;
       
                public int Id { get; set; }
        public int Age { get => _age; set{
            if (value<1 || value>150)
            {
                throw new DataInvalidException("Age must be in 1-150 range");
            }
            _age = value;

        }}
        public string Name { get => _name; set{
            if (value.Length<1 || value.Length>50)
            {
                throw new DataInvalidException("Name must be 1-50 characters long");
            }
            _name = value;

        }}
    }
}