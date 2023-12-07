namespace AdventTest2023;
using Advent2023;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        DayOne d = new DayOne();
        
        int lineValue = d.GetLineValue("a8d0e9d1ddfeae");
        Assert.Equal(81 , lineValue);
        lineValue = d.GetLineValue("onasfdoih5afduhhuubn");
        Assert.Equal(55,lineValue);
        var total = d.RunIt();
        Assert.Equal(54390,total);
    }
}