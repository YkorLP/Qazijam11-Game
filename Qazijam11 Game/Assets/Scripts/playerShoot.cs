using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject firePoint;


    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot ()
    {
        animator.SetTrigger("Shoot");
        animator.ResetTrigger("Idle");
        yield return new WaitForSeconds(0.1f);
        animator.ResetTrigger("Shoot");
        animator.SetTrigger("Idle");
    }
}
