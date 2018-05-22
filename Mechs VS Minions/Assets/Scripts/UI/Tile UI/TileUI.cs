using UnityEngine;

public class TileUI : MonoBehaviour
{
    private static TileUI _instance;
    public static TileUI Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance == null) _instance = this;
    }

    public void ConnectedObject(string objectName)
    {
        GridManager.Instance.CreatePlaceableObject(objectName);
    }

    public void SelectObject(GameObject selectedObject)
    {
        if (GridManager.Instance.SelectedObject == null)
        {
            GridManager.Instance.SelectedObject = selectedObject;
            GameObject panel = gameObject.transform.GetChild(0).gameObject;
            panel.SetActive(true);
            panel.transform.position = Camera.main.WorldToScreenPoint(
                new Vector3(
                    GridManager.Instance.SelectedObject.transform.position.x,
                    GridManager.Instance.SelectedObject.transform.position.y + 3,
                    GridManager.Instance.SelectedObject.transform.position.z
                )
            );
        }
    }

    public void Close()
    {
        if (GridManager.Instance.SelectedObject != null)
        {
            GridManager.Instance.SelectedObject = null;
            GameObject panel = gameObject.transform.GetChild(0).gameObject;
            panel.SetActive(false);
        }
    }
}
