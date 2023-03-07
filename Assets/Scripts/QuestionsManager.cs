using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionsManager : MonoBehaviour
{
    [SerializeField] private TMP_Text count;
    public static int counter = 0;
    [SerializeField] private GameObject passed_UI;
    [SerializeField] private GameObject wrong_UI;
    [SerializeField] private GameObject text;
    [SerializeField] private Button passed;
    [SerializeField] private Button wrong;
    [SerializeField] private GameObject next_Question;
    [SerializeField] private AnimationController animationController;
    private void Start()
    {
        
        passed.onClick.AddListener(() => Passed());
        wrong.onClick.AddListener(() => Wrong());
    }
    public void Passed()
    {
        passed_UI.SetActive(true);
        text.SetActive(false);
        passed.interactable = false;
        wrong.interactable = false;
        StartCoroutine(Recorder());
        count.gameObject.SetActive(true);
        counter += 1;
        count.text = counter.ToString() + "/" + "10";

        next_Question.SetActive(true);
    }
    public void Wrong()
    {
        wrong_UI.SetActive(true);
        text.SetActive(false);
        passed.interactable = false;
        wrong.interactable = false;
        StartCoroutine(Recorder());
        count.gameObject.SetActive(true);
        count.text = counter.ToString() + "/" + "10";
        if (next_Question != null)
        {
            next_Question.SetActive(true);
        }
        
    }
    IEnumerator Recorder()
    {
        yield return new WaitForSeconds(3f);
        if (animationController != null)
        {
            animationController.enabled = true;
            animationController.Player.enabled = true;
        }
        Destroy(this.gameObject);
    }
}
