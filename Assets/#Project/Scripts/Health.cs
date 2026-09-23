using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _current; 
    // Health will be affected by itself only
    [SerializeField] int _maximum; 

    public Action onHealthChanged;

    public int maximum
    {
            get 
            {
                return _maximum;
            }
            // pour faire un équivalenbt de 'lecture seule'
            private set 
            {
                _maximum = value;
            }
    }

    
    public int current
    {
            get 
            {
                return _current;
            }
            // pour faire un équivalenbt de 'lecture seule'
            set 
            {
                if(value<0) value = 0;
                if(value > maximum) value = _maximum;
                if (value != _current)
                {
                    _current = value;
                    onHealthChanged?.Invoke();    
                }

            }
    }
    
    void Awake()
    {
        _current = _maximum;
    }


    public int GetMaximum(){
        return _maximum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
