using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float speed;
    public float acceleration;
    public GameObject player;
    public playerStats stats;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        stats = player.GetComponent<playerStats>();
        StartCoroutine(DestroyOverTime());
    }

    private void Update()
    {
        rigidBody.AddForce(gameObject.transform.up * speed * acceleration);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = Random.Range(3, 5);
        if (collision.CompareTag("Finish"))
        {
            enemy enemystats = collision.gameObject.GetComponent<enemy>();
            enemystats.health -= damage;
            stats.combo += 1;
        }
    }

    IEnumerator DestroyOverTime ()
    {
        yield return new WaitForSeconds(15f);
        Destroy(gameObject);
    }
}
