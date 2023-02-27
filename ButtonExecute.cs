using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonExecute : MonoBehaviour
{
    // Start is called before the first frame update
    public Button startButton;
    void Start()
    {
        startButton.onClick.Invoke();
        startButton.OnPointerEnter(new PointerEventData(EventSystem.current));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
