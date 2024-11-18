using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    [Header("Teleport Position")]
    public Transform teleportPosition; // 텔레포트 할 위치

    // 플레이어 Teleport
    public void TeleportPlayer(Transform playerTransform)
    {
        // 트리거와 플레이어의 상대적인 위치 계산하여 이동(끊기는 느낌 안나게)
        Vector3 playerOffset = playerTransform.position - transform.position;
        playerTransform.position = teleportPosition.position + playerOffset;
    }

    // 플레이어가 트리거에 들어갔을 때
    private void OnTriggerEnter(Collider hitobject)
    {
        if (hitobject.CompareTag("TestPlayer"))
        {
            Transform playerTransform = hitobject.transform;
            TeleportPlayer(playerTransform);
        }
    }
}
