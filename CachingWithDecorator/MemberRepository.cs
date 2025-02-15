using Microsoft.EntityFrameworkCore;

namespace CachingWithDecorator;

public class MemberRepository(DbContext context) : IMemberRepository
{
    public Member? GetById(int id)
    {
        return context.Set<Member>().First(member => member.Id == id);
    }

    public Member? GetOrCreate(string key, Func<object, Member> func)
    {
        throw new NotImplementedException();
    }
}