using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField varA;
     public InputField varB;
     public Button btn_reset;
     public Button btn_subNumbers;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private int SubNumbers()
    {
        int a = int.Parse(varA.text);
        int b = int.Parse(varB.text);
        return a - b;
    }
    public void SetResult()
    {
        result.text = SubNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        btn_subNumbers.interactable = false;
        btn_reset.interactable = true;
    }
    public void ResetGui()

    {
        result.text = "Result";
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        btn_subNumbers.interactable = true;
        btn_reset.interactable = false;
    }
}
