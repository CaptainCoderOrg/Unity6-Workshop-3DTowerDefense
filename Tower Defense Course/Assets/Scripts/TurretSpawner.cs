using System;
using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    [field: SerializeField]
    public GameObject TurretPrefab { get; set; }
    [field: SerializeField]
    public GameObject TargetGrid { get; private set; }
    [field: SerializeField]
    public PlayerController Controller { get; private set; }


    void OnEnable()
    {
        Controller.InfoLabel.text = "Select a Tile";
        ListenToTilesIn(TargetGrid);
    }

    void OnDisable()
    {
        Controller.InfoLabel.text = string.Empty;
        StopListeningToTilesIn(TargetGrid);
    }

    public void ListenToTilesIn(GameObject grid)
    {
        foreach (TileController tile in grid.GetComponentsInChildren<TileController>())
        {
            tile.OnCursorClick.AddListener(SpawnTurret);
            tile.OnCursorEnter.AddListener(ShowInfo);
            tile.OnCursorExit.AddListener(SelectTileMessage);
        }
    }

    private void SelectTileMessage(TileController arg0)
    {
        Controller.InfoLabel.text = "Select a Tile";
    }

    public void StopListeningToTilesIn(GameObject grid)
    {
        foreach (TileController tile in grid.GetComponentsInChildren<TileController>())
        {
            tile.OnCursorClick.RemoveListener(SpawnTurret);
            tile.OnCursorEnter.RemoveListener(ShowInfo);
            tile.OnCursorExit.RemoveListener(SelectTileMessage);
        }
    }

    public void ShowInfo(TileController tileController)
    {
        if (tileController.IsOccupied)
        {
            Controller.InfoLabel.text = "Cannot build here";
        }
        else if (Controller.Gold < 50)
        {
            Controller.InfoLabel.text = "<color=red>Not Enough Gold</color>";
        }
        else
        {
            Controller.InfoLabel.text = "50 Gold - Place Turret";
        }
    }

    public void SpawnTurret(TileController tileController)
    {
        if (!CanSpawn(tileController)) { return ;}
        tileController.IsOccupied = true;
        GameObject newTurret = Instantiate(TurretPrefab, Controller.transform);
        newTurret.transform.position = tileController.transform.position;
        Controller.Gold -= 50;
        gameObject.SetActive(false);
    }

    private bool CanSpawn(TileController tileController)
    {
        return !tileController.IsOccupied && Controller.Gold >= 50;
    }

}
