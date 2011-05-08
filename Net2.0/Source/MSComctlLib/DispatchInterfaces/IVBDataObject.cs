//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IVBDataObject SupportByLibrary WCC6.0 
	///</summary>
	[SupportByLibrary("WCC6.0")]
	public class IVBDataObject : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVBDataObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVBDataObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVBDataObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVBDataObject()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public LateBindingApi.MSComctlLibApi.IVBDataObjectFiles Files
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Files", paramsArray);
				LateBindingApi.MSComctlLibApi.IVBDataObjectFiles newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSComctlLibApi.IVBDataObjectFiles;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="sFormat">Int16 sFormat</param>
		[SupportByLibrary("WCC6.0")]
		public object GetData(Int16 sFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sFormat);
			object returnItem = Invoker.MethodReturn(this, "GetData", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="sFormat">Int16 sFormat</param>
		[SupportByLibrary("WCC6.0")]
		public bool GetFormat(Int16 sFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sFormat);
			object returnItem = Invoker.MethodReturn(this, "GetFormat", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="vValue">optional object vValue</param>
		/// <param name="vFormat">optional object vFormat</param>
		[SupportByLibrary("WCC6.0")]
		public void SetData(object vValue, object vFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vValue, vFormat);
			Invoker.Method(this, "SetData", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void SetData()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetData", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}