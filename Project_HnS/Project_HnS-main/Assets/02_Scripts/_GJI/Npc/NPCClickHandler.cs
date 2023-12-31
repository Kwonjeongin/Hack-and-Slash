
using UnityEngine;

public class NPCClickHandler : MonoBehaviour
{
    public GameObject uiObject; // ?μ±?ν  UI ?μ

    //public Vector3 uiOffset;   // NPC?μ??UI ?€ν??

    public string npcID;        // NPC??κ³ μ ???λ³??

    public bool isUIActive = false;

    private void Start()
    {
        // UI ?μλ₯?μ΄κΈ°??λΉν?±ν
        uiObject.SetActive(false);
    }

    private void Update()
    {
        if (Camera.main != null)
            uiObject.transform.forward = Camera.main.transform.forward;
    }

    public void ToggleUI()
    {
        isUIActive = !isUIActive;

        Debug.Log(gameObject.name + ", " + (uiObject == null) );
        uiObject.SetActive(isUIActive);


    }
}