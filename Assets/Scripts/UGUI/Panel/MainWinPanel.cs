using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainWinPanel : MonoBehaviour
{
    public GameObject m_LanchPanel;
    public GameObject m_DaTingPanel;
    public GameObject m_SetPanel;
    public GameObject m_InformationPanel;
    public GameObject m_ClassListPanel;
    public GameObject m_ZuoYePanel;
    public GameObject m_AutoCreatePanel;
    public GameObject m_ZuoPingListPanel;

    //LanchPanel
    public Button m_SignButton;
    public Button m_LoginButton;
    public Button m_SibmitButton;

    public Image i_SignPanelTips;
    public Image i_LoginPanelTips;

    public InputField i_InputFieldName;
    public InputField i_InputFieldNamePasswrod;

    //DatingPanel
    public Button m_ZuoYeButton;
    public Button m_AutoCreateButton;
    public Button m_TuoZhanClassButton;
    public Button m_CuoTingBenButton;
    public Button m_TouXiangButton;
    public Button m_SetButton;
    public Button m_EnterClassButton;

    public Text m_zuoyeText;
    public Text m_autoText;
    public Text m_classText;
    public Text m_cuotibenText;

    //SetPanel
    public Button m_CloseButton;
    public Button m_ChangeButton;
    public Button m_QuitButton;
    public Button m_FullButton;
    public Button m_WindButton;

    //InfomationPanel
    public Button m_InfoCloneButton;
    public Button m_SaveButton;

    public Image m_TouXiangImage;
    public InputField m_InputFieldNC;
    public InputField m_InputFieldName;
    public Toggle m_ManToggle;
    public Toggle m_WomenToggle;
    
    //ClassListPanel

}
