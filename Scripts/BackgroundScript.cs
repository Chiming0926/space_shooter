using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position -= new Vector3(0, 0.1f, 0);
    }

    void OnBecameInvisible()
    {
        gameObject.transform.position += new Vector3(0, 20.02f, 0);
    }
}
