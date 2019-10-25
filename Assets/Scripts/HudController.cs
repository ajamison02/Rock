﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public Text HungerText;
    public Text FriendshipText;
    public Text IsSickText;

    public GameObject Rock; 

    // Start is called before the first frame update
    void Start()
    {
        /* HungerText.text = "I'm hungry";
        FriendshipText.text = "Hello";
        IsSickText.text = "Healthy"; */ 
    }

    // Update is called once per frame
    void Update()
    {
       if (Rock != null)
        {
            HungerText.text = "Hunger: " + Rock.GetComponent<Rockcontroller>().hunger.ToString();
            FriendshipText.text = "Friendship: " + Rock.GetComponent<Rockcontroller>().friendship.ToString();
            IsSickText.text = "Is Sick: " + Rock.GetComponent<Rockcontroller>().isSick.ToString();
        }
       

    }

    public void FeedRock()
    {
        Rock.GetComponent<Rockcontroller>().hunger += 2;
    }

    public void PlayRock()
    {
        Rock.GetComponent<Rockcontroller>().friendship += 2;
    }

    public void VetRock()
    {
        Rock.GetComponent<Rockcontroller>().isSick = false; 
    }
}
