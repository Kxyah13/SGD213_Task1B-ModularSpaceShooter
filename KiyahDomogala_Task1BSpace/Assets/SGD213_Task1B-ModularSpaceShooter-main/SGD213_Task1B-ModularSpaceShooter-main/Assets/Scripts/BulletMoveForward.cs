
//BULLET MOVEFORWARD

using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

//Speed and velocity of the bullets
private float acceleration = 50f;
private float initialVelocity = 50f;
private Rigidbody2D ourRigidbody;

  // Use this for initialization
  void Start()
   {
     ourRigidbody = GetComponent<Rigidbody2D>();

     ourRigidbody.velocity = Vector2.up * initialVelocity;
   }

  // Update is called once per frame
  void Update()
   {
      Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

      ourRigidbody.AddForce(ForceToAdd);
   }
}
