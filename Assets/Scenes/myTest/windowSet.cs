using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowSet : MonoBehaviour
{
    public GameObject ScrollView;
    public GameObject Content;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick1920()
    {
        ResolutionRatio(3);
    }
    public void Onclick1280()
    {
        ResolutionRatio(2);
    }
    public void Onclick640()
    {
        ResolutionRatio(1);
    }
    public void OnclickRatio()
    {
        ResolutionRatio(0);
    }
    public void ResolutionRatio(int value)
    {
        // Debug.Log(value);

        PlayerPrefs.SetInt("ResolutionRatio", value);
        switch (value)
        {
            case 0:
                if (PlayerPrefs.HasKey("resolutionsW"))
                {
                    Screen.SetResolution(PlayerPrefs.GetInt("resolutionsW"), PlayerPrefs.GetInt("resolutionsH"), true);

                }
                break;
            case 1:
                Screen.SetResolution(640, 480, true);
                break;
            case 2:
                Screen.SetResolution(1280, 720, true);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, true);
                break;

            default:
                break;
        }
    }
    public void GameObjectClick()
    {
        for (int i = 0; i < 15; i++)
        {
            GameObject gb = Instantiate(UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/GameData/Prefabs/UGUI/Panel/Image.prefab", typeof(GameObject))) as GameObject;
            var transform = gb.gameObject.GetComponent<Transform>();
            transform.parent = Content.transform;
            //transform.position = new Vector3(0, 0, 0);
            //transform.localScale = new Vector3(1, 1, 1);


            var m_scroll=ScrollView.GetComponent<FScrollPage.FScrollPage>();
            m_scroll.Init();
        }
    }
}
