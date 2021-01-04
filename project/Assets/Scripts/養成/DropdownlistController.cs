using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownlistController : MonoBehaviour
{
    // Start is called before the first frame update
    Dropdown Dropdown;
    void start(){
        Dropdown = GetComponent<Dropdown>();
        Dropdown.onValueChanged.AddListener(
            delegate{
                DropdownValueChanged(Dropdown);
            }
        );
    }

    void DropdownValueChanged(Dropdown change){
        //change.w;
    }

    /*void CreateDropdownList(){
        var rectTransform = this.transform as RectTransform;
        rectTransform.sizeDelta = new Vector2(9,400);
    }*/


}
