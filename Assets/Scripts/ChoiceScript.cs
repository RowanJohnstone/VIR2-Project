using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;


    private void Start()
    {
        Choice01.SetActive(false);
        Choice02.SetActive(true);
        Choice03.SetActive(false);
    }
    public void ChoiceOption1 ()
    {

    }
    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Do you have an appointment?";
        ChoiceMade = 1;
        //Is there an easier way to reference the button text?
        GameObject.Find("Option 2").GetComponentInChildren<Text>().text = "No.";
    }
    public void ChoiceOption3()
    {
        TextBox.GetComponent<Text>().text = "3";
        ChoiceMade = 3;
    }


    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade == 1)
        {
            GameObject.Find("Option 2").GetComponentInChildren<Text>().text = "No.";
            TextBox.GetComponent<Text>().text = "Do you have an appointment?";
        }
        else if (ChoiceMade == 2)
        {
            GameObject.Find("Option 2").GetComponentInChildren<Text>().text = "No.";
            TextBox.GetComponent<Text>().text = "Do you have an appointment?";
        }
    }
}
