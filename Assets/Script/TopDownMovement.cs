using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5;
        _rigidbody2D.velocity = direction;
    }

    //private void Move(Vector2 direction)
    //{
    //    throw new NotImplementedException();
    //}
}





// test
//public float speed = 5f;

//private SpriteRenderer spriteRenderer;

//// Start is called before the first frame update
//void Start()
//{
//    spriteRenderer = GetComponent<SpriteRenderer>();
//}

//// Update is called once per frame
//void Update()
//{

//    float x = Input.GetAxisRaw("Horizontal");
//    float y = Input.GetAxisRaw("Vertical");

//    //Debug.Log($"{x},{y}");

//    transform.position += (new Vector3(x, y)).normalized * Time.deltaTime * speed;

//    Vector3 mousePos = Input.mousePosition;

//    Debug.Log(mousePos);

//    // 유니티 spriteRenderer 에 있는 flip 기능을 이용하여 캐릭터가 마우스 포인터를 쳐다보게 하기
//    // 마우스 포인터 보는 기준은 화면 너비을 반으로 나눠서 왼쪽 오른쪽으로 나눔
//    // 마우스 X 값 위치는 오른쪽으로 갈수록 커짐

//    if (mousePos.x > Screen.width / 2) //width= 1920
//    {
//        // 캐릭터가 기본으로 바라보는 방향은 오른쪽이니 플립 안함
//        spriteRenderer.flipX = false;

//    }
//    else if (mousePos.x < Screen.width / 2)
//    {

//        spriteRenderer.flipX = true;

//    }
//}
