
//SHOOTING

using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;
    private float bulletOffset = 2f;

    void Start()
    {
      // Spawns bullets infront of the player character
      bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
         + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;
            if (CurrentTime - lastFiredTime > fireDelay)  // Delay - ensures one bullet at a time
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                Instantiate(bullet, spawnPosition, transform.rotation);
                lastFiredTime = CurrentTime;
            }
            print("Shoot!");
        }
    }
    public float SampleMethod(int number) {
        return number;
    }

}
