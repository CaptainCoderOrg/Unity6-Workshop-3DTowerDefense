using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [field: SerializeField]
    public List<TileController> Tiles { get; private set; }
    [field: SerializeField]
    public TileController Selected { get; private set; }

    void Awake()
    {
        Tiles = GetComponentsInChildren<TileController>().ToList();
    }

}