using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigidBody;

    private void Start()
    {
        Time.timeScale = 1;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey("w"))
        {
            transform.position += Vector3.up * speed / 10 * Time.timeScale;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * speed / 10 * Time.timeScale;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed / 10 * Time.timeScale;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed / 10 * Time.timeScale;
        }
    }

    private void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rigidBody.angularVelocity = 0;
    }
}
