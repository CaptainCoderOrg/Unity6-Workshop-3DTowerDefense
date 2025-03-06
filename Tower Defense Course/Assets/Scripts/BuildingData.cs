using UnityEngine;

[CreateAssetMenu(fileName = "BuildingData", menuName = "Scriptable Objects/BuildingData")]
public class BuildingData : ScriptableObject
{
    [field: SerializeField]
    public string Name { get; private set; }

    [field: SerializeField]
    public int Cost { get; private set; }

    [field: SerializeField]
    public GameObject BuildingPrefab { get; private set; }
}
