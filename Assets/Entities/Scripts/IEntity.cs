namespace Entities
{
    public interface IEntity
    {
        T Element<T>();

        T[] Elements<T>();

        void AddElement(object element);

        void RemoveElement(object element);

        bool TryElement<T>(out T element);
    }
}