using UnityEngine;

public class GoldGenerator : MonoBehaviour
{
    [field: SerializeField]
    public float Delay { get; private set; } = 2;
    [field: SerializeField]
    public int Gold { get; private set; } = 1;

    [field: SerializeField]
    public PlayerController Controller { get; private set; }
    void Awake()
    {
        Controller = GetComponentInParent<PlayerController>();
    }

    void OnEnable()
    {
        InvokeRepeating(nameof(GenerateGold), Delay, Delay);
    }

    void OnDisable()
    {
        CancelInvoke();
    }

    public void GenerateGold()
    {
        Controller.Gold += Gold;
    }

}

