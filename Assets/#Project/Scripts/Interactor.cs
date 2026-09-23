using UnityEngine;

public class Interactor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // on doit 
        IInteractable interactable = other.GetComponent<IInteractable>(); // on récupère le IInteractable de l'objet
        // on vérifie s'il est interactable. 
        interactable?.Interact(); // puis, déclenchement de l'intercation adaptée à l'objet
    }
}