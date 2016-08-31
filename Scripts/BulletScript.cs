using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {


    public int speed = 6;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.position += new Vector3(0, 0.12f, 0);
    }

    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }
}
