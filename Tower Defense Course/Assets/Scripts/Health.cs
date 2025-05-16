using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [field: SerializeField]
    public float BaseHealth { get; private set; } = 2;
    [field: SerializeField]
    public float Damage { get; private set; }
    [field: SerializeField]
    public float DestroyDelay { get; private set; }
    private bool _destroyed = false;
    [field: SerializeField]
    public UnityEvent<Health> OnDeath { get; private set; }

    public void ApplyHit(Projectile projectile)
    {
        Damage += projectile.Damage;
        if (Damage >= BaseHealth)
        {
            OnDeath.Invoke(this);
            StartCoroutine(DestroyAfterDelay());
        }
    }

    private IEnumerator DestroyAfterDelay()
    {
        if (_destroyed) { yield break;  }
        _destroyed = true;
        yield return new WaitForSeconds(DestroyDelay);
        Object.Destroy(gameObject);
    }
}

