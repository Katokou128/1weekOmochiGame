using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUpPoint : MonoBehaviour
{
    public Text pointText = default;

    // Start is called before the first frame update
    void Start()
    {
        pointText = GetComponent<Text>();
        pointText.text = PointManager.point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
