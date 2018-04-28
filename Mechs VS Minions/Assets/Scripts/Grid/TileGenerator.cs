using UnityEngine;

[RequireComponent(typeof(GridInstance))]
public class TileGenerator : MonoBehaviour
{
    [SerializeField] public int width = 5;
    [SerializeField] public int height = 5;
    [SerializeField] private GameObject _tile;

    private GridInstance _gridInstance;

    public void GenerateTileset(int width, int height)
    {
        RemoveTileset();

        _gridInstance = GetComponent<GridInstance>();

        _gridInstance.NewTileset(width, height);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject tile = Instantiate(_tile, gameObject.transform);
                TileInstance tileInstance = tile.GetComponent<TileInstance>();
                tileInstance.x = i;
                tileInstance.y = j;
                tile.name = "Tile [" + i + "," + j + "]";
                tile.transform.position = new Vector3(gameObject.transform.position.x + i, 0, gameObject.transform.position.z + j);
                _gridInstance.AddTile(i, j, tile);
            }
        }
    }

    public void RemoveTileset()
    {
        int tileCount = transform.childCount;
        for (int i = 0; i < tileCount; i++)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
}
