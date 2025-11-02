namespace Athlitix.Utilities.Mappers;

public abstract class BaseMapper<TEntity, TModel> : IMapper<TEntity, TModel>
    where TEntity : class, new()
    where TModel : class, new()
{
    public virtual TModel ToModel(TEntity entity)
    {
        if (entity == null) return null!;

        var model = new TModel();

        MapEntityToModel(entity, model);
        CommonMapping.CopyCommonProperties(model, entity);

        return model;
    }

    public virtual TEntity ToEntity(TModel model)
    {
        if (model == null) return null!;

        var entity = new TEntity();

        MapModelToEntity(model, entity);
        CommonMapping.CopyCommonProperties(entity, model);

        return entity;
    }

    /// <summary>
    /// Override this to map custom entity -> model properties.
    /// </summary>
    protected abstract void MapEntityToModel(TEntity entity, TModel model);

    /// <summary>
    /// Override this to map custom model -> entity properties.
    /// </summary>
    protected abstract void MapModelToEntity(TModel model, TEntity entity);
}