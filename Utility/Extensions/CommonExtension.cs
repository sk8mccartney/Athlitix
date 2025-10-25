namespace Athlitix.Utility.Extensions;

public static class CommonExtension
{
    public static void CopyCommonProperties(dynamic source, dynamic target)
    {
        target.Id = source.Id;
        target.CreatedAt = source.CreatedAt;
        target.CreatedBy = source.CreatedBy;
        target.ModifiedAt = source.ModifiedAt;
        target.ModifiedBy = source.ModifiedBy;
    }
}