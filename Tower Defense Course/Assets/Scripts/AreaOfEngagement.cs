using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AreaOfEngagement : MonoBehaviour
{

    [field: SerializeField]
    public List<Health> Targets { get; private set; } = new();
    
    void OnTriggerEnter(Collider other)
    {
        Health targetHealth = other.GetComponentInParent<Health>();
        if (targetHealth == null) { return; }
        Targets.Add(targetHealth);
        targetHealth.OnDeath.AddListener(RemoveOnDeath);
    }

    void OnTriggerExit(Collider other)
    {
        Health targetHealth = other.GetComponentInParent<Health>();
        if (targetHealth == null) { return; }
        Targets.Remove(targetHealth);
        targetHealth.OnDeath.RemoveListener(RemoveOnDeath);
    }

    private void RemoveOnDeath(Health targetHealth)
    {
        Targets.Remove(targetHealth);
    }
}