using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayTransition : MonoBehaviour
{
    public Animator DayTransitionAnim;
    public GameObject DayTransitionCanvas;
    public TMP_Text dayDisplay;
    public int dayCount;
    public AnimationClip DayEnd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextDay()
    {
        DayTransitionCanvas.SetActive(true);
        StartCoroutine(NextDaySequence());
    }

    IEnumerator NextDaySequence()
    {
        dayCount++;

        dayDisplay.text = "Day " + dayCount.ToString();

        DayTransitionAnim.SetTrigger("DayStart");

        yield return new WaitForSeconds(3);

        DayTransitionAnim.SetTrigger("DayEnd");

        //Kode s� vi kan hente l�ngden af animationsklippet, og ikke skal g�tte os til det
        yield return new WaitForSeconds(DayEnd.length);

        DayTransitionCanvas.SetActive(false);
    }
}
