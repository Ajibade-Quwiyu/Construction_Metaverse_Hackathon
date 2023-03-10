using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrab : MonoBehaviour
{
    GameObject todisable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInChildren<Outline>() != null)
        {
            other.GetComponentInChildren<Outline>().enabled = true;
            todisable = other.gameObject;
            StartCoroutine(Disable());
        }
    }
    IEnumerator Disable()
    {
        yield return new WaitForSeconds(3);
        todisable.SetActive(false);
    }
    

}
