using FileBaseContext.Abstractions.Models.Entity;

namespace FirstCrudAPI_Hometask.Models
{
    //- User(id, firstname, lastname, emailAddress, password )

    public class User : IFileSetEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
