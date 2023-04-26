using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class MovesButtonScript : MonoBehaviour
{
	int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
   }

   // Button buttonToHide;

//    void Start(){
//       buttonToHide = GetComponent<Button>();

//       buttonToHide.onClick.AddListener(() => HideButton());
//    }

//    void HideButton(){
//       buttonToHide.gameObject.setActive(false);
// }
}
