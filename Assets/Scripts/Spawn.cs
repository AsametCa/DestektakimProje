using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject mahsurS;
    [SerializeField] private Transform[] SpawnPoints;
    
    private int Score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mahsur"))
        {
            ScoreManager.instance.ChangeScore(1);
            spawnManager();
        }
    }
    public void spawnManager()
    {
        int index = Random.Range(0, SpawnPoints.Length);

        Instantiate(mahsurS, SpawnPoints[index].position, SpawnPoints[index].rotation);

    }
}
