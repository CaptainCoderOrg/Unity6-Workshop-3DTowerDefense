using TMPro;
using UnityEngine;

public class GoldLabelController : MonoBehaviour
{
    [field: SerializeField]
    public PlayerController Controller { get; private set; }
    [field: SerializeField]
    public TextMeshProUGUI Label { get; private set; }

    void Update()
    {
        Label.text = $"Gold: {Controller.Gold}";
    }
}

