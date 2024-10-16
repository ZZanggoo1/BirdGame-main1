using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public float speed=2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Vertical"))
        {
            speed += 1;
        }

        if (Input.GetButtonDown("Vertical"))
        {
            speed -= 1;
        }
    }
    // ȭ��ǥ ���� ��ư�� �̿��Ͽ� speed�� ������ �� �ֵ��� ����

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);

        if (transform.position.x<-10)
        {
            Destroy(gameObject);
        }
    }

}
