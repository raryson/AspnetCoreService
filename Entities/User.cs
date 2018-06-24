namespace AspnetCoreService.Entities
{
    public class User
    {
        public User(string name, string password, string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
        }
        
        public int ID { get;set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

}