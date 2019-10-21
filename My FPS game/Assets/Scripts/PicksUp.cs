using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicksUp : MonoBehaviour
{
    public Transform theDest;
    public Item item;	// Item to put in the inventory if picked up

    void OnMouseDown()
    {
        Debug.Log("Picking up " + item.name);
        bool ok = Inventory.instance.Add(item);   // Add to inventory
        if (ok)
        {
            Destroy(gameObject);    // Destroy item from 
            Debug.Log("ok");
        }
        
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        //Destroy(gameObject);
    }
}
