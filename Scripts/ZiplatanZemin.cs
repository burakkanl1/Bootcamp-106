using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZiplatanZemin : MonoBehaviour
{

    [SerializeField] private AudioClip clickSound;
    public float jumpforce= 30f;
    
    private void OnCollisionEnter2D(Collision2D other) {
        Rigidbody2D rb= gameObject.GetComponent<Collider>().GetComponent<Rigidbody2D>();

        if( rb != null){
            Vector2 jumpvelocity = rb.velocity;
            jumpvelocity.y = jumpforce;
            rb.velocity= jumpvelocity;
            AudioSource.PlayClipAtPoint(clickSound,other.transform.position);
        }    
    }
}
