using UnityEngine;

namespace Entities
{
    [AddComponentMenu("Entities/Entity")]
    public sealed class MonoEntity : MonoBehaviour, IEntity, ISerializationCallbackReceiver
    {
        [SerializeField]
        private MonoBehaviour[] elements;

        private Entity entity;

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

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            this.entity = new Entity();
            for (int i = 0, count = this.elements.Length; i < count; i++)
            {
                var element = this.elements[i];
                this.entity.AddElement(element);
            }
        }

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }
    }
}