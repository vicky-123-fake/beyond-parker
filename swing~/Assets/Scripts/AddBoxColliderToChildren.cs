using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBoxColliderToChildren : MonoBehaviour
{
    // 批量为子物体添加 BoxCollider
    void Start()
    {
        // 获取当前物体的所有子物体
        Transform[] children = GetComponentsInChildren<Transform>();

        // 遍历所有子物体
        foreach (Transform child in children)
        {
            // 跳过父物体本身
            if (child != transform)
            {
                // 检查子物体是否已经有 Collider 组件
                if (child.GetComponent<Collider>() == null)
                {
                    // 如果没有，添加 BoxCollider
                    child.gameObject.AddComponent<BoxCollider>();
                }
            }
        }

        Debug.Log("已为所有子物体添加 BoxCollider！");
    }
}
