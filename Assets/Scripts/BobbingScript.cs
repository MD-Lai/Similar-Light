using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingScript : MonoBehaviour {

    public float bobAmp = 0.1f; // how many units to displace from centre
    public float bobFreq = 0.5f; // how often to bob, in hz
    public float offset = 0.5f; // how high the object should be above the given point
    public float returnRate = 0.5f; // how long it takes to return to neutral

    private float referenceTime;

    void Start() {
        referenceTime = Time.time;
    }

    // Update is called once per frame
    void Update () {
        Bob();
	}

    private void Bob() {
        Vector3 newPos = this.transform.position;
        if (!MovementKeyPressed()) {

            newPos.y = Mathf.Sin((Time.time-referenceTime) * Mathf.PI * bobFreq) * bobAmp + offset;

        }
        else {
            newPos.y = Mathf.Lerp(this.transform.position.y, offset, Time.deltaTime / returnRate);
        }

        this.transform.position = newPos;
    }

    private bool MovementKeyPressed() {
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
        //    referenceTime = Time.time;
        //    return true;
        //}
        //return false;
        return false;
    }
}
