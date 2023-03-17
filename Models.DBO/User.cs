using Infrastructure.Interface;


namespace Models.DBO
{
    public class User: IEntityHelpers<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }

        public User Copy(User enty)
        {
            this.Name = enty.Name;
            this.Password = enty.Password;
            this.Login = enty.Login;
            return this;
        }
    }
}
