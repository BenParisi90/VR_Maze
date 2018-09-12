using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messageFlow : MonoBehaviour {

    public List<GameObject> messages;

    public List<GameObject> finalSelections;

    List<GameObject> selections;

    int currentMessageIndex = -1;

    GameObject currentMessage;

    public GameObject smile;

    

	// Use this for initialization
	void Start () {

        selections = new List<GameObject>();

		foreach(GameObject obj in messages)
        {
            obj.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextMessage()
    {
        if(currentMessage != null)
        {
            currentMessage.SetActive(false);
        }
        currentMessageIndex++;
        currentMessage = messages[currentMessageIndex];
        currentMessage.SetActive(true);

        if(currentMessageIndex == 1)
        {
            smile.SetActive(false);
        }
    }

    public void StoreSelection(GameObject TargetChoice)
    {
        selections.Add(TargetChoice);
    }

    public void DisplaySelections()
    {
        for(int i = 0; i < finalSelections.Count; i++)
        {
            finalSelections[i].GetComponent<Renderer>().material = selections[i].GetComponent<Renderer>().material;
        }
    }
}
