using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public GameObject textObject;
    // Start is called before the first frame update
    void Start()
    {
        textObject = GameObject.Find("NameText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        
        MenuData.Instance.name = textObject.GetComponent<InputField>().text;
        SceneManager.LoadScene(1);
    }
}
