using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public TrackerButton[] buttons;
    public Lifepoints lp;

    void OnMouseDown(){
        for (int i = 0; i < buttons.Length; i++) {
            if (TrackerButton.tecMode) {
                buttons[i].count = buttons[i].tecStartCount;
            } else {
                buttons[i].count = buttons[i].powStartCount;
            }
            buttons[i].UpdateText();
        }
        lp.Reset();
    }
}
