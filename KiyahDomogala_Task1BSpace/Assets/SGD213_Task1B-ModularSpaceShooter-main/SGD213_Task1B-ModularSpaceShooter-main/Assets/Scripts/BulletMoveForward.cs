
//BULLET MOVEFORWARD

using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

//Speed and velocity of the bullets
private float bulletAcceleration = 50f;
private float initialVelocity = 50f;
private Rigidbody2D rb;

  // Use this for initialization
  void Start()
   {
     rb = GetComponent<Rigidbody2D>();

     rb.velocity = Vector2.up * initialVelocity;
   }

  // Update is called once per frame
  void Update()
   {
      Vector2 ForceToAdd = Vector2.up * bulletAcceleration * Time.deltaTime;

      rb.AddForce(ForceToAdd);
   }
}
