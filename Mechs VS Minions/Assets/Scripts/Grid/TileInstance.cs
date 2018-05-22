using UnityEngine;

public class TileInstance : MonoBehaviour {

    [HideInInspector] public int x, y;
    [HideInInspector] public GameObject connectedObject = null;

    private void OnMouseDown()
    {
        TileUI.Instance.SelectObject(gameObject);
    }
}
