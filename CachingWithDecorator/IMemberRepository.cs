namespace CachingWithDecorator;

public interface IMemberRepository
{
    Member? GetById(int id);
}