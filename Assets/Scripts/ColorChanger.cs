using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _newColor;

    private Color _initialColor;
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
        _initialColor = _material.color;
    }

    public void ChangeColor() => _material.color = _newColor;

    public void ReturnInitialColor() => _material.color = _initialColor;
}
