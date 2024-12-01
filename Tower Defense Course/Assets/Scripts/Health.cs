using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [field: SerializeField]
    public float BaseHealth { get; private set; } = 2;
    [field: SerializeField]
    public float Damage { get; private set; }
    [field: SerializeField]
    public UnityEvent<Health> OnDeath { get; private set; }
    
    public void ApplyHit(Projectile projectile)
    {
        Damage += projectile.Damage;
        if (Damage >= BaseHealth)
        {
            OnDeath.Invoke(this);
            Object.Destroy(gameObject);
        }
    }
}

