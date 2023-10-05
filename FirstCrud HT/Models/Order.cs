using FileBaseContext.Abstractions.Models.Entity;

namespace FirstCrudAPI_Hometask.Models
{
    //- Order(id, amount, userId )
    public class Order : IFileSetEntity<Guid>
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Guid UserId { get; set; }
    }
}
