using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerButton : MonoBehaviour
{
    public static bool tecMode;
    TextMesh[] t;
    public int count;
    public int powStartCount;
    public int tecStartCount;
    public int maxCount;

    void Start() {
        count = powStartCount;
        t = GetComponentsInChildren<TextMesh>();
        gameObject.AddComponent<BoxCollider2D>();
        UpdateText();
    }

    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            Increase();
            UpdateText();
        }
        if (Input.GetMouseButtonDown(1)) {
            Decrease();
            UpdateText();
        }
        
    }

    void Increase() {
        if (count < maxCount) {
            count += 1;
        }
    }

    void Decrease() {
        if (count > 0) {
            count -= 1;
        }
    }

    public void UpdateText() {
        for (int i = 0; i < t.Length; i++) {
            t[i].text = count.ToString();
        }
    }
}
