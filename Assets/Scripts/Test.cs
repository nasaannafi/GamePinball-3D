using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   public Collider bola;
   

   private void OnCollisionEnter(Collision collision)
   {
    if(collision.collider == bola)
    {
        Debug.Log("Kena bola");
    }
   }
}
