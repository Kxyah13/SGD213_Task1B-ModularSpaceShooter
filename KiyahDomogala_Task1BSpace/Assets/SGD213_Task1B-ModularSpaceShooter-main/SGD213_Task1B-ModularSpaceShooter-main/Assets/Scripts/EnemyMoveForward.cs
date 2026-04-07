
//ENEMY MOVE FORWARD

using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour {

    private float enemyAcceleration = 5f;

    private float initialVelocity = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ForceToAdd = Vector2.down * enemyAcceleration * Time.deltaTime;

        rb.AddForce(ForceToAdd);
    }
}
