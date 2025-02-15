using Microsoft.Extensions.Caching.Memory;

namespace CachingWithDecorator;

public class CachingMemberRepository(IMemoryCache cache, IMemberRepository memberRepository) : IMemberRepository
{
    public Member? GetById(int id)
    {
        string key = $"members-{id}";

        return cache.GetOrCreate(
            key,
            entry => {
                entry.SetAbsoluteExpiration(
                    TimeSpan.FromMinutes(5));

                return memberRepository.GetById(id);
            });
    }
}