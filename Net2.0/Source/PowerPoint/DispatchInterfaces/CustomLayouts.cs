//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.PowerPointApi
{
	///<summary>
	/// DispatchInterface CustomLayouts SupportByLibrary PP12 PP14 
	///</summary>
	[SupportByLibrary("PP12","PP14")]
	public class CustomLayouts : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayouts(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayouts(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayouts(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayouts()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public LateBindingApi.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("PP12","PP14")]
		public LateBindingApi.PowerPointApi.CustomLayout Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.PowerPointApi.CustomLayout newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.CustomLayout;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("PP12","PP14")]
		public LateBindingApi.PowerPointApi.CustomLayout Add(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.PowerPointApi.CustomLayout newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.CustomLayout;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("PP12","PP14")]
		public LateBindingApi.PowerPointApi.CustomLayout Paste(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			LateBindingApi.PowerPointApi.CustomLayout newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.CustomLayout;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}