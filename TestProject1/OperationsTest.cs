using Library;

namespace TestProject1;

public class OperationsTest
{
    private readonly Operations _operations = new();
    [Theory]
    [InlineData(1,1)]
    [InlineData(3,5)]
    [InlineData(3,0)]
    public void Sum_Should_Work(int a, int b)
    {
        Assert.Equal(_operations.sum(a, b), a + b);
    }



    [Fact]
    public void Sum_Should_Not_Work()
    {
        Assert.Equal(-1, _operations.sum(1, 1));
    }
}