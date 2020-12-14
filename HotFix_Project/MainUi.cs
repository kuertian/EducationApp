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
            //DatingPanel
            AddButtonClickListener(m_MainWinPanel.m_ZuoYeButton, OnZuoYeButton);
            AddButtonClickListener(m_MainWinPanel.m_AutoCreateButton, OnAutoCreateButton);
            AddButtonClickListener(m_MainWinPanel.m_TuoZhanClassButton, OnTuoZhanClassButton);
            AddButtonClickListener(m_MainWinPanel.m_CuoTingBenButton, OnCuoTingBenButton);
            AddButtonClickListener(m_MainWinPanel.m_TouXiangButton, OnTouXiangButton);
            AddButtonClickListener(m_MainWinPanel.m_SetButton, OnSetButton);
            AddButtonClickListener(m_MainWinPanel.m_EnterClassButton, OnEnterClassButton);

            //SetPanel
            AddButtonClickListener(m_MainWinPanel.m_CloseButton, OnCloseButton);
            AddButtonClickListener(m_MainWinPanel.m_ChangeButton, OnChangeButton);
            AddButtonClickListener(m_MainWinPanel.m_QuitButton, OnQuitButton);
            AddButtonClickListener(m_MainWinPanel.m_FullButton, OnFullButton);
            AddButtonClickListener(m_MainWinPanel.m_WindButton, OnWindButton);

            //InfomationPanel
            AddButtonClickListener(m_MainWinPanel.m_InfoCloneButton, OnInfoCloneButton);
            AddButtonClickListener(m_MainWinPanel.m_SaveButton, OnSaveButton);

            //ClassListPanel

            //ZuoYePanel
            AddButtonClickListener(m_MainWinPanel.m_ZuoYeCloseButton, OnZuoYeCloseButton);
            AddButtonClickListener(m_MainWinPanel.m_ZuoYeChangeClassButton, OnZuoYeChangeClassButton);
            AddButtonClickListener(m_MainWinPanel.m_GoClassButton, OnGoClassButton);
            AddButtonClickListener(m_MainWinPanel.m_Class1Button, OnClass1Button);

            //AutoCreatePanel
            AddButtonClickListener(m_MainWinPanel.m_AutoCreateCloseButton, OnAutoCreateCloseButton);
            AddButtonClickListener(m_MainWinPanel.m_AutoNewCreateButton, OnAutoNewCreateButton);
            AddButtonClickListener(m_MainWinPanel.m_AutoExpButton, OnAutoExpButton);

            //ZuoPingListPanel
            AddButtonClickListener(m_MainWinPanel.m_ZuoPinCloseButton, OnZuoPinCloseButton);
            ObjectManager.Instance.InstantiateObject("Assets/GameData/Prefabs/Attack.prefab");
            //ResourceManager.Instance.AsyncLoadResource("Assets/GameData/UGUI/Test1.png", OnLoadSpriteTest1, LoadResPriority.RES_MIDDLE, true);

            //LoadMonsterData();
            MainInit();
           
        }
        /// <summary>
        /// MainInit
        /// </summary>
        public void MainInit()
        {
            m_MainWinPanel.m_LanchPanel.SetActive(true);
            m_MainWinPanel.m_DaTingPanel.SetActive(false);
            m_MainWinPanel.m_SetPanel.SetActive(false);
            m_MainWinPanel.m_InformationPanel.SetActive(false);
            m_MainWinPanel.m_ClassListPanel.SetActive(false);
            m_MainWinPanel.m_ZuoYePanel.SetActive(false);
            m_MainWinPanel.m_AutoCreatePanel.SetActive(false);
            m_MainWinPanel.m_ZuoPingListPanel.SetActive(false);
        }

        /// <summary>
        /// LanchPanel
        /// </summary>
        public void LanchInit()
        {
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

        /// <summary>
        /// DaTingPanel
        /// </summary>
        public void DatingInit()
        {
            MainLog("datinginit！");
        }
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
            Application.Quit();
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
        /// <summary>
        /// ClassListPanel
        /// </summary>
        public void claass()
        { 
        
        }
        /// <summary>
        /// ZuoYePanel
        /// </summary>
        public void OnZuoYeCloseButton()
        { 
        
        }
        public void OnZuoYeChangeClassButton()
        {

        }
        public void OnGoClassButton()
        {

        }
        public void OnClass1Button()
        {

        }
        /// <summary>
        /// AutoCreatePanel
        /// </summary>
        public void OnAutoCreateCloseButton()
        {

        }
        public void OnAutoNewCreateButton()
        {

        }
        public void OnAutoExpButton()
        {

        }
        /// <summary>
        /// ZuoPingListPanel
        /// </summary>
        public void OnZuoPinCloseButton()
        {

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