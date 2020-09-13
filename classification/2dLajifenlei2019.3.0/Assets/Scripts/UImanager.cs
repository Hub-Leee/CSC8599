using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject levelPanel;
    public GameObject timePanel;
    public GameObject mixPanel;
    public GameObject singlePanel;
    public GameObject foodPanel;
    public GameObject hazPanel;
    public GameObject recyPanel;
    public GameObject residPanel;
    public GameObject bgmPanel;
    public GameObject winPanel;
    public GameObject pausePanel;
    public Text scre;
    public Text mistake;
    public Text scre1;
    public Text mistake1;
    public Slider audio;
    public Text gameTimer;
    public void startBtn() {
        startPanel.SetActive(false);
        levelPanel.SetActive(true);
    }
    public void bgmBtn()
    {
        bgmPanel.SetActive(true);
    }
    public void tostartBtn()
    {
        SceneManager.LoadScene(0);
        for (int i = 0; i < GameCtrol.ins.parent.Length; i++)
        {
            for (int j = 0; j < GameCtrol.ins.parent[i].childCount; j++)
            {
                Destroy(GameCtrol.ins.parent[i].GetChild(j).gameObject);
            }
        }
    }
    public void exitBtn()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#else

            Application.Quit();

#endif
    }
    public void mixBtn() {
        GameCtrol.ins.indexParent = 0;
        Time.timeScale = 1;
        levelPanel.SetActive(false);
        timePanel.SetActive(true);
        mixPanel.SetActive(true);
    }
    public void singleBtn()
    {
        levelPanel.SetActive(false);
        singlePanel.SetActive(true);
    }
    public void pauseBtn() {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void playBtn()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void bgnBack() {
        bgmPanel.SetActive(false);
    }
    public void foodBtn() {
        GameCtrol.ins.indexParent = 1;
        Time.timeScale = 1;
        singlePanel.SetActive(false);
        timePanel.SetActive(true);
        foodPanel.SetActive(true);
    }
    public void hazBtn()
    {
        GameCtrol.ins.indexParent = 2;
        Time.timeScale = 1;
        singlePanel.SetActive(false);
        timePanel.SetActive(true);
        hazPanel.SetActive(true);
    }
    public void recyBtn()
    {
        GameCtrol.ins.indexParent = 3;
        Time.timeScale = 1;
        singlePanel.SetActive(false);
        timePanel.SetActive(true);
        recyPanel.SetActive(true);
    }
    public void residBtn()
    {
        GameCtrol.ins.indexParent = 4;
        Time.timeScale = 1;
        singlePanel.SetActive(false);
        timePanel.SetActive(true);
        residPanel.SetActive(true);
    }
    void Update()
    {
        scre.text = "Score:" + GameCtrol.ins.score;
        mistake.text="Mistake:"+ GameCtrol.ins.mistake;
        scre1.text = "Score:" + GameCtrol.ins.score;
        mistake1.text = "Mistake:" + GameCtrol.ins.mistake;
        gameTimer.text = "Time:" + (int)GameCtrol.ins.gameTimer + "s";
        GameCtrol.ins.bgAudio.volume = audio.value;
        GameCtrol.ins.yesAudio.volume = audio.value;
        GameCtrol.ins.noAudio.volume = audio.value;
    }
}
