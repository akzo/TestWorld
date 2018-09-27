
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Camera myCamera;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, 2);
            myCamera.transform.Translate(0, 0, 2);
        }
	}
}
