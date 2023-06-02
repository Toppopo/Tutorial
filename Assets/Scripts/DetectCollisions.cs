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
        Destroy(gameObject);//�A�^�b�`����Ă��鎩�����g������
        Destroy(other.gameObject);//�Ԃ���������iother�j������

        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.score = pc.score + 1;
        pc.SetCountText(point);
    }
}
