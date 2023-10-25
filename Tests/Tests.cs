namespace GitInfo.Dungeon;

public sealed class Tests : TestBase
{
    public Tests(ITestOutputHelper testOutput) : base(testOutput) { }

    [Fact]
    public void Should_BeTrue()
    {
        const bool boolean = true;

        boolean.Should().BeTrue();
    }
}
