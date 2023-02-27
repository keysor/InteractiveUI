using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UI_ColorPicker : MonoBehaviour
{
    public GameObject target;
    private Material targetMaterial;
    private GraphicRaycaster rc;
    private PointerEventData pt;
    private EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        if(target != null)
        {
            targetMaterial = target.GetComponent<Renderer>().material;
        }
        rc = GetComponent<GraphicRaycaster>();
        eventSystem = GetComponent<EventSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        pt = new PointerEventData(eventSystem);
        pt.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        rc.Raycast(pt, results);  

        foreach(RaycastResult swatch in results)
        {
            if(swatch.gameObject.GetComponent<Image>().color != null)
            {
                changeColor(swatch.gameObject.GetComponent<Image>().color);
            }
        }    
    }

    void changeColor(Color c)
    {
        targetMaterial.color = c;
    }
}
