using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamRender : MonoBehaviour
{
    void LateUpdate()
    {
        // Player는 싱글톤이기에 전역적으로 접근할 수 있습니다.
        Vector3 direction = (PlayerManager.instance.player.transform.position - transform.position).normalized;
        RaycastHit[] hits = Physics.RaycastAll(transform.position, direction, Mathf.Infinity,
                            1 << LayerMask.NameToLayer("EnvironmentObject"));


        for (int i = 0; i < hits.Length; i++)
        {
            //TransparentObject[] obj = hits[i].transform.GetComponentsInChildren<TransparentObject>();

            TransparentObject[] obj = hits[i].transform.GetComponentsInParent<TransparentObject>();
            for (int j = 0; j < obj.Length; j++)
            {
                obj[j]?.BecomeTransparent();
            }
        }
    }
}
