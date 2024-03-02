using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gameoverscreen : MonoBehaviour
{
    public Text pointsText;
   public void Setup(int count)
   {
       gameObject.SetActive(true);
pointsText.text= count.ToString()+ "POINTS";

   }
}
