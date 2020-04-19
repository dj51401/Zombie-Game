using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    enum States { Spawning, Waiting, Countdown };

    public int wave = 0;
    public int count = 0;
    public int rate = 0;

    public Transform zombieSpawner;
    public GameObject zombie;

    private States state = States.Waiting;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case States.Waiting:
                state = States.Waiting;
                if(GameObject.Find("Zombie") != null)
                {
                    state = States.Waiting;
                }
                else
                {
                    state = States.Countdown;
                }
                break;

            case States.Countdown:
                state = States.Countdown;
                new WaitForSeconds(5f * Time.deltaTime);
                state = States.Spawning;
                break;

            case States.Spawning:
                state = States.Spawning;
                wave++;
                for(var i = 0; i < count; i++)
                {
                    //instantiate
                }
                state = States.Waiting;
                break;

        }
        Debug.Log(state);
    }

}
