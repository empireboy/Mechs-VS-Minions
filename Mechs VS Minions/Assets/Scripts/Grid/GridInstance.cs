using System.Collections.Generic;
using UnityEngine;

public class GridInstance : MonoBehaviour
{
    [HideInInspector] public GameObject[,] _tileArray;

    [SerializeField] private bool _debug = false;

    public void NewTileset(int width, int height)
    {
        _tileArray = new GameObject[width, height];
    }

    public void AddTile(int i, int j, GameObject tile)
    {
        _tileArray[i, j] = tile;
        if (_debug) Debug.Log("Tile added: " + _tileArray[i, j]);
    }
}
