using UnityEngine;

public class GridCreate : MonoBehaviour {

    [SerializeField] private int _gridWidth = 5;
    [SerializeField] private int _gridHeight = 5;
    [SerializeField] private GameObject _tile;
	
    public void GenerateGrid()
    {
        //RemoveGrid();
        CreateGrid();
    }

	private void CreateGrid()
    {
        GameObject parent = new GameObject("Grid");

        for (int i = 0; i < _gridWidth; i++)
        {
            for (int j = 0; j < _gridHeight; j++)
            {
                GameObject tile = Instantiate(_tile, parent.transform);
                tile.name = "Tile [" + i + "," + j + "]";
                tile.transform.position = new Vector3(i, 0, j);
            }
        }
    }

    /*private void RemoveGrid()
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }*/
}
