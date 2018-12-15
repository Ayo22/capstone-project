using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;     // A reference to our PlayerMovement script
    public int health = 5;
    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            health = health - 1;
            movement.enabled = true;
            if (health == 0)
            {
                movement.enabled = false;   // Disable the players movement.
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }

}
