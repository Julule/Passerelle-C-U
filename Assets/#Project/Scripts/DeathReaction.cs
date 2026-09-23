using UnityEngine;
[RequireComponent(typeof(Health))] // Unity va refuser qu'il existe sur un Object sans le compo Health

public abstract class DeathReaction : MonoBehaviour
{
    protected Health health;

    protected virtual void Start()
    {
        health = GetComponent<Health>();
        health.onHealthChanged += React;
    }

    void React()
    {
        if (health.current <= 0) Effect();
    }
    protected abstract void Effect();

}
