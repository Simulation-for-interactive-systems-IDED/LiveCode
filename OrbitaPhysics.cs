using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaPhysics : MonoBehaviour
{
    [SerializeField] private float mass = 1;
    [SerializeField] private Vector3 velocity;
    private Vector3 acceleration;

    [Header("Other object")]
    [SerializeField] private Transform target;
    [SerializeField] private float targetMass = 1;

    void Update()
    {
        acceleration = Vector3.zero;

        // Calculate the gravitational attraction force
        Vector3 difference = target.position - transform.position;
        float distance = difference.magnitude;
        float attractionForceScalar = (mass * targetMass) / distance * distance;
        Vector3 force = attractionForceScalar * difference.normalized;
        ApplyForce(force);

        Move();
    }

    private void Move(){
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        //// Debug my vectors
        //transform.position.Draw(Color.red);
        //acceleration.Draw(position, Color.green);
        //velocity.Draw(position, Color.blue);
    }

    private void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }
}
