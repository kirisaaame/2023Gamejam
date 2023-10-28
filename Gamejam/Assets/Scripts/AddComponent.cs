using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComponent : MonoBehaviour
{
    // 物料名称
    public string materialName;

    // 液体颜色
    public Color liquidColor;

    // 液体当前流速
    public float currentFlowRate;

    // 液体流速上限
    public float maxFlowRate;

    // 液体流速下限
    public float minFlowRate;

    // 瓶子晃动频率
    public float shakeFrequency;

    // 瓶子晃动速度
    public float shakeSpeed;

    // 晃动速度上限
    public float maxShakeSpeed;

    // 晃动速度下限
    public float minShakeSpeed;

    // 挤压力的大小
    public float squeezeForce;

    // 是否被抓取
    public bool isGrabbed;

    // 是否按住按键
    public bool isButtonPressed;

    // 在这里你可以添加其他方法和属性
    private void Start()
    {
        
    }
    private void Update()
    {
        // 获取PlayController的isGrabbing属性
        bool isGrabbing = GetComponent<PlayerController>().isGrabbing;

        if (isGrabbing)
        {
            // 获取材料的物料名称
            materialName = GetComponent<Material>().materialName;
        }
    }
}
