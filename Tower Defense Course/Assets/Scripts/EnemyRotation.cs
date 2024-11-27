using System.Numerics;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    [field: SerializeField]
    public float RotationSpeed { get; private set; } = 1f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new UnityEngine.Vector3(0, RotationSpeed, 0) * Time.deltaTime);
    }
}
