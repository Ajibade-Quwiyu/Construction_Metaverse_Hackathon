using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private GameObject carrier;
    Vector3 Carrier_Pos;
    private void Start()
    {
        Carrier_Pos = carrier.transform.position;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == carrier)
        {
            carrier.transform.position = Carrier_Pos;
            Debug.Log(carrier);
        }
    }
}
