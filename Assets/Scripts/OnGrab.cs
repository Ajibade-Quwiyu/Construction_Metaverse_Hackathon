using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrab : MonoBehaviour
{
    public Outline outline;
    public void OnGrabbing()
    {
        outline.enabled = true;
        Destroy(this.gameObject,4);

    }
    
}
