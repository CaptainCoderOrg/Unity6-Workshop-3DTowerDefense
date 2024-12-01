using UnityEngine;

public class TurretAttack : MonoBehaviour
{
    [field: SerializeField]
    public AreaOfEngagement AoE { get; private set;}
    [field: SerializeField]
    public Projectile ProjectilePrefab { get; private set;}
    [field: SerializeField]
    public float CooldownTime { get; private set; } = 3;
    [field: SerializeField]
    public bool IsOnCooldown { get; private set; } = false;

    void Update()
    {
        if (IsOnCooldown) { return; }
        if (AoE.Targets.Count == 0) { return; }
        Fire();
        IsOnCooldown = true;
        Invoke(nameof(ResetCooldown), CooldownTime);
    }

    private void ResetCooldown() => IsOnCooldown = false;

    private void Fire()
    {
        Projectile newProjectile = Instantiate(ProjectilePrefab);
        // Sets the projectile's position to match the turret's position
        newProjectile.transform.position = transform.position;
        // Sets the projectile's target to the first target in the AoE
        newProjectile.Target = AoE.Targets[0].transform;
    }
}

