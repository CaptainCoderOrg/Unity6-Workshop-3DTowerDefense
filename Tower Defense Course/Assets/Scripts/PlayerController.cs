using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    public int Gold { get; set; }
    [field: SerializeField]
    public TextMeshProUGUI InfoLabel { get; private set; }

    void Start()
    {
        InfoLabel.text = "Click Build to Place a Turret";   
    }
}