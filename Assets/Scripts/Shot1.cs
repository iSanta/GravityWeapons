using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot1 : MonoBehaviour
{
    [SerializeField] ShotData ShotInfo;
    private float forceIntencity;
    void Start()
    {
        forceIntencity = ShotInfo.GetForceIntensity;
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * forceIntencity);
        StartCoroutine(DestroyBullet());
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }

}
