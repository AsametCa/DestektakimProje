using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kbaligi : MonoBehaviour
{
    public float hiz = 10;
    private void Update()
    {
        if (transform.position.z > 20)
        {
            hiz = -hiz;
        }
         else if (transform.position.z< -20)
        {
            hiz = -hiz;
        }
        transform.position += new Vector3(0, 0, hiz * Time.deltaTime);
    }
}
