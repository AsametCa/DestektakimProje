using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takip : MonoBehaviour
{
   
   
   

    private void OnTriggerEnter(Collider other)
    {
        
    
       
        if (other.CompareTag("Bitis"))
        {
            Destroy(gameObject);
            
           
        }
        if (other.CompareTag("kbaligi"))
        {
            Destroy(gameObject);
            EndPanel.instance.Son();
        }
    }
   
}
