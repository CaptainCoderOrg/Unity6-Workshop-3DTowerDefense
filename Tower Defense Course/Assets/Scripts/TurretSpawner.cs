using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    [field: SerializeField]
    public GameObject TurretPrefab { get; private set; }
    [field: SerializeField]
    public GameObject TargetGrid { get; private set; }


    void OnEnable()
    {
        ListenToTilesIn(TargetGrid);
    }

    void OnDisable()
    {
        StopListeningToTilesIn(TargetGrid);
    }

    public void ListenToTilesIn(GameObject grid)
    {
        foreach (TileController tile in grid.GetComponentsInChildren<TileController>())
        {
            tile.OnCursorClick.AddListener(SpawnTurret);
            
        }
    }

    public void StopListeningToTilesIn(GameObject grid)
    {
        foreach (TileController tile in grid.GetComponentsInChildren<TileController>())
        {
            tile.OnCursorClick.RemoveListener(SpawnTurret);
        }
    }

    public void SpawnTurret(TileController tileController)
    {
        if (tileController.IsOccupied) { return ;}
        tileController.IsOccupied = true;
        GameObject newTurret = Instantiate(TurretPrefab);
        newTurret.transform.position = tileController.transform.position;
    }

}
