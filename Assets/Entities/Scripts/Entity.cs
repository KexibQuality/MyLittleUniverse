using System;
using System.Collections.Generic;

namespace Entities
{
    public class Entity : IEntity
    {
        private readonly List<object> elements;

        public Entity()
        {
            this.elements = new List<object>();
        }

        public Entity(IEnumerable<object> elements)
        {
            this.elements = new List<object>(elements);
        }

        public Entity(params object[] elements)
        {
            this.elements = new List<object>(elements);
        }

        public T Element<T>()
        {
            for (int i = 0, count = this.elements.Count; i < count; i++)
            {
                if (this.elements[i] is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Element of type {typeof(T).Name} is not found!");
        }

        public T[] Elements<T>()
        {
            var result = new List<T>();
            for (int i = 0, count = this.elements.Count; i < count; i++)
            {
                if (this.elements[i] is T element)
                {
                    result.Add(element);
                }
            }

            return result.ToArray();
        }

        public void AddElement(object element)
        {
            this.elements.Add(element);
        }

        public void RemoveElement(object element)
        {
            this.elements.Remove(element);
        }

        public bool TryElement<T>(out T element)
        {
            for (int i = 0, count = this.elements.Count; i < count; i++)
            {
                if (this.elements[i] is T result)
                {
                    element = result;
                    return true;
                }
            }

            element = default;
            return false;
        }
    }
}