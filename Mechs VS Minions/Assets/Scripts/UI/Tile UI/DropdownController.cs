using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class DropdownController : MonoBehaviour
{
    private Dropdown _dropdown;

    private void Awake()
    {
        _dropdown = GetComponent<Dropdown>();
    }

    public void OnValueChange()
    {
        int value = _dropdown.value;
        string instanceName = _dropdown.options[value].text;
        TileUI.Instance.ConnectedObject(instanceName);
    }

    public void Reset()
    {
        _dropdown.value = 0;
    }
}
