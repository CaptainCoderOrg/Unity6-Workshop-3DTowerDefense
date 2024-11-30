using UnityEngine;

public class Health : MonoBehaviour
{
    [field: SerializeField]
    public float BaseHealth { get; private set; } = 2;
    [field: SerializeField]
    public float Damage { get; private set; }
    
    public void ApplyHit(Projectile projectile)
    {
        Damage += projectile.Damage;
        if (Damage >= BaseHealth)
        {
            Object.Destroy(gameObject);
        }
    }
}

