using UnityEngine;

public class HealthBar : MonoBehaviour
{

    [SerializeField] float maximumSize;
    [SerializeField] Health health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    UpdateSize();
    health.onHealthChanged += UpdateSize; // j'ajoute la fonction elle-même dans le deleguate, pas son output ( = pas de parenthèses).
    }

    // Update is called once per frame
    void UpdateSize()
    {
        float t = (float) health.current / health.maximum;
        float scale = Mathf.Lerp(0, maximumSize, t);
        transform.localScale = new Vector3(scale, 1, 1);
    }
}
