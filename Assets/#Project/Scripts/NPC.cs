using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class NPC : MonoBehaviour, IInteractable
{
    Greeter greeter = new();
    [SerializeField] Moods myMood;

    // Array pour mettre en ordre et pouvoir itérer
    Moods[] allMoods = new Moods[] {Moods.Happy, Moods.Hungry, Moods.Tired, Moods.Angry, Moods.Sad};

    int moodIndex;

    [SerializeField] CharacterStats stats;
    [SerializeField] NPCProfile profile;

    void Start()
    {
        myMood = profile.mood;
        stats = profile.stats;
        moodIndex = Array.FindIndex(allMoods, elem => elem == myMood);
    }
    public void Interact()
    {
        // throw new System.NotImplementedException();
        Debug.Log(greeter[myMood]); // on apelle l'indexeur myMood de Type Moods de l'instance greeter de Greeter
        if(moodIndex < allMoods.Length - 1)
        {
            moodIndex++;
            myMood = allMoods[moodIndex];
        }
    }
}
