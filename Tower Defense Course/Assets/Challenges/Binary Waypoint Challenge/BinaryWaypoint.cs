using UnityEditor;
using UnityEngine;

public class BinaryWaypoint : MonoBehaviour
{
    [field: SerializeField]
    public BinaryWaypoint First { get; private set; } 
    [field: SerializeField]
    public BinaryWaypoint Second { get; private set; } 

    void OnDrawGizmos()
    {
        if (First != null) 
        { 
            Handles.color = Color.red;
            Handles.DrawLine(transform.position, First.transform.position, 3f);
        }
        if (Second != null)
        {
            Handles.color = Color.yellow;
            Handles.DrawLine(transform.position, Second.transform.position, 3f);
        }
    }
}