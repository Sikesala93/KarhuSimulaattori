using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pickup - OnTriggerEnter()");

        if(other.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            Debug.Log("Pickup - OnTriggerEnter() -> Character Hit normal mushroom");
            Karhu bear = other.GetComponent<Karhu>();
            bear.EatMushroom(3);
            PickUpItem();
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            Debug.Log("Pickup - OnTriggerEnter(PoisonMushroom) -> Character Hit poisonmushroom");
            Karhu bear = other.GetComponent<Karhu>();
            bear.EatPoisonMushroom(200);
            PickUpItem();
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    public virtual void PickUpItem()
    {

    }

    public static explicit operator PickUp(GameObject v)
    {
        throw new NotImplementedException();
    }


}
