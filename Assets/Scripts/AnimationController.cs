using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public string toPlay;
    public Animator Player;
    // Start is called before the first frame update
    void Start()
    {
        Player.Play(toPlay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
