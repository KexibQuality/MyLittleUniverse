using System;
using UnityEngine;

namespace Entities
{
    [CreateAssetMenu(
        fileName = "EntityConditionGroup",
        menuName = "GameEngine/Conditions/New Entity Condition \"Group\""
    )]
    public sealed class EntityConditionGroup : EntityCondition
    {
        [SerializeField]
        private Mode mode;

        [SerializeField]
        private EntityCondition[] conditions;
        
        public override bool IsTrue(IEntity entity)
        {
            return this.mode switch
            {
                Mode.AND => this.All(entity),
                Mode.OR => this.Any(entity),
                _ => throw new Exception($"Mode is undefined {this.mode}")
            };
        }

        private bool All(IEntity entity)
        {
            for (int i = 0, count = this.conditions.Length; i < count; i++)
            {
                var condition = this.conditions[i];
                if (!condition.IsTrue(entity))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Any(IEntity entity)
        {
            for (int i = 0, count = this.conditions.Length; i < count; i++)
            {
                var condition = this.conditions[i];
                if (condition.IsTrue(entity))
                {
                    return true;
                }
            }

            return false;
        }

        [Serializable]
        private enum Mode
        {
            AND,
            OR
        }
    }
}