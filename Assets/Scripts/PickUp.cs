using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] GameObject W1;
    [SerializeField] GameObject W2;
    [SerializeField] GameObject W3;
    [SerializeField] GameObject Camera;

    private GameObject ActualWeapon;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(ActualWeapon);
        if (other.gameObject.tag == "W1")
            ActualWeapon = Instantiate(W1, Camera.transform.position, Camera.transform.rotation);
       
        else if (other.gameObject.tag == "W2")
            ActualWeapon = Instantiate(W2, Camera.transform.position, Camera.transform.rotation);

        else if (other.gameObject.tag == "W3")
            ActualWeapon = Instantiate(W3, Camera.transform.position, Camera.transform.rotation);

        ActualWeapon.transform.parent = Camera.transform;
    }

}
