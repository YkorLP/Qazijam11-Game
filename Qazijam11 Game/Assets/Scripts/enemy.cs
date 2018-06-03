using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;

    private void Start()
    {
        player = GameObject.Find("Player");
        StartCoroutine(Shoot());
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
