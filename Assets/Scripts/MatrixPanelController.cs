using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixPanelController : MonoBehaviour {

    public GameObject prefabLed;
    private LedController[,] leds;
    private string line1 = " * > Maya > *";
    private string line2 = "";
    private string nextLine1 = "<> *<* >*< * >*";
    private string nextLine2 = "";
    public float resetCooldown = 1.0f;
    private float actualCooldown;
    private int offset = 0;

    // Use this for initialization
    void Start() {
        leds = new LedController[100, 12];
        for (int j = 0; j < 12; j++) {
            for (int i = 0; i < 100; i++) {
                var tmp = Instantiate(prefabLed, new Vector3(this.transform.localPosition.x + 0.2f * (i - 50), this.transform.localPosition.y + 0.2f * (j - 6), this.transform.localPosition.z), Quaternion.identity);
                tmp.transform.parent = this.gameObject.transform;
                var pos = tmp.transform.localPosition;
                pos.z = 0;
                tmp.transform.localPosition = pos;
                leds[i, j] = tmp.GetComponent<LedController>();
            }
        }

        offset = 100;

        actualCooldown = resetCooldown;

        //AsciiLetters al = JsonUtility.FromJson<AsciiLetters>(json);
        //Debug.Log(al.A);
    }

    // Update is called once per frame
    void Update() {
        actualCooldown = Mathf.Max(0, actualCooldown - Time.deltaTime);

        if (actualCooldown == 0) {
            updateUI();
            offset--;
            if (offset < -Mathf.Max(line1.Length, line2.Length) * 6) {
                offset = 100;
                if (nextLine1 != "") {
                    line1 = nextLine1;
                    nextLine1 = "";
                    line2 = "";
                }
                if (nextLine2 != "") {
                    line2 = nextLine2;
                    nextLine2 = "";
                }

                if (line2 != "") {
                    if (line1.Length < line2.Length) {
                        var count = (line2.Length - line1.Length) / 2;
                        for (int i = 0; i <= count; i++) {
                            line1 = " " + line1;
                        }
                    }
                    else {
                        if (line2.Length < line1.Length) {
                            var count = (line1.Length - line2.Length) / 2;
                            for (int i = 0; i <= count; i++) {
                                line2 = " " + line2;
                            }
                        }
                    }
                }

            }

            if (offset == 50 - Mathf.Max(line1.Length, line2.Length) * 3) {
                actualCooldown = 100 * resetCooldown;
            }
            else {
                actualCooldown = resetCooldown;
            }
        }
    }

    void updateUI() {
        foreach (var led in leds) {
            led.set(false);
        }
        if (line2 != "") {
            for (int i = 0; i < line1.Length; i++) {
                var table = AsciiLetters.getLetterTable(line1[i]);
                for (int j = 0; j < 5; j++) {
                    for (int k = 0; k < 5; k++) {
                        if (k + 6 * i + offset >= 0 && k + 6 * i + offset < 100) {
                            leds[k + 6 * i + offset, 11 - j].set(intToBool(table[j][k]));
                        }
                    }
                }
            }

            for (int i = 0; i < line2.Length; i++) {
                var table = AsciiLetters.getLetterTable(line2[i]);
                for (int j = 0; j < 5; j++) {
                    for (int k = 0; k < 5; k++) {
                        if (k + 6 * i + offset >= 0 && k + 6 * i + offset < 100) {
                            leds[k + 6 * i + offset, 4 - j].set(intToBool(table[j][k]));
                        }
                    }
                }
            }
        }
        else {
            for (int i = 0; i < line1.Length; i++) {
                var table = AsciiLetters.getLetterTable(line1[i]);
                for (int j = 0; j < 5; j++) {
                    for (int k = 0; k < 5; k++) {
                        if (k + 6 * i + offset >= 0 && k + 6 * i + offset < 100) {
                            leds[k + 6 * i + offset, 7 - j].set(intToBool(table[j][k]));
                        }
                    }
                }
            }
        }
    }

    bool intToBool(int i) {
        return (i != 0);
    }

    public void setLine1NextMessage(string message) {
        nextLine1 = message;
    }

    public void setLine2NextMessage(string message) {
        nextLine2 = message;
    }

}
