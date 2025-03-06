using System;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [field: SerializeField]
    public BuildingData Selected { get; set; }
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
        else if (Controller.Gold < Selected.Cost)
        {
            Controller.InfoLabel.text = "<color=red>Not Enough Gold</color>";
        }
        else
        {
            Controller.InfoLabel.text = $"{Selected.Cost} Gold - {Selected.Name}";
        }
    }

    public void SpawnTurret(TileController tileController)
    {
        if (!CanSpawn(tileController)) { return ;}
        tileController.IsOccupied = true;       
        GameObject newTurret = Instantiate(Selected.BuildingPrefab, Controller.transform);
        newTurret.transform.position = tileController.transform.position;
        Controller.Gold -= Selected.Cost;
        gameObject.SetActive(false);
    }

    private bool CanSpawn(TileController tileController)
    {
        return !tileController.IsOccupied && Controller.Gold >= Selected.Cost;
    }

}
