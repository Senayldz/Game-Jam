using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{

    private  void Awake()
   {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("Back").clicked += () => BackMenu();
   }

    void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
