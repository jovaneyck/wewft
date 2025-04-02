using Xunit;

namespace FeatureToggles;

public class EmailerTests
{
    [Fact]
    public void SendEmailTest()
    {
        var emailer = new Emailer();

        var emailBody = emailer.GetEmailBody(":customer:name:");
        
        Assert.Equal("This is a confirmation of your order, :customer:name:", emailBody);
    }
}