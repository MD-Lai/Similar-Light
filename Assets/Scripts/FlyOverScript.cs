using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyOverScript : MonoBehaviour {

    public float moveSpeed = 1; // units per second
    public Vector3 moveAngle = new Vector3(0,45,0); //  angle to rotate about

	// Use this for initialization
	void Start () {
		
	}   
	
	// Update is called once per frame
	void Update () {
        InputMovement();
	}

    private void InputMovement() {
        Vector3 forwardMove = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            forwardMove += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S)) {
            forwardMove += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A)) {
            forwardMove += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D)) {
            forwardMove += Vector3.right;
        }

        this.transform.position += Quaternion.Euler(moveAngle.x, moveAngle.y, moveAngle.z) * forwardMove.normalized * moveSpeed * Time.deltaTime;
    }
}
