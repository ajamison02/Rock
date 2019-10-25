using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockcontroller : MonoBehaviour
{


    public string RockName = "Rochtholomeu";
    public float hunger = 100f;
    public float friendship = 100f;
    public bool isSick = false;

    float hungerScale = 2f;
    float friendshipScale = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RockName);
    }

    // Update is called once per frame
    void Update()
    {
        StatusUpdate();
        IsDead();
        
    }

    void StatusUpdate()
    {
        hunger -= Time.deltaTime * hungerScale;
        friendship -= Time.deltaTime * friendshipScale;

        int sickChance = Random.Range(0, 100);
        if (sickChance == 1)
        {
            isSick = true;
            
        }

        if (isSick == false)
        {
            hungerScale = 2f;
            friendshipScale = 2f;
        }
        else
        {
            hungerScale = 20f;
            friendshipScale = 20f;
        }
    }

    void IsDead()
    {
        if (hunger <= 0)
        {
            Destroy(gameObject);
        }
        else if (friendship <= 0)
        {
            Destroy(gameObject);
        }
    }
}
