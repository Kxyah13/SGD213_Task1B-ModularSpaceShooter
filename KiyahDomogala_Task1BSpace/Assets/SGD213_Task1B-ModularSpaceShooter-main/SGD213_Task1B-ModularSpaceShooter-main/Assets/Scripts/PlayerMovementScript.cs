
//PLAYER MOVEMENT

using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    // HorizontalPlayerAcceleration indicates how fast the player accelerates Horizontally
    [SerializeField]
    private float playerAcceleration = 5000f;

            private Rigidbody2D rb;

    // Use this for initialization
    void Start() {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        rb = GetComponent<Rigidbody2D>(); }
    // Update is called once per frame
    void Update() {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f) {
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*playerAcceleration*Time.deltaTime;
            rb.AddForce(ForceToAdd);
            print(HorizontalInput);
        } 
    } 
}
