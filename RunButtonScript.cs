using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RunButtonScript : MonoBehaviour
{
    int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button Run clicked " + n + " times.");
   }
}
