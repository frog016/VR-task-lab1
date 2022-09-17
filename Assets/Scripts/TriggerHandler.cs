using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        Debug.Log($"{name} collided with {otherCollider.name}.");
        otherCollider.GetComponent<ColorChanger>()?.ChangeColor();
    }

    private void OnTriggerExit(Collider otherCollider)
    {
        Debug.Log($"{name} collided with {otherCollider.name}.");
        otherCollider.GetComponent<ColorChanger>()?.ReturnInitialColor();
    }
}
