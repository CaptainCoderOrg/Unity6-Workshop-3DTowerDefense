using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AreaOfEngagement : MonoBehaviour
{

    [field: SerializeField]
    public List<Transform> Targets { get; private set; } = new();
    
    void OnTriggerEnter(Collider other)
    {
        Targets.Add(other.transform);
    }

    void OnTriggerExit(Collider other)
    {
        Targets.Remove(other.transform);
    }
}