using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x <= 5.97f)
                gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x >= -5.97f)
                gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (gameObject.transform.position.y <= 4.64f)
                gameObject.transform.position += new Vector3(0, 0.1f, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (gameObject.transform.position.y >= -4.64f)
                gameObject.transform.position += new Vector3(0, -0.1f, 0);
        }
        //gameObject.transform.position += new Vector3(0, 0.05f, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(0, 0.7f, 0);
            Instantiate(bullet, pos, gameObject.transform.rotation);
        }
    }
}
