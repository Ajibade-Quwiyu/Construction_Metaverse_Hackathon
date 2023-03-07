using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Button oK;
    private GameObject instruction;
    public GameObject next_Instruction;
    [SerializeField] private AnimationController animationController;

    void Start()
    {
        
        if (instruction!=null)
        {
            instruction = this.transform.GetChild(0).gameObject;
        }
        oK.onClick.AddListener(()=>OK());
    }

   
    
    public void OK()
    {
        if (next_Instruction!=null)
        {
            next_Instruction.SetActive(true);
        }

        animationController.enabled = true;
        animationController.Player.enabled = true;
        Destroy(this.gameObject);
    }
}
