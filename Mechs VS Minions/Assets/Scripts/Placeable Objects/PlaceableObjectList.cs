using System.Collections.Generic;
using UnityEngine;

public static class PlaceableObjectList
{
    [SerializeField] private static List<GameObject> _placeableObjects = new List<GameObject>();

    public static int GetIndex(string name)
    {
        for (int i = 0; i < _placeableObjects.Count; i++)
        {
            if (_placeableObjects[i].name == name) return i;
        }
        return -1;
    }

    public static void Add(GameObject gameObject)
    {
        _placeableObjects.Add(gameObject);
    }
}
