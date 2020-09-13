using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameCtrol : MonoBehaviour
{

    public float gameTimer;
    public int itemMoveSpeed;
    public float timer;
    public int score;
    public int mistake;
    public AudioSource bgAudio;
    public AudioSource yesAudio;
    public AudioSource noAudio;
    public GameObject[] item;
    public Transform[] pos;
    public Transform[] parent;
    public int indexParent;
    public Transform desPos;
    private int indexItem;
    private int indexPos;
    private bool isIns;
    private float time;
    public static GameCtrol ins;
    private void Awake()
    {
        isIns = false;
        ins = this;
    }
    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime;
        if (time > timer)
        {
            isIns = true;
            time = 0;
        }
        else
        {
            isIns = false;
        }
        insItem();
    }
    public void insItem() {
        if (isIns)
        {
            indexItem = Random.Range(0, item.Length);
            indexPos = Random.Range(0, pos.Length);
            GameObject prefabs = Instantiate(item[indexItem], pos[indexPos].position, pos[indexPos].rotation);
            prefabs.transform.parent = parent[indexParent];
        }
    }
}
