// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class TextInput : MonoBehaviour
// {
	
// 	public InputField height_input;

//     public void ChangeHeight () {
//     	float height = Convert.ToSingleheight_input.text;
//     	t = GetComponent<Transform>();
//     	t.transform.position = new Vector2(t.position[0], height);
//     }


// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInput : MonoBehaviour {
	private TMP_InputField input;
	private Transform t;

    void Start ()
    {
    	t = GameObject.FindWithTag("Moving").GetComponent<Transform>();
        input = GetComponent<TMP_InputField>(); 
        var se = new TMP_InputField.SubmitEvent();
        se.AddListener(ChangeHeight);
        input.onEndEdit = se;

        //or simply use the line below, 
        // input.onEndEdit.AddListener(SubmitName);  // This also works
    }

    private void ChangeHeight(string height_input)
    {
    	float height = System.Convert.ToSingle(height_input);
    	t.transform.position = new Vector2(t.position[0], height);
    }
}

