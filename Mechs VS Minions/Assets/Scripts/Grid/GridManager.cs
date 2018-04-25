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
}
