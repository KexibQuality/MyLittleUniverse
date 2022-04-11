using System;
using UnityEngine;


 
    public sealed class HealthPointsComponent: MonoBehaviour, IHealthPoints
    {
        public int HealthPoints
        {
            get { return this.healthPoints; }
        }

        public int AttackedHealthPoints
        {
            get
            {
                return (Math.Max(this.healthPoints - damage, 0));
            }
        }
       
        [Range(0,100)]
        [SerializeField] public int healthPoints;

        [SerializeField] public int damage;
    }
