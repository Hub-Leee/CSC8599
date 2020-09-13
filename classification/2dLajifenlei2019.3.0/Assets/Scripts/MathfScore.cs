using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag==collision.gameObject.tag)
        {
            GameCtrol.ins.score++;
            GameCtrol.ins.yesAudio.Play();
            Destroy(collision.gameObject);
        }
        else
        {
            GameCtrol.ins.mistake++;
            GameCtrol.ins.noAudio.Play();
            Destroy(collision.gameObject);
        }
    }
}
