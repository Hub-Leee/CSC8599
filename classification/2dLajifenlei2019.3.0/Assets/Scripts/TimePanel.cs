using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePanel : MonoBehaviour
{
    public GameObject winPanel;
    void Update()
    {
        GameCtrol.ins.gameTimer -= Time.deltaTime;
        if (GameCtrol.ins.gameTimer <= 0)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
