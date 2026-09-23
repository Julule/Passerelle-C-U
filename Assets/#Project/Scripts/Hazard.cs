using UnityEngine;

public class Hazard : MonoBehaviour
{

    [SerializeField] int damage;
    

    void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.current -= damage;
            GameStats.totalDamage += damage;
            Debug.Log(GameStats.totalDamage);
            GameStats.PrintTotalDamage();
        }

        // Alternative :
        // Health health;
        // if (other.TryGetComponent<Health>(out health))

    }
}
