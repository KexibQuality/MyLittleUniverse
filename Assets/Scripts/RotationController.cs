
using Entities;
    using UnityEngine;

    public sealed class RotationController: MonoBehaviour
    { 
        [SerializeField] private MonoEntity player;

        private IRotateComponent rotationComponent;

        private void Start()
        {
            this.rotationComponent = this.player.Element<IRotateComponent>();
        }


        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.rotationComponent.Move();
            }

        }

    }