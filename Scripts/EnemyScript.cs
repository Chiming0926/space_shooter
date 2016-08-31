using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        r2d.AddTorque(10f, ForceMode2D.Force);
        gameObject.transform.position -= new Vector3(0, 0.1f, 0);
    }

    void OnBecameInvisible()
    {
        // Destroy the bullet
        if (gameObject.transform.position.y < -4.64f)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // If the enemy collided with a bullet
        if (col.name == "bullet(Clone)")
        {
            // Destroy itself (the enemy) and the bullet
            Destroy(gameObject);
            Destroy(col.gameObject);
            UIControllScript.Instance.AddScore();
        }

        // If the enemy collided with the spaceship
        if (col.name == "spaceship")
        {
            // Destroy itself (the enemy) to keep things simple
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
