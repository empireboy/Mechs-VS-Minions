using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private static GridManager _instance;
    public static GridManager Instance
    {
        get { return _instance; }
    }

    [HideInInspector] public List<GameObject> gridArray = new List<GameObject>();

    private GameObject _selectedObject = null;

    public GameObject SelectedObject { get; set; }

    private void Awake()
    {
        if (_instance == null) _instance = this;
    }

    public void RemoveAllGrids()
    {
        int gridCount = gridArray.Count;
        for (int i = 0; i < gridCount; i++)
        {
            DestroyImmediate(gridArray[i]);
        }
        gridArray.Clear();
    }

    public bool CanMove(GameObject currentTile, Enums.direction dir)
    {
        GameObject currentGrid = currentTile.transform.parent.gameObject;
        GridInstance gridInstance = currentGrid.GetComponent<GridInstance>();
        TileInstance tileInstance = currentTile.GetComponent<TileInstance>();
        GameObject[,] tileArray = gridInstance._tileArray;
        GameObject tileNext = null;

        switch (dir)
        {
            case Enums.direction.left:
                tileNext = tileArray[tileInstance.x - 1, tileInstance.y];
                break;
            case Enums.direction.right:
                tileNext = tileArray[tileInstance.x + 1, tileInstance.y];
                break;
            case Enums.direction.up:
                tileNext = tileArray[tileInstance.x, tileInstance.y + 1];
                break;
            case Enums.direction.down:
                tileNext = tileArray[tileInstance.x, tileInstance.y - 1];
                break;
        }

        if (tileNext != null && tileNext.tag != "Obstacle" && tileNext.GetComponent<TileInstance>().connectedObject.tag != "Obstacle")
        {
            return true;
        }

        return false;
    }

    public void CreatePlaceableObject(string objectName, GameObject tile)
    {
        int index = PlaceableObjectList.GetIndex(objectName);
        GameObject placeableObject = Instantiate(PlaceableObjectList.Get(index), tile.transform);
        placeableObject.transform.position = new Vector3(
            tile.transform.position.x,
            tile.transform.position.y + 1,
            tile.transform.position.z
        );
    }
}
