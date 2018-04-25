using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridManager))]
public class GridManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GridManager createTilesetScript = (GridManager)target;

        if (GUILayout.Button("Remove All Grids"))
        {
            createTilesetScript.RemoveAllGrids();
        }
    }
}