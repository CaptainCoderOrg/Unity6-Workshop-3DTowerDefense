using UnityEngine;

public class TileCursor : MonoBehaviour
{
    [field: SerializeField]
    public GameObject TargetGrid { get; private set; }
    [field: SerializeField]
    public GameObject Model { get; private set; }

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
            tile.OnCursorEnter.AddListener(HandleTileEntered);
            tile.OnCursorExit.AddListener(HandleTileExited);
        }
    }

    public void StopListeningToTilesIn(GameObject grid)
    {
        foreach (TileController tile in grid.GetComponentsInChildren<TileController>())
        {
            tile.OnCursorEnter.RemoveListener(HandleTileEntered);
            tile.OnCursorExit.RemoveListener(HandleTileExited);
        }
    }

    public void HandleTileEntered(TileController tile)
    {
        transform.position = tile.transform.position;
        Model.SetActive(true);
    }

    public void HandleTileExited(TileController tile)
    {
        Model.SetActive(false);
    }

}