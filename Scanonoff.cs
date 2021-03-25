
using UnityEngine;
using UnityEngine.UI;
using MRTKExtensions.QRCodes;

public class Scanonoff : MonoBehaviour
{
    public GameObject QRcodescan;
    //public GameObject QRcodescan1;
    //public GameObject TRYT;
    public bool scann = true;
    public Text textscan;
    // Start is called before the first frame update
    void Start()
    {
        QRcodescan = GameObject.Find("Trackers");
    }
    public void scan()

    {
        textscan.text = "掃描開啟中";
        
        //QRcodescan1 = GameObject.Find("Tracker2");
        //TRYT = GameObject.Find("JetHolder");
        if (scann == true)
        {
            QRcodescan.SetActive(false);
            //QRcodescan1.GetComponent<QRTrackerController>().enabled = false;
            //TRYT.GetComponent<JetController>().enabled = false;
            //TRYT.GetComponent<JetController2>().enabled = false;
            scann = false;
            textscan.text = "掃描關閉中";
        }
        else
        {
            QRcodescan.SetActive(true);
            // QRcodescan1.GetComponent<QRTrackerController>().enabled = true;
            // TRYT.GetComponent<JetController>().enabled = true;
            //TRYT.GetComponent<JetController2>().enabled = true;
            scann = true;
            textscan.text = "掃描開啟中";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
