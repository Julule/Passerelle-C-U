using System.Collections.Generic;
using UnityEngine.Rendering;
public class Greeter
{
    Dictionary<Moods, string> greetings = new()
    {
        {Moods.Happy, "hey hey, hello frieeeeeend !!"},
        {Moods.Angry, "Get Lost, I'm Angry"},
        {Moods.Sad, "Welcome, I guess..."},
    };
    string defaultGreeting = "Hello!";

    // ici on crée un indexeur, une donnée accessible comme un index de la classe.
    public string this[Moods mood]
    {
        get
        {
            if (greetings.ContainsKey(mood))
                {
                return greetings[mood];
                }
            return defaultGreeting;
        }
    }

}