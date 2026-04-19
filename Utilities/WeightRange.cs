namespace Athlitix.Utilities;

// Object for the weight range min is inclusive, max exclusive
public record WeightRange(string Label, double Min, double Max);

// As they categories will not change its a static list
public static class WeightRanges
{
    public static readonly WeightRange[] All =
    {
        new("Under 48 kg", 0, 48),
        new("Under 51 kg", 48, 51),
        new("Under 54 kg", 51, 54),
        new("Under 57 kg", 54, 57),
        new("Under 60 kg", 57, 60),
        new("Under 63.5 kg", 60, 63.5),
        new("Under 67 kg", 63.5, 67),
        new("Under 71 kg", 67, 71),
        new("Under 75 kg", 71, 75),
        new("Under 80 kg", 75, 80),
        new("Under 86 kg", 80, 86),
        new("Under 92 kg", 86, 92),
        new("Over 92 kg", 92, 200),
    };
}