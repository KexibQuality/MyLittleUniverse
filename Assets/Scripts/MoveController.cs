using System;
using Entities;
using UnityEngine;


    public sealed class MoveController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;

        private IMoveComponent moveComponent;

        private void Start()
        {
            this.moveComponent = this.player.Element<IMoveComponent>();
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.moveComponent.Move(new Vector3(0, 0, 1.0f));
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.moveComponent.Move(new Vector3(0, 0, -1.0f));
            }
        }
    }
