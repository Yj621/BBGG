using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform을 저장할 변수

    public Vector3 offset; // 카메라와 플레이어 사이의 거리를 조절하기 위한 오프셋 값

    public float smoothSpeed = 0.125f; // 카메라 이동을 부드럽게 하기 위한 스무딩 속도

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // 플레이어의 위치에 오프셋 값을 더해 원하는 카메라 위치 계산

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // 현재 카메라 위치에서 원하는 위치까지 부드럽게 이동

        transform.position = smoothedPosition; // 카메라 위치 업데이트
    }
}
