namespace _2DPlatformer
{
    public interface IEntity
    {
        T Get<T>();

        bool TryGet<T>(out T element);
    }
}