using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    MyVector2D velocity;

    //[SerializeField]
    MyVector2D displacement;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
    }
}
