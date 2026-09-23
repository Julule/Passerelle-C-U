using UnityEngine;

public class DestroyOnDeath : DeathReaction
{


    protected override void Effect()
    {
        Destroy(gameObject);
    }
}
