using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitcher : MonoBehaviour
{
    TextMesh t;
    public TextMesh s;
    void Start() {
        t = GetComponent<TextMesh>();
    }
    void OnMouseDown() {
        if (TrackerButton.tecMode == true) {
            TrackerButton.tecMode = false;
            t.text = "Mode: POW";
            s.text = "Mode: POW";
        } else {
            TrackerButton.tecMode = true;
            t.text = "Mode: TEC";
            s.text = "Mode: TEC";
        }
    }
}
