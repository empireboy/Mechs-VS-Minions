using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridCreate))]
public class GridCreateEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GridCreate createGridScript = (GridCreate)target;
        if (GUILayout.Button("Generate Grid"))
        {
            createGridScript.GenerateGrid();
        }
    }
}