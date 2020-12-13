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
            field = type.GetField("i_SignPanelTips", flag);
            app.RegisterCLRFieldGetter(field, get_i_SignPanelTips_10);
            app.RegisterCLRFieldSetter(field, set_i_SignPanelTips_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_SignPanelTips_10, AssignFromStack_i_SignPanelTips_10);
            field = type.GetField("i_LoginPanelTips", flag);
            app.RegisterCLRFieldGetter(field, get_i_LoginPanelTips_11);
            app.RegisterCLRFieldSetter(field, set_i_LoginPanelTips_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_LoginPanelTips_11, AssignFromStack_i_LoginPanelTips_11);
            field = type.GetField("i_InputFieldName", flag);
            app.RegisterCLRFieldGetter(field, get_i_InputFieldName_12);
            app.RegisterCLRFieldSetter(field, set_i_InputFieldName_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_InputFieldName_12, AssignFromStack_i_InputFieldName_12);
            field = type.GetField("i_InputFieldNamePasswrod", flag);
            app.RegisterCLRFieldGetter(field, get_i_InputFieldNamePasswrod_13);
            app.RegisterCLRFieldSetter(field, set_i_InputFieldNamePasswrod_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_i_InputFieldNamePasswrod_13, AssignFromStack_i_InputFieldNamePasswrod_13);


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

        static object get_i_SignPanelTips_10(ref object o)
        {
            return ((global::MainWinPanel)o).i_SignPanelTips;
        }

        static StackObject* CopyToStack_i_SignPanelTips_10(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_SignPanelTips;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_SignPanelTips_10(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_SignPanelTips = (UnityEngine.UI.Image)v;
        }

        static StackObject* AssignFromStack_i_SignPanelTips_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Image @i_SignPanelTips = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_SignPanelTips = @i_SignPanelTips;
            return ptr_of_this_method;
        }

        static object get_i_LoginPanelTips_11(ref object o)
        {
            return ((global::MainWinPanel)o).i_LoginPanelTips;
        }

        static StackObject* CopyToStack_i_LoginPanelTips_11(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_LoginPanelTips;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_LoginPanelTips_11(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_LoginPanelTips = (UnityEngine.UI.Image)v;
        }

        static StackObject* AssignFromStack_i_LoginPanelTips_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Image @i_LoginPanelTips = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_LoginPanelTips = @i_LoginPanelTips;
            return ptr_of_this_method;
        }

        static object get_i_InputFieldName_12(ref object o)
        {
            return ((global::MainWinPanel)o).i_InputFieldName;
        }

        static StackObject* CopyToStack_i_InputFieldName_12(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_InputFieldName;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_InputFieldName_12(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_InputFieldName = (UnityEngine.UI.InputField)v;
        }

        static StackObject* AssignFromStack_i_InputFieldName_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.InputField @i_InputFieldName = (UnityEngine.UI.InputField)typeof(UnityEngine.UI.InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_InputFieldName = @i_InputFieldName;
            return ptr_of_this_method;
        }

        static object get_i_InputFieldNamePasswrod_13(ref object o)
        {
            return ((global::MainWinPanel)o).i_InputFieldNamePasswrod;
        }

        static StackObject* CopyToStack_i_InputFieldNamePasswrod_13(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((global::MainWinPanel)o).i_InputFieldNamePasswrod;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_i_InputFieldNamePasswrod_13(ref object o, object v)
        {
            ((global::MainWinPanel)o).i_InputFieldNamePasswrod = (UnityEngine.UI.InputField)v;
        }

        static StackObject* AssignFromStack_i_InputFieldNamePasswrod_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.InputField @i_InputFieldNamePasswrod = (UnityEngine.UI.InputField)typeof(UnityEngine.UI.InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((global::MainWinPanel)o).i_InputFieldNamePasswrod = @i_InputFieldNamePasswrod;
            return ptr_of_this_method;
        }



    }
}
