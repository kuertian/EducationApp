using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
//using LitJson;
namespace HotFix_Project
{
    public class MainUi : Window
    {

        //Url
        private string DomainName = "http://v8zs.user.kesion.com";
        private string LoginUrl = "/webapi/user/login";

        private   MainWinPanel m_MainWinPanel;
        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

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
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                m_MainWinPanel.m_LoginTipsText.text = "账号和密码不能为空！";
                return;
            }

            Dictionary<string, string> loginDic = new Dictionary<string, string>();
            loginDic.Add("username", name);
            loginDic.Add("password", password);

            string url = DomainName + LoginUrl;
            string result = Post(url, loginDic);
            if (!string.IsNullOrEmpty(result))
            {
                MainLog(result.ToString());
                //JsonData jsondata = JsonMapper.ToObject(result);
                //if (jsondata != null)
                //{
                //    bool _result=(bool)jsondata["result"];
                //    if (_result == true)
                //    {
                //        MainLog("登陆成功！");
                //    }
                //    else
                //    { 
                //        m_MainWinPanel.m_LoginTipsText.text= jsondata["msg"].ToString();
                //    }
                //}
            }

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