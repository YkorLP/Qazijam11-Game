using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public Transform target;

    public float speed = 5f;
    public float rotateSpeed = 200f;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
        animator = GetComponent<Animator>();
        StartCoroutine(PlayAnim());
    }

    private void Update()
    {

    }

    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            playerStats stats = col.gameObject.GetComponent<playerStats>();
            stats.TakeDamage();
            animator.SetTrigger("Destroy");
        }
    }

    IEnumerator PlayAnim ()
    {
        yield return new WaitForSeconds(5f);
        animator.SetTrigger("Destroy");
    }

    void DestroySelf ()
    {
        Destroy(gameObject);
    }
}
