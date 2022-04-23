using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelRank : MonoBehaviour
{
    public TextMesh rankDisplay;
    public TrackerButton effectiveAttacks;
    public TrackerButton defensiveWins;
    public TrackerButton pureMagic;
    public TrackerButton equipMagic;
    public TrackerButton triggerTrap;
    public TrackerButton fusions;
    public TrackerButton facedown;
    public TrackerButton turns;
    public TrackerButton cardsUsed;
    public Lifepoints lifepoints;
    int rank;
    
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        CalculateRank();
    }

    void CalculateRank() {
        rank = 52;

        if (turns.count > 32) {
            rank -= 12;
        } else if (turns.count > 28) {
            rank -= 8;
        } else if (turns.count > 4 && turns.count < 9) {
            rank += 8;
        } else if (turns.count >= 0 && turns.count < 5) {
            rank += 12;
        }

        if (effectiveAttacks.count > 19) {
            rank -= 4;
        } else if (effectiveAttacks.count > 9) {
            rank -= 2;
        } else if (effectiveAttacks.count > 1 && effectiveAttacks.count < 4) {
            rank += 2;
        } else if (effectiveAttacks.count >= 0 && effectiveAttacks.count < 2) {
            rank += 4;
        }

        if (defensiveWins.count > 14) {
            rank -= 40;
        } else if (defensiveWins.count > 9) {
            rank -= 30;
        } else if (defensiveWins.count > 5) {
            rank -= 20;
        } else if (defensiveWins.count > 1) {
            rank -= 10;
        }

        if (facedown.count > 30) {
            rank -= 8;
        } else if (facedown.count > 20) {
            rank -= 6;
        } else if (facedown.count > 10) {
            rank -= 4;
        } else if (facedown.count > 0) {
            rank -= 2;
        }

        if (fusions.count > 14) {
            rank -= 12;
        } else if (fusions.count > 9) {
            rank -= 8;
        } else if (fusions.count > 4) {
            rank -= 4;
        } else if (fusions.count == 0) {
            rank += 4;
        }

        if (equipMagic.count > 14) {
            rank -= 12;
        } else if (equipMagic.count > 9) {
            rank -= 8;
        } else if (equipMagic.count > 4) {
            rank -= 4;
        } else if (equipMagic.count == 0) {
            rank += 4;
        }

        if (pureMagic.count > 9) {
            rank -= 16;
        } else if (pureMagic.count > 6) {
            rank -= 12;
        } else if (pureMagic.count > 3) {
            rank -= 8;
        } else if (pureMagic.count > 0) {
            rank -= 4;
        } else if (pureMagic.count == 0) {
            rank += 2;
        }

        if (triggerTrap.count > 6) {
            rank -= 32;
        } else if (triggerTrap.count > 4) {
            rank -= 24;
        } else if (triggerTrap.count > 2) {
            rank -= 16;
        } else if (triggerTrap.count > 0) {
            rank -= 8;
        } else if (triggerTrap.count == 0) {
            rank += 2;
        }

        if (cardsUsed.count > 36) {
            rank -= 7;
        } else if (cardsUsed.count > 32) {
            rank -= 5;
        } else if (cardsUsed.count > 8 && cardsUsed.count < 13) {
            rank += 12;
        } else if (cardsUsed.count >= 0 && cardsUsed.count < 9) {
            rank += 15;
        }

        if (lifepoints.lp == 8000) {
            rank += 6;
        } else if (lifepoints.lp == 7999) {
            rank += 4;
        } else if (lifepoints.lp == 999) {
            rank -= 5;
        } else if (lifepoints.lp == 99) {
            rank -= 7;
        }

        if (rank >= 90) {
            rankDisplay.text = "Rank: S-POW";
        } else if (rank >= 80) {
            rankDisplay.text = "Rank: A-POW";
        } else if (rank >= 70) {
            rankDisplay.text = "Rank: B-POW";
        } else if (rank >= 60) {
            rankDisplay.text = "Rank: C-POW";
        } else if (rank >= 50) {
            rankDisplay.text = "Rank: D-POW";
        } else if (rank >= 40) {
            rankDisplay.text = "Rank: D-TEC";
        } else if (rank >= 30) {
            rankDisplay.text = "Rank: C-TEC";
        } else if (rank >= 20) {
            rankDisplay.text = "Rank: B-TEC";
        } else if (rank >= 10) {
            rankDisplay.text = "Rank: A-TEC";
        } else {
            rankDisplay.text = "Rank: S-TEC";
        }
        Debug.Log(rank);
    }
}
