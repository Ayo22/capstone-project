using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform Vehicle_3;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = Vehicle_3.position + offset;
	}
}
