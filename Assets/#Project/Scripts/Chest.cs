using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] int gold;

    public void Interact()
    {
        // throw new System.NotImplementedException();
        Debug.Log($"You won {gold} gold !");
    }
}
