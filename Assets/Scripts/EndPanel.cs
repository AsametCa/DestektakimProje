using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPanel : MonoBehaviour

{
    public static EndPanel instance;

    [SerializeField] private GameObject endPanel;
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void Son()
    {
        endPanel.SetActive(true);
        scoreText.SetText("Score : " + ScoreManager.instance.score);
    }

    public void Terkar()
    {
        Health.instance.health = 3;
        SceneManager.LoadScene(0);
        endPanel.SetActive(false);
    }
}
