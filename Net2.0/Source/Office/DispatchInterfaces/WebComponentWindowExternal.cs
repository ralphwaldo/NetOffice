//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface WebComponentWindowExternal SupportByLibrary OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF10","OF11","OF12","OF14")]
	public class WebComponentWindowExternal : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WebComponentWindowExternal(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WebComponentWindowExternal(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WebComponentWindowExternal(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public WebComponentWindowExternal()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public Int32 InterfaceVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InterfaceVersion", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public string ApplicationName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplicationName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public Int32 ApplicationVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplicationVersion", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.WebComponent WebComponent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WebComponent", paramsArray);
				LateBindingApi.OfficeApi.WebComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.WebComponent;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void CloseWindow()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CloseWindow", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}