using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject firePoint;

    public bool canShoot;


    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            StartCoroutine(Shoot());
        }
    }

    void CanShoot ()
    {
        //canShoot = true;
    }

    IEnumerator Shoot ()
    {
        canShoot = false;
        animator.SetTrigger("Shoot");
        animator.ResetTrigger("Idle");
        yield return new WaitForSeconds(0.1f);
        animator.ResetTrigger("Shoot");
        animator.SetTrigger("Idle");
        yield return new WaitForSeconds(0.2f);
        canShoot = true;
    }
}
