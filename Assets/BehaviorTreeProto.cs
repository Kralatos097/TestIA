using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTreeProto : MonoBehaviour
{
    private bool _isThirsty = false;
    private bool _isDead = false;
    
    public float MaxThirst = 10;
    private float _thirst;

    private float Thirst
    {
        get => _thirst;

        set
        {
            _thirst = value;
            if (_thirst <= 0)
            {
                _thirst = 0;
                _isDead = true;
            }
            else if(_thirst <= MaxThirst/2)
            {
                _isThirsty = true;
            }
            else if (_thirst >= MaxThirst/2)
            {
                _isThirsty = false;
            }
            else if (_thirst >= MaxThirst)
            {
                _thirst = MaxThirst;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Thirst -= Time.deltaTime;
        
        if (_isThirsty)
        {
            if (NearWater())
            {
                Drink();
            }
            else
            {
                SearchWater();
            }
        }
        else
        {
            Wait();
        }
    }

    private void SearchWater()
    {
        
    }
    
    private void Drink()
    {
        
    }
    
    private bool NearWater()
    {
        return false;
    }
    
    private void Wait()
    {
        
    }
}
