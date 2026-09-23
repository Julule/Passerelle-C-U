using UnityEngine;

public class GameStats
{
    public static int totalDamage = 0; 

    public static void PrintTotalDamage()
    {
        Debug.Log($"total damage of {totalDamage}");
    }
}
