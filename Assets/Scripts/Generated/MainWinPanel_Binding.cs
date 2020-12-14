using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class MainWinPanel_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::MainWinPanel);

            field = type.GetField("m_SignButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_SignButton_0);
            app.RegisterCLRFieldSetter(field, set_m_SignButton_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_SignButton_0, AssignFromStack_m_SignButton_0);
            field = type.GetField("m_LoginButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_LoginButton_1);
            app.RegisterCLRFieldSetter(field, set_m_LoginButton_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_LoginButton_1, AssignFromStack_m_LoginButton_1);
            field = type.GetField("m_SibmitButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_SibmitButton_2);
            app.RegisterCLRFieldSetter(field, set_m_SibmitButton_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_SibmitButton_2, AssignFromStack_m_SibmitButton_2);
            field = type.GetField("m_ZuoYeButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_ZuoYeButton_3);
            app.RegisterCLRFieldSetter(field, set_m_ZuoYeButton_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ZuoYeButton_3, AssignFromStack_m_ZuoYeButton_3);
            field = type.GetField("m_AutoCreateButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_AutoCreateButton_4);
            app.RegisterCLRFieldSetter(field, set_m_AutoCreateButton_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_AutoCreateButton_4, AssignFromStack_m_AutoCreateButton_4);
            field = type.GetField("m_TuoZhanClassButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_TuoZhanClassButton_5);
            app.RegisterCLRFieldSetter(field, set_m_TuoZhanClassButton_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_TuoZhanClassButton_5, AssignFromStack_m_TuoZhanClassButton_5);
            field = type.GetField("m_CuoTingBenButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_CuoTingBenButton_6);
            app.RegisterCLRFieldSetter(field, set_m_CuoTingBenButton_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_CuoTingBenButton_6, AssignFromStack_m_CuoTingBenButton_6);
            field = type.GetField("m_TouXiangButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_TouXiangButton_7);
            app.RegisterCLRFieldSetter(field, set_m_TouXiangButton_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_TouXiangButton_7, AssignFromStack_m_TouXiangButton_7);
            field = type.GetField("m_SetButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_SetButton_8);
            app.RegisterCLRFieldSetter(field, set_m_SetButton_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_SetButton_8, AssignFromStack_m_SetButton_8);
            field = type.GetField("m_EnterClassButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_EnterClassButton_9);
            app.RegisterCLRFieldSetter(field, set_m_EnterClassButton_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_EnterClassButton_9, AssignFromStack_m_EnterClassButton_9);
            field = type.GetField("m_CloseButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_CloseButton_10);
            app.RegisterCLRFieldSetter(field, set_m_CloseButton_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_CloseButton_10, AssignFromStack_m_CloseButton_10);
            field = type.GetField("m_ChangeButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_ChangeButton_11);
            app.RegisterCLRFieldSetter(field, set_m_ChangeButton_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ChangeButton_11, AssignFromStack_m_ChangeButton_11);
            field = type.GetField("m_QuitButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_QuitButton_12);
            app.RegisterCLRFieldSetter(field, set_m_QuitButton_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_QuitButton_12, AssignFromStack_m_QuitButton_12);
            field = type.GetField("m_FullButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_FullButton_13);
            app.RegisterCLRFieldSetter(field, set_m_FullButton_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_FullButton_13, AssignFromStack_m_FullButton_13);
            field = type.GetField("m_WindButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_WindButton_14);
            app.RegisterCLRFieldSetter(field, set_m_WindButton_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_WindButton_14, AssignFromStack_m_WindButton_14);
            field = type.GetField("m_InfoCloneButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_InfoCloneButton_15);
            app.RegisterCLRFieldSetter(field, set_m_InfoCloneButton_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_InfoCloneButton_15, AssignFromStack_m_InfoCloneButton_15);
            field = type.GetField("m_SaveButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_SaveButton_16);
            app.RegisterCLRFieldSetter(field, set_m_SaveButton_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_SaveButton_16, AssignFromStack_m_SaveButton_16);
            field = type.GetField("m_ZuoYeCloseButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_ZuoYeCloseButton_17);
            app.RegisterCLRFieldSetter(field, set_m_ZuoYeCloseButton_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ZuoYeCloseButton_17, AssignFromStack_m_ZuoYeCloseButton_17);
            field = type.GetField("m_ZuoYeChangeClassButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_ZuoYeChangeClassButton_18);
            app.RegisterCLRFieldSetter(field, set_m_ZuoYeChangeClassButton_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ZuoYeChangeClassButton_18, AssignFromStack_m_ZuoYeChangeClassButton_18);
            field = type.GetField("m_GoClassButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_GoClassButton_19);
            app.RegisterCLRFieldSetter(field, set_m_GoClassButton_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_GoClassButton_19, AssignFromStack_m_GoClassButton_19);
            field = type.GetField("m_Class1Button", flag);
            app.RegisterCLRFieldGetter(field, get_m_Class1Button_20);
            app.RegisterCLRFieldSetter(field, set_m_Class1Button_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_Class1Button_20, AssignFromStack_m_Class1Button_20);
            field = type.GetField("m_AutoCreateCloseButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_AutoCreateCloseButton_21);
            app.RegisterCLRFieldSetter(field, set_m_AutoCreateCloseButton_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_AutoCreateCloseButton_21, AssignFromStack_m_AutoCreateCloseButton_21);
            field = type.GetField("m_AutoNewCreateButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_AutoNewCreateButton_22);
            app.RegisterCLRFieldSetter(field, set_m_AutoNewCreateButton_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_AutoNewCreateButton_22, AssignFromStack_m_AutoNewCreateButton_22);
            field = type.GetField("m_AutoExpButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_AutoExpButton_23);
            app.RegisterCLRFieldSetter(field, set_m_AutoExpButton_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_AutoExpButton_23, AssignFromStack_m_AutoExpButton_23);
            field = type.GetField("m_ZuoPinCloseButton", flag);
            app.RegisterCLRFieldGetter(field, get_m_ZuoPinCloseButton_24);
            app.RegisterCLRFieldSetter(field, set_m_ZuoPinCloseButton_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ZuoPinCloseButton_24, AssignFromStack_m_ZuoPinCloseButton_24);
            field = type.GetField("m_LanchPanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_LanchPanel_25);
            app.RegisterCLRFieldSetter(field, set_m_LanchPanel_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_LanchPanel_25, AssignFromStack_m_LanchPanel_25);
            field = type.GetField("m_DaTingPanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_DaTingPanel_26);
            app.RegisterCLRFieldSetter(field, set_m_DaTingPanel_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_DaTingPanel_26, AssignFromStack_m_DaTingPanel_26);
            field = type.GetField("m_SetPanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_SetPanel_27);
            app.RegisterCLRFieldSetter(field, set_m_SetPanel_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_SetPanel_27, AssignFromStack_m_SetPanel_27);
            field = type.GetField("m_InformationPanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_InformationPanel_28);
            app.RegisterCLRFieldSetter(field, set_m_InformationPanel_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_InformationPanel_28, AssignFromStack_m_InformationPanel_28);
            field = type.GetField("m_ClassListPanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_ClassListPanel_29);
            app.RegisterCLRFieldSetter(field, set_m_ClassListPanel_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ClassListPanel_29, AssignFromStack_m_ClassListPanel_29);
            field = type.GetField("m_ZuoYePanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_ZuoYePanel_30);
            app.RegisterCLRFieldSetter(field, set_m_ZuoYePanel_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ZuoYePanel_30, AssignFromStack_m_ZuoYePanel_30);
            field = type.GetField("m_AutoCreatePanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_AutoCreatePanel_31);
            app.RegisterCLRFieldSetter(field, set_m_AutoCreatePanel_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_AutoCreatePanel_31, AssignFromStack_m_AutoCreatePanel_31);
            field = type.GetField("m_ZuoPingListPanel", flag);
            app.RegisterCLRFieldGetter(field, get_m_ZuoPingListPanel_32);
            app.RegisterCLRFieldSetter(field, set_m_ZuoPingListPanel_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_ZuoPingListPanel_32, AssignFromStack_m_ZuoPingListPanel_32);
            field = type.GetField("i_SignPanelTips", flag);
            app.RegisterCLRFieldGetter(field, get_i_SignPanelTips_33);
            app.RegisterCLRFieldSetter(field, set_i_SignPanelTips_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_SignPanelTips_33, AssignFromStack_i_SignPanelTips_33);
            field = type.GetField("i_LoginPanelTips", flag);
            app.RegisterCLRFieldGetter(field, get_i_LoginPanelTips_34);
            app.RegisterCLRFieldSetter(field, set_i_LoginPanelTips_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_LoginPanelTips_34, AssignFromStack_i_LoginPanelTips_34);
            field = type.GetField("i_InputFieldName", flag);
            app.RegisterCLRFieldGetter(field, get_i_InputFieldName_35);
            app.RegisterCLRFieldSetter(field, set_i_InputFieldName_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_InputFieldName_35, AssignFromStack_i_InputFieldName_35);
            field = type.GetField("i_InputFieldNamePasswrod", flag);
            app.RegisterCLRFieldGetter(field, get_i_InputFieldNamePasswrod_36);
            app.RegisterCLRFieldSetter(field, set_i_InputFieldNamePasswrod_36);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_InputFieldNamePasswrod_36, AssignFromStack_i_InputFieldNamePasswrod_36);
            field = type.GetField("m_LoginTipsText", flag);
            app.RegisterCLRFieldGetter(field, get_m_LoginTipsText_37);
            app.RegisterCLRFieldSetter(field, set_m_LoginTipsText_37);
            app.RegisterCLRFieldBinding(field, CopyToStack_m_LoginTipsText_37, AssignFromStack_m_LoginTipsText_37);


        }



        static object get_m_SignButton_0(ref object o)
        {
            return ((global::MainWinPanel)o).m_SignButton;
        }

        static StackObject* CopyToStack_m_SignButton_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_SignButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_SignButton_0(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_SignButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_SignButton_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_SignButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_SignButton = @m_SignButton;
            return ptr_of_this_method;
        }

        static object get_m_LoginButton_1(ref object o)
        {
            return ((global::MainWinPanel)o).m_LoginButton;
        }

        static StackObject* CopyToStack_m_LoginButton_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_LoginButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_LoginButton_1(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_LoginButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_LoginButton_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_LoginButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_LoginButton = @m_LoginButton;
            return ptr_of_this_method;
        }

        static object get_m_SibmitButton_2(ref object o)
        {
            return ((global::MainWinPanel)o).m_SibmitButton;
        }

        static StackObject* CopyToStack_m_SibmitButton_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_SibmitButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_SibmitButton_2(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_SibmitButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_SibmitButton_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_SibmitButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_SibmitButton = @m_SibmitButton;
            return ptr_of_this_method;
        }

        static object get_m_ZuoYeButton_3(ref object o)
        {
            return ((global::MainWinPanel)o).m_ZuoYeButton;
        }

        static StackObject* CopyToStack_m_ZuoYeButton_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ZuoYeButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ZuoYeButton_3(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ZuoYeButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_ZuoYeButton_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_ZuoYeButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ZuoYeButton = @m_ZuoYeButton;
            return ptr_of_this_method;
        }

        static object get_m_AutoCreateButton_4(ref object o)
        {
            return ((global::MainWinPanel)o).m_AutoCreateButton;
        }

        static StackObject* CopyToStack_m_AutoCreateButton_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_AutoCreateButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_AutoCreateButton_4(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_AutoCreateButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_AutoCreateButton_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_AutoCreateButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_AutoCreateButton = @m_AutoCreateButton;
            return ptr_of_this_method;
        }

        static object get_m_TuoZhanClassButton_5(ref object o)
        {
            return ((global::MainWinPanel)o).m_TuoZhanClassButton;
        }

        static StackObject* CopyToStack_m_TuoZhanClassButton_5(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_TuoZhanClassButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_TuoZhanClassButton_5(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_TuoZhanClassButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_TuoZhanClassButton_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_TuoZhanClassButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_TuoZhanClassButton = @m_TuoZhanClassButton;
            return ptr_of_this_method;
        }

        static object get_m_CuoTingBenButton_6(ref object o)
        {
            return ((global::MainWinPanel)o).m_CuoTingBenButton;
        }

        static StackObject* CopyToStack_m_CuoTingBenButton_6(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_CuoTingBenButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_CuoTingBenButton_6(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_CuoTingBenButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_CuoTingBenButton_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_CuoTingBenButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_CuoTingBenButton = @m_CuoTingBenButton;
            return ptr_of_this_method;
        }

        static object get_m_TouXiangButton_7(ref object o)
        {
            return ((global::MainWinPanel)o).m_TouXiangButton;
        }

        static StackObject* CopyToStack_m_TouXiangButton_7(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_TouXiangButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_TouXiangButton_7(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_TouXiangButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_TouXiangButton_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_TouXiangButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_TouXiangButton = @m_TouXiangButton;
            return ptr_of_this_method;
        }

        static object get_m_SetButton_8(ref object o)
        {
            return ((global::MainWinPanel)o).m_SetButton;
        }

        static StackObject* CopyToStack_m_SetButton_8(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_SetButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_SetButton_8(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_SetButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_SetButton_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_SetButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_SetButton = @m_SetButton;
            return ptr_of_this_method;
        }

        static object get_m_EnterClassButton_9(ref object o)
        {
            return ((global::MainWinPanel)o).m_EnterClassButton;
        }

        static StackObject* CopyToStack_m_EnterClassButton_9(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_EnterClassButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_EnterClassButton_9(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_EnterClassButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_EnterClassButton_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_EnterClassButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_EnterClassButton = @m_EnterClassButton;
            return ptr_of_this_method;
        }

        static object get_m_CloseButton_10(ref object o)
        {
            return ((global::MainWinPanel)o).m_CloseButton;
        }

        static StackObject* CopyToStack_m_CloseButton_10(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_CloseButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_CloseButton_10(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_CloseButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_CloseButton_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_CloseButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_CloseButton = @m_CloseButton;
            return ptr_of_this_method;
        }

        static object get_m_ChangeButton_11(ref object o)
        {
            return ((global::MainWinPanel)o).m_ChangeButton;
        }

        static StackObject* CopyToStack_m_ChangeButton_11(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ChangeButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ChangeButton_11(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ChangeButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_ChangeButton_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_ChangeButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ChangeButton = @m_ChangeButton;
            return ptr_of_this_method;
        }

        static object get_m_QuitButton_12(ref object o)
        {
            return ((global::MainWinPanel)o).m_QuitButton;
        }

        static StackObject* CopyToStack_m_QuitButton_12(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_QuitButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_QuitButton_12(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_QuitButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_QuitButton_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_QuitButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_QuitButton = @m_QuitButton;
            return ptr_of_this_method;
        }

        static object get_m_FullButton_13(ref object o)
        {
            return ((global::MainWinPanel)o).m_FullButton;
        }

        static StackObject* CopyToStack_m_FullButton_13(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_FullButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_FullButton_13(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_FullButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_FullButton_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_FullButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_FullButton = @m_FullButton;
            return ptr_of_this_method;
        }

        static object get_m_WindButton_14(ref object o)
        {
            return ((global::MainWinPanel)o).m_WindButton;
        }

        static StackObject* CopyToStack_m_WindButton_14(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_WindButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_WindButton_14(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_WindButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_WindButton_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_WindButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_WindButton = @m_WindButton;
            return ptr_of_this_method;
        }

        static object get_m_InfoCloneButton_15(ref object o)
        {
            return ((global::MainWinPanel)o).m_InfoCloneButton;
        }

        static StackObject* CopyToStack_m_InfoCloneButton_15(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_InfoCloneButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_InfoCloneButton_15(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_InfoCloneButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_InfoCloneButton_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_InfoCloneButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_InfoCloneButton = @m_InfoCloneButton;
            return ptr_of_this_method;
        }

        static object get_m_SaveButton_16(ref object o)
        {
            return ((global::MainWinPanel)o).m_SaveButton;
        }

        static StackObject* CopyToStack_m_SaveButton_16(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_SaveButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_SaveButton_16(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_SaveButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_SaveButton_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_SaveButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_SaveButton = @m_SaveButton;
            return ptr_of_this_method;
        }

        static object get_m_ZuoYeCloseButton_17(ref object o)
        {
            return ((global::MainWinPanel)o).m_ZuoYeCloseButton;
        }

        static StackObject* CopyToStack_m_ZuoYeCloseButton_17(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ZuoYeCloseButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ZuoYeCloseButton_17(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ZuoYeCloseButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_ZuoYeCloseButton_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_ZuoYeCloseButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ZuoYeCloseButton = @m_ZuoYeCloseButton;
            return ptr_of_this_method;
        }

        static object get_m_ZuoYeChangeClassButton_18(ref object o)
        {
            return ((global::MainWinPanel)o).m_ZuoYeChangeClassButton;
        }

        static StackObject* CopyToStack_m_ZuoYeChangeClassButton_18(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ZuoYeChangeClassButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ZuoYeChangeClassButton_18(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ZuoYeChangeClassButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_ZuoYeChangeClassButton_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_ZuoYeChangeClassButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ZuoYeChangeClassButton = @m_ZuoYeChangeClassButton;
            return ptr_of_this_method;
        }

        static object get_m_GoClassButton_19(ref object o)
        {
            return ((global::MainWinPanel)o).m_GoClassButton;
        }

        static StackObject* CopyToStack_m_GoClassButton_19(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_GoClassButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_GoClassButton_19(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_GoClassButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_GoClassButton_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_GoClassButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_GoClassButton = @m_GoClassButton;
            return ptr_of_this_method;
        }

        static object get_m_Class1Button_20(ref object o)
        {
            return ((global::MainWinPanel)o).m_Class1Button;
        }

        static StackObject* CopyToStack_m_Class1Button_20(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_Class1Button;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_Class1Button_20(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_Class1Button = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_Class1Button_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_Class1Button = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_Class1Button = @m_Class1Button;
            return ptr_of_this_method;
        }

        static object get_m_AutoCreateCloseButton_21(ref object o)
        {
            return ((global::MainWinPanel)o).m_AutoCreateCloseButton;
        }

        static StackObject* CopyToStack_m_AutoCreateCloseButton_21(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_AutoCreateCloseButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_AutoCreateCloseButton_21(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_AutoCreateCloseButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_AutoCreateCloseButton_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_AutoCreateCloseButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_AutoCreateCloseButton = @m_AutoCreateCloseButton;
            return ptr_of_this_method;
        }

        static object get_m_AutoNewCreateButton_22(ref object o)
        {
            return ((global::MainWinPanel)o).m_AutoNewCreateButton;
        }

        static StackObject* CopyToStack_m_AutoNewCreateButton_22(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_AutoNewCreateButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_AutoNewCreateButton_22(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_AutoNewCreateButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_AutoNewCreateButton_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_AutoNewCreateButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_AutoNewCreateButton = @m_AutoNewCreateButton;
            return ptr_of_this_method;
        }

        static object get_m_AutoExpButton_23(ref object o)
        {
            return ((global::MainWinPanel)o).m_AutoExpButton;
        }

        static StackObject* CopyToStack_m_AutoExpButton_23(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_AutoExpButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_AutoExpButton_23(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_AutoExpButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_AutoExpButton_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_AutoExpButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_AutoExpButton = @m_AutoExpButton;
            return ptr_of_this_method;
        }

        static object get_m_ZuoPinCloseButton_24(ref object o)
        {
            return ((global::MainWinPanel)o).m_ZuoPinCloseButton;
        }

        static StackObject* CopyToStack_m_ZuoPinCloseButton_24(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ZuoPinCloseButton;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ZuoPinCloseButton_24(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ZuoPinCloseButton = (UnityEngine.UI.Button)v;
        }

        static StackObject* AssignFromStack_m_ZuoPinCloseButton_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Button @m_ZuoPinCloseButton = (UnityEngine.UI.Button)typeof(UnityEngine.UI.Button).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ZuoPinCloseButton = @m_ZuoPinCloseButton;
            return ptr_of_this_method;
        }

        static object get_m_LanchPanel_25(ref object o)
        {
            return ((global::MainWinPanel)o).m_LanchPanel;
        }

        static StackObject* CopyToStack_m_LanchPanel_25(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_LanchPanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_LanchPanel_25(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_LanchPanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_LanchPanel_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_LanchPanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_LanchPanel = @m_LanchPanel;
            return ptr_of_this_method;
        }

        static object get_m_DaTingPanel_26(ref object o)
        {
            return ((global::MainWinPanel)o).m_DaTingPanel;
        }

        static StackObject* CopyToStack_m_DaTingPanel_26(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_DaTingPanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_DaTingPanel_26(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_DaTingPanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_DaTingPanel_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_DaTingPanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_DaTingPanel = @m_DaTingPanel;
            return ptr_of_this_method;
        }

        static object get_m_SetPanel_27(ref object o)
        {
            return ((global::MainWinPanel)o).m_SetPanel;
        }

        static StackObject* CopyToStack_m_SetPanel_27(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_SetPanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_SetPanel_27(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_SetPanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_SetPanel_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_SetPanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_SetPanel = @m_SetPanel;
            return ptr_of_this_method;
        }

        static object get_m_InformationPanel_28(ref object o)
        {
            return ((global::MainWinPanel)o).m_InformationPanel;
        }

        static StackObject* CopyToStack_m_InformationPanel_28(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_InformationPanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_InformationPanel_28(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_InformationPanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_InformationPanel_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_InformationPanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_InformationPanel = @m_InformationPanel;
            return ptr_of_this_method;
        }

        static object get_m_ClassListPanel_29(ref object o)
        {
            return ((global::MainWinPanel)o).m_ClassListPanel;
        }

        static StackObject* CopyToStack_m_ClassListPanel_29(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ClassListPanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ClassListPanel_29(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ClassListPanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_ClassListPanel_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_ClassListPanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ClassListPanel = @m_ClassListPanel;
            return ptr_of_this_method;
        }

        static object get_m_ZuoYePanel_30(ref object o)
        {
            return ((global::MainWinPanel)o).m_ZuoYePanel;
        }

        static StackObject* CopyToStack_m_ZuoYePanel_30(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ZuoYePanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ZuoYePanel_30(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ZuoYePanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_ZuoYePanel_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_ZuoYePanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ZuoYePanel = @m_ZuoYePanel;
            return ptr_of_this_method;
        }

        static object get_m_AutoCreatePanel_31(ref object o)
        {
            return ((global::MainWinPanel)o).m_AutoCreatePanel;
        }

        static StackObject* CopyToStack_m_AutoCreatePanel_31(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_AutoCreatePanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_AutoCreatePanel_31(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_AutoCreatePanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_AutoCreatePanel_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_AutoCreatePanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_AutoCreatePanel = @m_AutoCreatePanel;
            return ptr_of_this_method;
        }

        static object get_m_ZuoPingListPanel_32(ref object o)
        {
            return ((global::MainWinPanel)o).m_ZuoPingListPanel;
        }

        static StackObject* CopyToStack_m_ZuoPingListPanel_32(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_ZuoPingListPanel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_ZuoPingListPanel_32(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_ZuoPingListPanel = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_m_ZuoPingListPanel_32(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @m_ZuoPingListPanel = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_ZuoPingListPanel = @m_ZuoPingListPanel;
            return ptr_of_this_method;
        }

        static object get_i_SignPanelTips_33(ref object o)
        {
            return ((global::MainWinPanel)o).i_SignPanelTips;
        }

        static StackObject* CopyToStack_i_SignPanelTips_33(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_SignPanelTips;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_SignPanelTips_33(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_SignPanelTips = (UnityEngine.UI.Image)v;
        }

        static StackObject* AssignFromStack_i_SignPanelTips_33(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Image @i_SignPanelTips = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_SignPanelTips = @i_SignPanelTips;
            return ptr_of_this_method;
        }

        static object get_i_LoginPanelTips_34(ref object o)
        {
            return ((global::MainWinPanel)o).i_LoginPanelTips;
        }

        static StackObject* CopyToStack_i_LoginPanelTips_34(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_LoginPanelTips;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_LoginPanelTips_34(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_LoginPanelTips = (UnityEngine.UI.Image)v;
        }

        static StackObject* AssignFromStack_i_LoginPanelTips_34(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Image @i_LoginPanelTips = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_LoginPanelTips = @i_LoginPanelTips;
            return ptr_of_this_method;
        }

        static object get_i_InputFieldName_35(ref object o)
        {
            return ((global::MainWinPanel)o).i_InputFieldName;
        }

        static StackObject* CopyToStack_i_InputFieldName_35(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_InputFieldName;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_InputFieldName_35(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_InputFieldName = (UnityEngine.UI.InputField)v;
        }

        static StackObject* AssignFromStack_i_InputFieldName_35(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.InputField @i_InputFieldName = (UnityEngine.UI.InputField)typeof(UnityEngine.UI.InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_InputFieldName = @i_InputFieldName;
            return ptr_of_this_method;
        }

        static object get_i_InputFieldNamePasswrod_36(ref object o)
        {
            return ((global::MainWinPanel)o).i_InputFieldNamePasswrod;
        }

        static StackObject* CopyToStack_i_InputFieldNamePasswrod_36(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_InputFieldNamePasswrod;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_InputFieldNamePasswrod_36(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_InputFieldNamePasswrod = (UnityEngine.UI.InputField)v;
        }

        static StackObject* AssignFromStack_i_InputFieldNamePasswrod_36(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.InputField @i_InputFieldNamePasswrod = (UnityEngine.UI.InputField)typeof(UnityEngine.UI.InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_InputFieldNamePasswrod = @i_InputFieldNamePasswrod;
            return ptr_of_this_method;
        }

        static object get_m_LoginTipsText_37(ref object o)
        {
            return ((global::MainWinPanel)o).m_LoginTipsText;
        }

        static StackObject* CopyToStack_m_LoginTipsText_37(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).m_LoginTipsText;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_m_LoginTipsText_37(ref object o, object v)
        {
            ((global::MainWinPanel)o).m_LoginTipsText = (UnityEngine.UI.Text)v;
        }

        static StackObject* AssignFromStack_m_LoginTipsText_37(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Text @m_LoginTipsText = (UnityEngine.UI.Text)typeof(UnityEngine.UI.Text).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).m_LoginTipsText = @m_LoginTipsText;
            return ptr_of_this_method;
        }



    }
}
