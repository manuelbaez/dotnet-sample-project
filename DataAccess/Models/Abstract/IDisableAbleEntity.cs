namespace DataAccess.Models.Abstract;

public interface IDisableAbleEntity
{
    public bool IsActive { get; set; }
}