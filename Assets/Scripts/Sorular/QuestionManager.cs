using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class QuestionManager : MonoBehaviour
{
    public Questions[] sorular;
    public GameObject QuesPanel;
    public Button[] Buttons;
    public TextMeshProUGUI Ques;
    public TextMeshProUGUI[] Answers;

    public TextMeshProUGUI score;

    public int dogruCevap;

    public int deger = 0;

    public ClockController _speed;

    private float scoreVal = 0;
    public AudioSource[] audioSource;

    void Update()   
    {
        scoreVal += Time.deltaTime * _speed.Speed;
        float score1 = (int)scoreVal;
        score.text = score1.ToString();
    }
    public void cevap()
    {
        if(sorular[deger].correctAnswerIndex == dogruCevap)
        {
            QuesPanel.SetActive(false);
            Time.timeScale=1;
            audioSource[0].Play();
            audioSource[1].Play();
        }
        else
        {
            _speed.Speed+=5;
            QuesPanel.SetActive(false);
            Time.timeScale=1;
            audioSource[0].Play();
            audioSource[1].Play();
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Yelkovan")
        {
            sorularGame();
        }
    }

    public void buton1(){
        dogruCevap=0;
    }
        public void buton2(){
        dogruCevap=1;
    }
        public void buton3(){
        dogruCevap=2;
    }
        public void buton4(){
        dogruCevap=3;
    }

    void sorularGame()
    {

        Time.timeScale=0;
            audioSource[0].Pause();
            audioSource[1].Pause();
            deger = Random.Range(0,18);
            Ques.text = sorular[deger].questionText;
            Answers[0].text = sorular[deger].answers[0];
            Answers[1].text = sorular[deger].answers[1];
            Answers[2].text = sorular[deger].answers[2];
            Answers[3].text = sorular[deger].answers[3];
            QuesPanel.SetActive(true);
    }

}
