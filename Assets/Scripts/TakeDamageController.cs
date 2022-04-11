using System;
using UnityEngine;
using Entities;

public sealed class TakeDamageController: MonoBehaviour
{
    [SerializeField] private MonoEntity player;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            var attackedHealthPointsComponent = this.player.Element<IHealthPoints>();
            Debug.Log($"HealthPoints {attackedHealthPointsComponent.AttackedHealthPoints}");
        }
    }

    }