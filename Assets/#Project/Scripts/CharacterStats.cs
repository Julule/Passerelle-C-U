using System;
using UnityEngine.Timeline;
[Serializable] 
// pour que Unity display les fields, alors qu'il ne le ferait pas normalement avec des struct ? int ?

public struct CharacterStats
{
    public int attack;
    public int defense;
    public int willpower;
    public int charisma;

}