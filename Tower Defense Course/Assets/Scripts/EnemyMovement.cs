using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [field: SerializeField]
    public float Speed { get; private set; } = 1f;
    [field: SerializeField]
    public Waypoint Target { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Target.transform.position;
        transform.LookAt(Target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Target == null) { return; }
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * Speed);
        float distance = Vector3.Distance(transform.position, Target.transform.position);

        if (distance <= Mathf.Epsilon)
        {
            Target = Target.Next;
            if (Target != null)
            {
                transform.LookAt(Target.transform);
            }
        }
    }
}
