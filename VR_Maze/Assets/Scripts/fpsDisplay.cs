using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsDisplay : MonoBehaviour {

    TMPro.TextMeshPro fpsText;

	// Use this for initialization
	void Start () {
        fpsText = gameObject.GetComponent<TMPro.TextMeshPro>();
    }
	
	// Update is called once per frame
	void Update () {
        fpsText.text = (1.0f / Time.smoothDeltaTime).ToString();

    }
}
