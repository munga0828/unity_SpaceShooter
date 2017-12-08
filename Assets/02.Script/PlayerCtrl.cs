using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

    float h = 0.0f;
    float v = 0.0f;

    Transform tr;

    public float moveSpeed = 10.0f;

    public float rotSpeed = 100.0f;



	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //Debug.Log(string.Format("H = {0}", h));
        //Debug.Log(string.Format("V = {0}", v));

        Vector3 movedir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(movedir * Time.deltaTime * moveSpeed, Space.Self);
        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

        Debug.Log(string.Format("mouse : {0}", Input.GetAxis("Mouse X")));


    }
}
