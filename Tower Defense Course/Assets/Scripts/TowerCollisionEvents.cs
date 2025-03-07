using UnityEngine;
using UnityEngine.Events;

public class TowerCollisionEvents : MonoBehaviour
{

    [field: SerializeField]
    public UnityEvent<EnemyAttack> OnEnemyHit { get; private set; }

    void OnTriggerEnter(Collider other)
    {
        EnemyAttack enemyAttack = other.GetComponentInParent<EnemyAttack>();
        if (enemyAttack == null) { return; }
        OnEnemyHit.Invoke(enemyAttack);
    }
}