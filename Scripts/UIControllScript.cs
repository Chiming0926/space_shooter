using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIControllScript : MonoBehaviour {

    public static UIControllScript Instance;
    public int Score = 0;
    public Text ScoreText;
    // Use this for initialization
    void Start ()
    {
        Instance = this;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void AddScore()
    {
        Score += 10; 
        ScoreText.text = "Score: " + Score; 

    }
}
