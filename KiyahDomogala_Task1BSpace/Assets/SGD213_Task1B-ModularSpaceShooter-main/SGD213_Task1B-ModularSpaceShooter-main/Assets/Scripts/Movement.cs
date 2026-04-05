using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DirectionList
{
    PlayerDirection
    BulletDirection
    EnemyDirection
}

public class Movement : MonoBehaviour
{
    //List to know what object needs
    [SerializeField]
    private DirectionList directionList - DirectionList.PlayerDirection;
    private Rigidbody2D rb;

    //Set values to 0 Zero
    private float acceleration = 0f;
    private float initialVelocity = 0f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Rock initialVelocity and acceleration
        if (directionList == DirectionList.EnemyDirection)
        {
            acceleration = 75f;
            initialVelocity = 2f;
            rb.velocity = Vector2.down * initialVelocity

        }

        //Bullet initialVelocity and acceleration
        if (directionList == DirectionList.BulletDirection)
        {
            acceleration = 200f;
            initialVelocity = 5f;
            rb.velocity = Vector2.up * initialVelocity

        }

        //Does nothing due to it coming from PlayerInput
        if (directionList == DirectionList.PlayerDirection)
        {

        }
    }

    private void Update()
    {
        //Enemy movement
        if (directionList == DirectionList.EnemyDirection)
        {
            Vector2 EnemyForceToAdd = Vector2.down * acceleration * Time.deltaTime;
            rb.AddForce(EnemyForceToAdd);
        }
        //Bullet Movement
        if (directionList == DirectionList.BulletDirection)
        {
            Vector2 BulletForceToAdd = Vector2.up * acceleration * Time.deltaTime;
            rb.AddForce(BulletForceToAdd);
        }
        //Player Movement
        public void ObjectMovement(Vector2 direction, float acceleration)
    {
        Vector2 Movement = direction * acceleration * Time.deltaTime;
        rb.AddForce(Movement);
    }
}   