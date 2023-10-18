using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonMushroom : PickUp
{

    //[SerializeField] private int scoreValue = 0;


    public override void PickUpItem()
    {
        Debug.Log("PoisonMushroom - PickUpItem()");

        //ScoreBoard.InstanceScoreBoard.AddScore(scoreValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Poisonmushroom - OntriggerEnter");
        if (other.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            Debug.Log("Pickup - OnTriggerEnter(PoisonMushroom) -> Character Hit poisonmushroom");
            Karhu bear = other.GetComponent<Karhu>();
            bear.EatPoisonMushroom(20);
            PickUpItem();
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
    }
