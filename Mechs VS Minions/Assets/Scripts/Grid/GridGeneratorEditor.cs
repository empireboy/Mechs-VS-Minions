using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridGenerator))]
public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GridGenerator createGridScript = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            createGridScript.GenerateGrid();
        }
    }
}