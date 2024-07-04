using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   private  void Awake()
   {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("Start").clicked += () => GameStart();
        root.Q<Button>("Credits").clicked += () => Credits();
        root.Q<Button>("Quit").clicked += () => Quit();
   }

   void GameStart()
   {
        SceneManager.LoadScene("Game");
   }
    void Credits()
   {
        SceneManager.LoadScene("Credits");
   }

   void Quit()
   {

      Application.Quit();
      
   }
}
