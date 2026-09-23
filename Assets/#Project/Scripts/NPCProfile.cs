using UnityEngine;
using UnityEngine.TextCore.Text;

[CreateAssetMenu(fileName = "NPCProfile", menuName = "IF3 FTW/NPCProfile")]
public class NPCProfile : ScriptableObject
{
    public Moods mood;
    public CharacterStats stats;
}
