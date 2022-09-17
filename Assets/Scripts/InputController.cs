using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class InputController : MonoBehaviour
{
    [SerializeField] private CubeGenerator _generator;

    private InputField _input;

    private void Awake()
    {
        _input = GetComponent<InputField>();
        _input.onEndEdit.AddListener(_ => CreateCubes());
    }

    public void CreateCubes()
    {
        if (int.TryParse(_input.text, out var count))
            _generator.CreateCubes(count);
    }
}
