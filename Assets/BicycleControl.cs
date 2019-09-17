using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleControl : MonoBehaviour
{
    Rigidbody physic;
    GameObject vehicle;
    float vertical;
    float horizontal;
    public int speed;

    Vector3 vec;


    // Start is called before the first frame update
    void Start()
    {
        vehicle = this.transform.gameObject;
        physic = transform.gameObject.GetComponent<Rigidbody>();
        speed = 10;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
        vec = new Vector3(horizontal*speed, 0, vertical*speed);
        Move();
        
        
    }
    
    void Move()
    {
        if(horizontal!=0 || vertical != 0)
        {
            if(horizontal>1 && vertical > 1)
            {
                physic.velocity = (vec) / 2;
            }
            else
            {
                physic.velocity = (vec);
            }
            
        }
        else
        {
           
        }
        
    }
    
    
    string getVehicleType()
    {
        return vehicle.name;
    }
}
