using UnityEngine;
using UnityEngine.Events;

public class TowerController : MonoBehaviour
{

    [field: SerializeField]
    public float BaseHealth { get; private set; }
    [field: SerializeField]
    public float Damage { get; private set; }
    [field: SerializeField]
    public UnityEvent<TowerController> OnDestroyed { get; private set; }

    public void ApplyHit(EnemyAttack attack)
    {
        Damage += attack.Damage;
        Destroy(attack.gameObject);
        if (Damage >= BaseHealth)
        {
            Destroy(gameObject);
            OnDestroyed.Invoke(this);
        }
    }

}
