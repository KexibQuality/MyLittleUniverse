using UnityEngine;

    public sealed class MoveComponent: MonoBehaviour , IMoveComponent
    {
        [SerializeField] private Transform moveTransform;

        [SerializeField] private float speed;

        public void Move(Vector3 direction)
        {
            this.moveTransform.position += direction * (Time.deltaTime * this.speed);

        }
    }
