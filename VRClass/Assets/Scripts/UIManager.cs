using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //public GameObject ButtonGameObject;
    public Button button;
    public InputField input;

    // Start is called before the first frame update
    void Start()
    {
        //Button button = ButtonGameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClicked()
    {
        Debug.Log("don't click me!");
    }

    public void OnInputChange()
    {
        Debug.Log(input.text);
    }

    public void OnInputText(string text)
    {
        Debug.Log(text);
    }
}
