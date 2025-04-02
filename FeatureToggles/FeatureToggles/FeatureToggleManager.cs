namespace FeatureToggles;

public interface IFeatureToggleManager
{
    public Task<bool> GetValue(string featureName);
}

public class FeatureToggleManager : IFeatureToggleManager
{
    private readonly Dictionary<string, bool> _flags;

    public FeatureToggleManager(Dictionary<string, bool> flags)
    {
        _flags = flags;
    }


    public Task<bool> GetValue(string featureName)
    {
        return Task.FromResult(_flags[featureName]);
    }
}
