using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject DialogueBox;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Receptionist Dialogue Started");
        DialogueBox.SetActive(false);
    }
}
