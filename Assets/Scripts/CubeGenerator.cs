using System.Collections;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Vector3 _step;
    [SerializeField] private float _spawnDelay;

    public void CreateCubes(int count)
    {
        StartCoroutine(CreateCubesCoroutine(count));
    }

    private IEnumerator CreateCubesCoroutine(int count)
    {
        var position = transform.position;
        
        for (var i = 0; i < count; i++)
        {
            Instantiate(_cubePrefab, position, Quaternion.identity);
            position += _step;
            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}
