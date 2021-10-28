using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    [SerializeField]
    private GameObject HUD;

    private int TotalScores;

    public void setTotalScores(int value)
    {
        TotalScores += value;
        HUD.GetComponent<TextMeshPro>().text = "Score: " + TotalScores;
        Debug.Log("Scores: " + TotalScores);
    }

}
