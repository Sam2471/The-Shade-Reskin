﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    public bool Canopen = false;
    public static bool test = false;
    public bool testistrue = false;

    public Door door;
    public Collider doortrigger;

    public void OnTriggerEnter(Collider doortrigger)
    {
        if (doortrigger.CompareTag("Player"))
        {
            Canopen = true;
        }       
    }

    public void OnTriggerExit(Collider doortrigger)
    {
        if (doortrigger.CompareTag("Player"))
        {
            Canopen = false;
        }
            
    } 
        private void Update()
    {
        if (Canopen == true)
        {
            door.canopen = true;
            //Door.open = !Door.open;
            if (test == true)
            {
                testistrue = true;
            }

        }
        else
        {
            door.canopen = false;
        }
    }
}
