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

//    // ����Ƽ spriteRenderer �� �ִ� flip ����� �̿��Ͽ� ĳ���Ͱ� ���콺 �����͸� �Ĵٺ��� �ϱ�
//    // ���콺 ������ ���� ������ ȭ�� �ʺ��� ������ ������ ���� ���������� ����
//    // ���콺 X �� ��ġ�� ���������� ������ Ŀ��

//    if (mousePos.x > Screen.width / 2) //width= 1920
//    {
//        // ĳ���Ͱ� �⺻���� �ٶ󺸴� ������ �������̴� �ø� ����
//        spriteRenderer.flipX = false;

//    }
//    else if (mousePos.x < Screen.width / 2)
//    {

//        spriteRenderer.flipX = true;

//    }
//}
