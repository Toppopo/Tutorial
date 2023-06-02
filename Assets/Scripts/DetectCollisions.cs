using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    GameObject player;
    PlayerController pc;
    [SerializeField] int point;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//アタッチされている自分自身を消す
        Destroy(other.gameObject);//ぶつかった相手（other）を消す

        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.score = pc.score + 1;
        pc.SetCountText(point);
    }
}
