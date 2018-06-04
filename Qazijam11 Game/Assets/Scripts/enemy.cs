using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    public int health = 10;

    public Slider healthSlider;

    private void Start()
    {
        player = GameObject.Find("Player");
        StartCoroutine(Shoot());
    }

    private void Update()
    {
        healthSlider.value = health;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        Vector3 diff = player.transform.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }

    IEnumerator Shoot ()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
