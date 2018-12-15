using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform Vehicle_3;
    public Text scoreText;

    // Update is called once per frame
	void Update ()
    {
        NewMethod();
    }


    private void NewMethod()
    {
        scoreText.text = Vehicle_3.position.z.ToString("0");
    }
}
