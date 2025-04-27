using FacadePattern.Interfaces;

namespace FacadePattern;

public class Validate : IValidate
{
    public bool ValidateOrder()
    {
        return true;
    }
}