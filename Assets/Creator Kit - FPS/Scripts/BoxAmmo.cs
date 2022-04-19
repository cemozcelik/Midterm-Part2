using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxAmmo : MonoBehaviour
{
    public int ammo;
    public void OnTriggerEnter(Collider other)

    {
        if(other.tag=="Player")
        {
            other.GetComponent<Weapon>().AmmoTake(ammo);    
            
        }
    }
}
