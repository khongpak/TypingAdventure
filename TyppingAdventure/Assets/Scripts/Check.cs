using TMPro;
using UnityEngine;

public class Check : MonoBehaviour
{
    public TextMeshPro textShow;
    private string textString;
  
    // Update is called once per frame
    void Update()
    {
        // ตรวจสอบว่าใน Frame นี้มีการกดปุ่มตัวอักษรหรือไม่
        if (Input.inputString.Length > 0)
        {
            foreach (char c in Input.inputString)
            {
                textString = textString + c;
                if (c == '\b') // ถ้าเป็น Backspace (ปุ่มลบ)
                {
                    Debug.Log("คุณกดลบค่ะ");
                }
                else if ((c == '\n') || (c == '\r')) // ถ้าเป็น Enter หรือ Return
                {
                    Debug.Log("คุณกดตกลงค่ะ");
                }
                else
                {
                    Debug.Log("คุณพิมพ์ตัวอักษร: " + c);
                }
            }
            textShow.text = textString;
            
        }
        
    }
}
