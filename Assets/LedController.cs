using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedController : MonoBehaviour {

    private bool isOn = false;
    private MeshRenderer mesh;


    void Awake() {
        mesh = GetComponent<MeshRenderer>();
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (isOn) {
            mesh.materials[0].color = Color.red;
        }
        if (!isOn) {
            mesh.materials[0].color = Color.black;
        }
    }

    public bool get() {
        return isOn;
    }

    public void set(bool setValue) {
        isOn = setValue;
    }

    public void turnOn() {
        isOn = true;
    }

    public void turnOff() {
        isOn = true;
    }

    public void turnSwitch() {
        isOn = !isOn;
    }

}
