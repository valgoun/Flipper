using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedController : MonoBehaviour {

    private bool isOn = false;
    public Sprite on;
    public Sprite off;
    private SpriteRenderer rdr;


    void Awake() {
        rdr = GetComponent<SpriteRenderer>();
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (isOn && rdr.sprite == off) {
            rdr.sprite = on;
        }
        if (!isOn && rdr.sprite == on) {
            rdr.sprite = off;
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
