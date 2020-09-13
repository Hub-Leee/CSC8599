using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMove : MonoBehaviour
{
    private bool isMove;
    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        isMove = false;
        btn = GetComponent<Button>();
        btn.onClick.AddListener(mouseDown);
    }
    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            transform.position = Input.mousePosition;
        }
        else
        {
            //ToDo
            transform.Translate(Vector3.left * Time.deltaTime * GameCtrol.ins.itemMoveSpeed);
        }
    }
    private void mouseDown()
    {
        isMove = true;
    }
}
