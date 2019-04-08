public abstract class Entity : IEntity
{
    public int Id { get; set; }

    public bool Validate()
    {
        throw new System.NotImplementedException();
    }
}