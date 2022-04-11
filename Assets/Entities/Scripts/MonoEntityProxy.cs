using UnityEngine;

namespace Entities
{
    [AddComponentMenu("Entities/Entity Proxy")]
    public sealed class MonoEntityProxy : MonoBehaviour, IEntity
    {
        [SerializeField]
        private MonoEntity entity;
        
        public T Element<T>()
        {
            return this.entity.Element<T>();
        }

        public T[] Elements<T>()
        {
            return this.entity.Elements<T>();
        }

        public void AddElement(object element)
        {
            this.entity.AddElement(element);
        }

        public void RemoveElement(object element)
        {
            this.entity.RemoveElement(element);
        }

        public bool TryElement<T>(out T element)
        {
            return this.entity.TryElement(out element);
        }
    }
}