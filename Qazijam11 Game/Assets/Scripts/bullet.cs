using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float speed;
    public float acceleration;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigidBody.AddForce(gameObject.transform.up * speed * acceleration);
    }
}
