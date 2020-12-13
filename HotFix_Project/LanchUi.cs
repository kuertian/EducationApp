using UnityEditor;
using UnityEngine;

namespace HotFix_Project
{
    public class LanchUi : Window
    {
        private LanchPanel m_LanchPanel;

        public override void Awake(object param1 = null,
        object param2 = null, object param3 = null)
        {
            m_LanchPanel = GameObject.GetComponent<LanchPanel>();
            AddButtonClickListener(m_LanchPanel.m_StartButton, OnClickStart);
            AddButtonClickListener(m_LanchPanel.m_LoadButton, OnClickLoad);            
            ObjectManager.Instance.InstantiateObject("Assets/GameData/Prefabs/Attack.prefab");
            ResourceManager.Instance.AsyncLoadResource("Assets/GameData/UGUI/Test1.png", OnLoadSpriteTest1, LoadResPriority.RES_MIDDLE, true);
            
            //LoadMonsterData();
        }

        public void OnClickStart()
        {
            Debug.Log("测试成功啦");
            m_LanchPanel.m_Slider.text = "测试成功啦";
        }
        public void OnClickLoad()
        {
            Debug.Log("牛皮！！！");
        }

        void OnLoadSpriteTest1(string path, Object obj, object param1 = null, object param2 = null, object param3 = null)
        {
            if (obj != null)
            {
                Sprite sp = obj as Sprite;
                m_LanchPanel.m_Test1.sprite = sp;
                //Debug.Log("图片1加载出来了~热更新2.0");
                Debug.Log("图片1加载出来了~suc!!!");

            }
        }
    }
}