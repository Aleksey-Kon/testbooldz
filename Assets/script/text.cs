using UnityEngine;
using TMPro;
public class text : MonoBehaviour
{
    public TMP_Text TEXT;
    public static float timer;
    private void Update() {
        timer += Time.deltaTime;
        TEXT.text = timer.ToString();
    }
}
