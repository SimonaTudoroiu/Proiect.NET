namespace Project_Tudoroiu_Simona_251.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }

    }
}
