using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLotControl : MonoBehaviour
{
    ParkingContr parkingContr;
   
    // Start is called before the first frame update
    void Start()
    {
        parkingContr = transform.parent.GetComponent<ParkingContr>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Car")
        {
            parkingContr.decreaseEmptyCarLots();
        }
        else
        {
            Debug.Log("Wrong Parking Lot!You need to find " + other.name + "parking lot.");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Car")
        {
            parkingContr.increaseEmptyCarLots();
        }
    }
   
}
