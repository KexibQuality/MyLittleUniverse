using UnityEngine;

namespace Entities
{
    public abstract class EntityCondition : ScriptableObject
    {
        public abstract bool IsTrue(IEntity entity);
    }
}