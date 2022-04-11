using Entities;
using UnityEngine;

    public sealed class AttackController: MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        
        public void Update()
        {
            if (Input.GetMouseButtonDown(button: 0))
            {
                var attackComponent = this.player.Element<IAttackComponent>();
                attackComponent.Attack();
            }
        }


    }
