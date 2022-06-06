using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
     public int score= 0;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Pumpkin")){
            Debug.Log(score);
            score++;
            Destroy(other.gameObject);
        }
    }
}
