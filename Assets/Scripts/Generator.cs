using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    Main main;
    float timer = 1;
    public GameObject[] gm;
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Scripts").GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0 && main.GameOver == false)
        {
            int chance = Random.Range(1, 101);
            float pos_x =  Random.Range(-35.0f, 35.0f);

            if (chance <= 20)
            {
                Instantiate(gm[1], new Vector3(pos_x, 20.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            else
            {
                Instantiate(gm[0], new Vector3(pos_x, 20.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            timer = 0.7f;
        }
        else 
        {
            Console.WriteLine("Game Ended");
        }
    }
}
