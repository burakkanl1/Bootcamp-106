using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    
    private Rigidbody2D r2d;
    Animator _animator;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpSpeed = 0;
    [SerializeField] bool canJump = false;

    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //ZIPLAMA
        if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, jumpSpeed);
            canJump = false;
            _animator.SetBool("Grounded", false);
            _animator.SetBool("isJumping", true);
        }

        //DUSME ANÝMASYONU
        if (r2d.velocity.y < 0.1f)
        {
            _animator.SetBool("isJumping", false);
        }
        //SOLA HAREKET
        if (Input.GetAxis("Horizontal") < 0)
        {
            r2d.velocity = new Vector2(Input.GetAxis("Horizontal"), r2d.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //SAGA HAREKET
        if (Input.GetAxis("Horizontal") > 0)
        {
            r2d.velocity = new Vector2(Input.GetAxis("Horizontal"), r2d.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //KOSMA ANÝMASYONU(runAnim)
        if (Input.GetAxis("Horizontal") != 0)
        {
            _animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        }

        //DURMA ANÝMASYONU(idleAnim)
        if (Input.GetAxis("Horizontal") == 0)
        {
            _animator.SetFloat("Speed", Input.GetAxis("Horizontal"));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // ZEMÝNE DEÐERSE ZIPLAYABÝLSÝN
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            _animator.SetBool("Grounded", true);
        }
    }

}
