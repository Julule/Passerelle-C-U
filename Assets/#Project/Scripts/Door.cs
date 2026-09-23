using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    Vector3 originalPosition;
    Vector3 destination;

    void Start()
    {
        originalPosition = transform.position;
        destination = originalPosition;
    }
    void Update()
    {
        transform.position += (destination - transform.position) * 0.1f;
    }

    public void Interact()
    {
        destination += Vector3.up * 3f;
        // throw new System.NotImplementedException();
    }
}
