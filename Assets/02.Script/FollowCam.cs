using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

    public Transform targetTr;
    public float dist = 10.0f;
    public float height = 3.0f;
    public float dampTrace = 20.0f;

    private Transform tr;

	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void LateUpdate()
    {
        tr.position = Vector3
    }
}
