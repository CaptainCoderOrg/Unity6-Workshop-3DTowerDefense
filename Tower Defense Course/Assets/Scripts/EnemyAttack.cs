using UnityEngine;
using UnityEngine.Events;

public class EnemyAttack : MonoBehaviour
{
    [field: SerializeField]
    public int Damage { get; private set; }
    [field: SerializeField]
    public UnityEvent OnEnemyAttackedAndDestroyed { get; private set; }
}