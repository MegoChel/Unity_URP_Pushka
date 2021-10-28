using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShip : MonoBehaviour
{

    public GameObject Ship;
    public GameObject SpawnPoint;
    // Start is called before the first frame update

    private float rnd;
    private float timeRemaining;
    void Start()
    {
        timeRemaining = Random.Range(5, 15);


    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Spawn(float time)
    {
        Vector3 rndSpawnPoint = SpawnPoint.transform.position + new Vector3(0, 0, 1) * Random.Range(-50, 100);
        GameObject intantiateObject = Instantiate(Ship, rndSpawnPoint, Quaternion.LookRotation(transform.right));
        intantiateObject.GetComponent<MoveShip>().MoveTime = time - Random.Range(5, 10);
        GameObject gm = GameObject.Find("GameMode");
        intantiateObject.GetComponent<Score>().GameMode = gm;
    }


    private bool timerIsRunning = true;
    //private float timeRemaining = 15; 
    void Timer()
    {
        if (timerIsRunning)
        {
            Debug.Log(timeRemaining);
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = Random.Range(15, 30);

                Spawn(timeRemaining);
                //timerIsRunning = false;
            }
        }
    }
}

