using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AmmoBox: MonoBehaviour
{
    [AmmoType]
    public int ammoType;
    public int amount;
    
    
    void OnTriggerEnter(Collider other)
    {
        Controller c = other.GetComponent<Controller>();

        if (c != null)
        {
            c.ChangeAmmo(ammoType, amount);
            Destroy(gameObject);
        }
    }
}
