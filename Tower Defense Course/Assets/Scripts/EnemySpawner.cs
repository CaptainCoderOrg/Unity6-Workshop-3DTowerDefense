using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [field: SerializeField]
    public EnemyMovement Enemy { get; private set; } 
    [field: SerializeField]
    public Waypoint StartingWaypoint { get; private set; }
    [field: SerializeField]
    public float Delay { get; private set; } = 5f;
    [field: SerializeField]
    public int SpawnsRemaining { get; private set; } = 5;

    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), Delay, Delay);
    }
    
    void OnDisable()
    {
        CancelInvoke();
    }

    public void Spawn()
    {
        EnemyMovement newEnemy = Object.Instantiate(Enemy);
        newEnemy.Target = StartingWaypoint;
        SpawnsRemaining--;
        if (SpawnsRemaining == 0)
        {
            CancelInvoke();
        }
    }
}


