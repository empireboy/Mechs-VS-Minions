using UnityEngine;

public class TileUI : MonoBehaviour
{
    private static TileUI _instance;
    public static TileUI Instance
    {
        get { return _instance; }
    }

    [SerializeField] private GameObject[] _placeableObjects;

    private GameObject _selectedObject = null;

    private void Awake()
    {
        if (_instance == null) _instance = this;
    }

    public void ConnectedObject(string name)
    {
        int index = PlaceableObjectList.GetIndex(name);
        GameObject placeableObject = Instantiate(_placeableObjects[index], _selectedObject.transform);
        placeableObject.transform.position = new Vector3(_selectedObject.transform.position.x, _selectedObject.transform.position.y + 1, _selectedObject.transform.position.z);
    }

    public void SelectedObject(GameObject selectedObject)
    {
        if (_selectedObject == null)
        {
            _selectedObject = selectedObject;
            GameObject panel = gameObject.transform.GetChild(0).gameObject;
            panel.SetActive(true);
            panel.transform.position = Camera.main.WorldToScreenPoint(new Vector3(_selectedObject.transform.position.x, _selectedObject.transform.position.y + 3, _selectedObject.transform.position.z));
        }
    }

    /*private int GetPlaceableObjectIndex(string name)
    {
        for (int i = 0; i < _placeableObjects.Length; i++)
        {
            if (_placeableObjects[i].name == name) return i;
        }
        return -1;
    }*/
}
