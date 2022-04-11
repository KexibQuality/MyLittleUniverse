using Entities;
using UnityEngine;


public sealed class StatsController : MonoBehaviour
{
    [SerializeField] private MonoEntity player;

    public void Start()
    {
        var healthPointsComponent = this.player.Element<IHealthPoints>();
        
        Debug.Log($"HealthPoints {healthPointsComponent.HealthPoints}");

    }
}