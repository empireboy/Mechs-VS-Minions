using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileGenerator))]
public class TileGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        TileGenerator createTilesetScript = (TileGenerator)target;

        if (GUILayout.Button("Generate Tileset"))
        {
            createTilesetScript.GenerateTileset(createTilesetScript.width, createTilesetScript.height);
        }

        if (GUILayout.Button("Remove Tileset"))
        {
            createTilesetScript.RemoveTileset();
        }
    }
}