using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownMushroom : PickUp
{

    //[SerializeField] private int scoreValue = 0;


    public override void PickUpItem()
    {
        Debug.Log("BrownMushroom - PickUpItem()");

        //ScoreBoard.InstanceScoreBoard.AddScore(scoreValue);
    }
}
