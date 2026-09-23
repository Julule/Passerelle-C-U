using UnityEngine;

public class TurnRedOnDeath : DeathReaction
{
    Renderer myrenderer;


    protected override void Start()
    {
        base.Start();
        myrenderer = GetComponent<Renderer>();
    }

    protected override void Effect()
    {
        // throw new System.NotImplementedException();
        if(health.current <= 0) 
        {
            myrenderer.material.color = new Color(1.0f, 0f, 0f);
        }
    }
}