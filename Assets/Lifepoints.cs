using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifepoints : MonoBehaviour
{
    TextMesh[] t;
    public int[] lpValues;
    int lpIndex;
    public int lp;

    void Start() {
        t = GetComponentsInChildren<TextMesh>();
        gameObject.AddComponent<BoxCollider2D>();
        lp = lpValues[0];
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
        if (lpIndex < lpValues.Length-1) {
            lpIndex += 1;
        } else {
            lpIndex = 0;
        }
        lp = lpValues[lpIndex];
    }

    void Decrease() {
        if (lpIndex > 0) {
            lpIndex -= 1;
        } else {
            lpIndex = lpValues.Length-1;
        }
        
        lp = lpValues[lpIndex];
    }

    void UpdateText() {
        for (int i = 0; i < t.Length; i++) {
            t[i].text = lp.ToString();
        }
    }

    public void Reset() {
        lpIndex = 0;
        lp = lpValues[lpIndex];
        UpdateText();
    }
}
