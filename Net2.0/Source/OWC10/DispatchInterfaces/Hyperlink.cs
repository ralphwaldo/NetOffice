//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{
	///<summary>
	/// DispatchInterface Hyperlink SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class Hyperlink : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlink(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlink(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlink(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlink()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.ISpreadsheet Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OWC10Api.ISpreadsheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OWC10Api.ISpreadsheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api._Range Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OWC10Api._Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string SubAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SubAddress", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SubAddress", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="NewWindow">ref optional object NewWindow</param>
		/// <param name="AddHistory">ref optional object AddHistory</param>
		/// <param name="ExtraInfo">ref optional object ExtraInfo</param>
		/// <param name="Method">ref optional object Method</param>
		/// <param name="HeaderInfo">ref optional object HeaderInfo</param>
		[SupportByLibrary("XWC1.0")]
		public void Follow(ref object newWindow, ref object addHistory, ref object extraInfo, ref object method, ref object headerInfo)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(newWindow, addHistory, extraInfo, method, headerInfo);
			Invoker.Method(this, "Follow", paramsArray, modifiers);
			newWindow = (object)paramsArray[0];
			addHistory = (object)paramsArray[1];
			extraInfo = (object)paramsArray[2];
			method = (object)paramsArray[3];
			headerInfo = (object)paramsArray[4];
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Follow()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Follow", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}