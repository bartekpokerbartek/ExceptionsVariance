using System.Collections.Generic;

class BaseClass { }
class DerivedClass : BaseClass { }

class BaseComparer : IEqualityComparer<BaseClass>
{
    public int GetHashCode(BaseClass baseInstance)
    {
        return baseInstance.GetHashCode();
    }
    public bool Equals(BaseClass x, BaseClass y)
    {
        return x == y;
    }
}

class Program
{
    public static void Main()
    {
        IEqualityComparer<BaseClass> baseComparer = new BaseComparer();

        IEqualityComparer<DerivedClass> childComparer = baseComparer;
    }
}