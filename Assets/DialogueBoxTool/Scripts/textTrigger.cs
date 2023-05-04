using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerText ()
    {
        FindObjectOfType<DialogueManager>().StartText(dialogue);
    }

}
