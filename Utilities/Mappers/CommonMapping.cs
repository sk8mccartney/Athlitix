namespace Athlitix.Utilities.Mappers;

public static class CommonMapping
{
    public static void CopyCommonProperties(dynamic source, dynamic target)
    {
        target.Id = source.Id;
        target.IsActive = source.IsActive;
        target.CreatedAt = source.CreatedAt;
        target.CreatedBy = source.CreatedBy;
        target.ModifiedAt = source.ModifiedAt;
        target.ModifiedBy = source.ModifiedBy;
    }
}