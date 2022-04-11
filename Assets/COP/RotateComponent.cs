using System.Runtime.CompilerServices;
using UnityEngine;

    public class RotateComponent: MonoBehaviour,IRotateComponent
    {
        [SerializeField] private Transform rotateTransform;
        [SerializeField] private float speed;

        public void Move()
        {
            this.rotateTransform.Rotate(0,0,1f) ;
        }
        
    }
