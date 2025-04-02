namespace FeatureToggles;

public class Emailer
{
    public string GetEmailBody(string customerName)
    {
        return $"This is a confirmation of your order, {customerName}";
    }
}