using UnityEngine;

public class TrophySystem : MonoBehaviour
{

    bool unlocked;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!unlocked && GameStats.totalDamage >= 50) 
        {
            unlocked = true;
            Debug.Log("TROPHY UNLOCKED !");
        }
        
    }
}
