//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.VBIDEApi
{
	///<summary>
	/// DispatchInterface _Windows SupportByLibrary VBE5.3 VBE12 
	///</summary>
	[SupportByLibrary("VBE5.3","VBE12")]
	public class _Windows : _Windows_old
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Windows(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Windows(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Windows(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Windows()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="AddInInst">LateBindingApi.VBIDEApi.AddIn AddInInst</param>
		/// <param name="ProgId">string ProgId</param>
		/// <param name="Caption">string Caption</param>
		/// <param name="GuidPosition">string GuidPosition</param>
		/// <param name="DocObj">ref object DocObj</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.Window CreateToolWindow(LateBindingApi.VBIDEApi.AddIn addInInst, string progId, string caption, string guidPosition, ref object docObj)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(addInInst, progId, caption, guidPosition, docObj);
			object returnItem = Invoker.MethodReturn(this, "CreateToolWindow", paramsArray, modifiers);
			LateBindingApi.VBIDEApi.Window newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.VBIDEApi.Window;
			docObj = (object)paramsArray[4];
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}