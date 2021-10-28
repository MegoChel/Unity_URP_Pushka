using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject GameMode;

    [SerializeField]
    private int Value = 1;

    private bool destroyed = false;
    private float timeRemaining = 5;
    private void OnCollisionEnter(Collision collision)
    {
        GameMode.GetComponent<ScoreManager>().setTotalScores(Value);
        Destroy(gameObject.GetComponent<MoveShip>());     //
        Destroy(collision.gameObject);                    //
        gameObject.AddComponent<Rigidbody>();             //Вынести в отдельный класс
        //rb.useGravity = true;                           //
        destroyed = true;                                 //
    }

    private void Update()
    {
        if (destroyed)
        {

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
                destroyed = false;
            }
        }
    }

}
