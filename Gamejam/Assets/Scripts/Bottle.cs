using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    private List<GameObject> materials = new List<GameObject>();

    public void AddMaterial(GameObject material)
    {
        materials.Add(material);
        // 将材料放入酒瓶，可以在这里实现你的逻辑
    }
}