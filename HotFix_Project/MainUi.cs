using UnityEditor;
using UnityEngine;

namespace HotFix_Project
{
    public class MainUi : Window
    {
        private   MainWinPanel m_MainWinPanel;

        public override void Awake(object param1 = null,
        object param2 = null, object param3 = null)
        {
            m_MainWinPanel = GameObject.GetComponent<MainWinPanel>();
            AddButtonClickListener(m_MainWinPanel.m_SignButton, OnSignButton);
            AddButtonClickListener(m_MainWinPanel.m_LoginButton, OnLoginButton);
            AddButtonClickListener(m_MainWinPanel.m_SibmitButton, OnSibmitButton);

            AddButtonClickListener(m_MainWinPanel.m_ZuoYeButton, OnZuoYeButton);
            AddButtonClickListener(m_MainWinPanel.m_AutoCreateButton, OnAutoCreateButton);
            AddButtonClickListener(m_MainWinPanel.m_TuoZhanClassButton, OnTuoZhanClassButton);
            AddButtonClickListener(m_MainWinPanel.m_CuoTingBenButton, OnCuoTingBenButton);
            AddButtonClickListener(m_MainWinPanel.m_TouXiangButton, OnTouXiangButton);
            AddButtonClickListener(m_MainWinPanel.m_SetButton, OnSetButton);
            AddButtonClickListener(m_MainWinPanel.m_EnterClassButton, OnEnterClassButton);

            ObjectManager.Instance.InstantiateObject("Assets/GameData/Prefabs/Attack.prefab");
            //ResourceManager.Instance.AsyncLoadResource("Assets/GameData/UGUI/Test1.png", OnLoadSpriteTest1, LoadResPriority.RES_MIDDLE, true);

            //LoadMonsterData();

            m_MainWinPanel.i_SignPanelTips.gameObject.SetActive(false);
            m_MainWinPanel.i_LoginPanelTips.gameObject.SetActive(true);
        }
        public void OnSignButton()
        {
            m_MainWinPanel.i_SignPanelTips.gameObject.SetActive(true);
            m_MainWinPanel.i_LoginPanelTips.gameObject.SetActive(false);
        }
        public void OnLoginButton()
        {
            m_MainWinPanel.i_SignPanelTips.gameObject.SetActive(false);
            m_MainWinPanel.i_LoginPanelTips.gameObject.SetActive(true);
        }
        public void OnSibmitButton()
        {
            string name = m_MainWinPanel.i_InputFieldName.text;
            string password = m_MainWinPanel.i_InputFieldNamePasswrod.text;

            MainLog("登陆！"+name+" "+password);
        }

        //DatingPanel
        public void OnZuoYeButton()
        {
            MainLog("作业！");
        }
        public void OnAutoCreateButton()
        {
            MainLog("自由创作！");
        }
        public void OnTuoZhanClassButton()
        {
            MainLog("拓展！");
        }
        public void OnCuoTingBenButton()
        {
            MainLog("错题！");
        }
        public void OnTouXiangButton()
        {
            MainLog("头像！");
        }
        public void OnSetButton()
        {
            MainLog("设置！");
        }
        public void OnEnterClassButton()
        {
            MainLog("进入课程！");
        }

        /// <summary>
        /// SetPanel
        /// </summary>
        public void OnCloseButton()
        {
            MainLog("关闭设置！");
        }
        public void OnChangeButton()
        {
            MainLog("切换账号！");
        }
        public void OnQuitButton()
        {
            MainLog("退出程序！");
        }
        public void OnFullButton()
        {
            MainLog("全屏模式！");
        }
        public void OnWindButton()
        {
            MainLog("窗口模式！");
        }
        /// <summary>
        /// InfomationPanel
        /// </summary>
        public void OnInfoCloneButton()
        {
            MainLog("关闭个人信息面板！");
        }
        public void OnSaveButton()
        {
            MainLog("保存个人信息修改！");
        }

        public void OnClickStart()
        {
            //MainLog("测试成功啦");
            //m_LanchPanel.m_Slider.text = "测试成功啦";
        }
        public void MainLog(string log)
        {
            Debug.Log(log);
        }
    }
}