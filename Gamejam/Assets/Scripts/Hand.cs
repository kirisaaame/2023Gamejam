using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // 获取鼠标当前的屏幕坐标
        Vector3 mousePosition = Input.mousePosition;

        // 将鼠标屏幕坐标转换为世界坐标
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 设置Hand的位置为鼠标的世界坐标位置
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
