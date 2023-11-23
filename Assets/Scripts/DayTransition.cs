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

        //GameObject baseGame = GameObject.Find("Game");
        //GameObject GameState1 = GameObject.Find("GameState1");
        //GameObject GameState2 = GameObject.Find("GameState2");


        //baseGame.SetActive(false);

        dayDisplay.text = "Day " + dayCount.ToString();

        //yield return new WaitForSeconds(3);

        DayTransitionAnim.SetTrigger("DayEnd");

        //yield return new WaitForSeconds(1);

        //baseGame.SetActive(true);
        //GameState1.SetActive(false);
        //GameState2.SetActive(true);

        yield return new WaitForSeconds(3);

        DayTransitionCanvas.SetActive(false);
    }
}
