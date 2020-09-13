using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == collision.gameObject.tag)
        {
            GameCtrol.ins.mistake++;
            GameCtrol.ins.noAudio.Play();
        }
        Destroy(collision.gameObject);
    }
}
