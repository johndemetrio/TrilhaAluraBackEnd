using System;
using Xunit;
namespace testes_xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        return Assert.Equal(20, Test1.Sum(10,10));
    }
}   