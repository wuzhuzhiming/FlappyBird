using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float speed = 200f;

    // 如果 MonoBehaviour 已启用，则在每一帧都调用 Update
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if ((transform as RectTransform).anchoredPosition.x <= -767)
        {
            (transform as RectTransform).anchoredPosition = new Vector2(767f, 0);
        }
    }
}
