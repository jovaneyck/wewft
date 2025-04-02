namespace FeatureToggles;

public interface IEmailer
{
    string GetEmailBody(string customerName);
}

public class Emailer : IEmailer
{
    public string GetEmailBody(string customerName)
    {
        return $"This is a confirmation of your order, {customerName}";
    }
}