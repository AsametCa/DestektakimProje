using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health instance;
    public  int health = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        foreach( Image img in hearts)
        {
            img.sprite = emptyHeart;

        }
        for(int i =0 ; i< health ; i++)
        {
            hearts[i].sprite = fullHeart;
        }
        if (health <= 0)
        {
            EndPanel.instance.Son();
        }
    }

    

}
