using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] private TMP_Text ScoreT;

    public int score;

    private void Awake()
    {
        instance = this;
    }

    public void ChangeScore(int value)
    {
        score += value;
        ScoreT.SetText("Score :" + score);

    }

}
