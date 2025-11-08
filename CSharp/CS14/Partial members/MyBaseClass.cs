namespace PartialMembers;

internal abstract class MyBaseClass
{
    protected MyBaseClass(int id)
    {
        Id = id;
    }

    public int Id { get; }
}
