using UnityEngine;

    public sealed class AttackComponent: MonoBehaviour, IAttackComponent

    {
        public void Attack()
        {
            Debug.Log("Attack!");
        }

    }