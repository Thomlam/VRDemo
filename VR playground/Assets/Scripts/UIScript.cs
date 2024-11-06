using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
   private bool selected = false;
   private bool focused = false;
   private bool hovering = false;

   public TextMeshProUGUI UIScriptText;

   void Start()
   {
        UIScriptText.text = "nothing";
   }

    public void OnHoverAction(bool hovering){
        Debug.Log("onHoverAction "+hovering);
        this.hovering = hovering;
        if(!selected) {UIScriptText.text = "on hover"; this.hovering = hovering;}
        if(!hovering && !selected) UIScriptText.text = focused ? "on focused" : "nothing";
    }
    public void OnFocusAction(bool focused){
        Debug.Log("onFocusedAction "+focused);
        this.focused = focused;
        if(!selected && focused) {UIScriptText.text = "On FOCUS"; this.focused = focused;}
        else if(!focused) UIScriptText.text = "nothing";
    }
    public void OnSelectedAction(bool selected){
        Debug.Log("onSelectedACtion "+selected);
        this.selected = selected;
        UIScriptText.text = "OnSelected";
    }
}
