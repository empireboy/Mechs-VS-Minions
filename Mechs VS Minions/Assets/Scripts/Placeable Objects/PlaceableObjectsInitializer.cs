using UnityEngine;

public class PlaceableObjectsInitializer : MonoBehaviour
{
    [SerializeField] private GameObject[] _placeableObjects;

    private void Awake()
    {
        for (int i = 0; i < _placeableObjects.Length; i++)
        {
            PlaceableObjectList.Add(_placeableObjects[i]);
        }
    }
}
