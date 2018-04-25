using UnityEngine;

[RequireComponent(typeof(GridManager))]
public class GridGenerator : MonoBehaviour
{
    [SerializeField] private int width = 5;
    [SerializeField] private int height = 5;
    [SerializeField] private GameObject _grid;

    public void GenerateGrid()
    {
        GameObject grid = Instantiate(_grid);
        grid.name = "Grid Instance";
        grid.GetComponent<TileGenerator>().GenerateTileset(width, height);

        GetComponent<GridManager>().gridArray.Add(grid);
    }
}
