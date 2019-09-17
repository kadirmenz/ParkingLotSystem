using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingContr : MonoBehaviour
{
     public int emptytruckLot=7;
     public int emptycarLot=8;
     public int emptybicycleLot=5;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Available BicycleLots:" + getEmptyBicycleLots() + " CarLots:" + getEmptyCarLots() + " TruckLots:" + getEmptyTruckLots());
    }
    public void decreaseEmptyTruckLots()
    {
        emptytruckLot--;
    }
    public void increaseEmptyTruckLots()
    {
        emptytruckLot++;
    }
    public int getEmptyTruckLots()
    {
        return emptytruckLot;
    }
    public void decreaseEmptyCarLots()
    {
        emptycarLot--;
    }
    public void increaseEmptyCarLots()
    {
        emptycarLot++;
    }
    public int getEmptyCarLots()
    {
        return emptycarLot;
    }
    public void decreaseEmptyBicycleLots()
    {
        emptybicycleLot--;
    }
    public void increaseEmptyBicycleLots()
    {
        emptybicycleLot++;
    }
    public int getEmptyBicycleLots()
    {
        return emptybicycleLot;
    }


}
