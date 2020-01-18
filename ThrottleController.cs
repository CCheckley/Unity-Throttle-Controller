using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ThrottleController : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;

    [SerializeField] float maxAngle = 180.0f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        rigidbody2D.rotation = maxAngle * Input.GetAxisRaw("Throttle");
    }
}
