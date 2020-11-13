using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    public Text inputField1;
    public Text inputField2;
    
    public void GetName1(){
        NameManager.Instance.Player1Name = inputField1.text;
    }
    public void GetName2(){
        NameManager.Instance.Player2Name = inputField2.text;
    }
}
