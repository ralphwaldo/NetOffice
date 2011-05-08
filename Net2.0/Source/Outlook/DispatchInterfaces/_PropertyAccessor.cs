//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{
	///<summary>
	/// DispatchInterface _PropertyAccessor SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	public class _PropertyAccessor : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PropertyAccessor()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				LateBindingApi.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="SchemaName">string SchemaName</param>
		[SupportByLibrary("OL12","OL14")]
		public object GetProperty(string schemaName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaName);
			object returnItem = Invoker.MethodReturn(this, "GetProperty", paramsArray);
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="SchemaName">string SchemaName</param>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("OL12","OL14")]
		public void SetProperty(string schemaName, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaName, value);
			Invoker.Method(this, "SetProperty", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="SchemaNames">object SchemaNames</param>
		[SupportByLibrary("OL12","OL14")]
		public object GetProperties(object schemaNames)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaNames);
			object returnItem = Invoker.MethodReturn(this, "GetProperties", paramsArray);
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="SchemaNames">object SchemaNames</param>
		/// <param name="Values">object Values</param>
		[SupportByLibrary("OL12","OL14")]
		public object SetProperties(object schemaNames, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaNames, values);
			object returnItem = Invoker.MethodReturn(this, "SetProperties", paramsArray);
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Value">DateTime Value</param>
		[SupportByLibrary("OL12","OL14")]
		public DateTime UTCToLocalTime(DateTime value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "UTCToLocalTime", paramsArray);
			return (DateTime)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Value">DateTime Value</param>
		[SupportByLibrary("OL12","OL14")]
		public DateTime LocalTimeToUTC(DateTime value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "LocalTimeToUTC", paramsArray);
			return (DateTime)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Value">string Value</param>
		[SupportByLibrary("OL12","OL14")]
		public object StringToBinary(string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "StringToBinary", paramsArray);
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("OL12","OL14")]
		public string BinaryToString(object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value);
			object returnItem = Invoker.MethodReturn(this, "BinaryToString", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="SchemaName">string SchemaName</param>
		[SupportByLibrary("OL12","OL14")]
		public void DeleteProperty(string schemaName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schemaName);
			Invoker.Method(this, "DeleteProperty", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="SchemaNames">ref object SchemaNames</param>
		[SupportByLibrary("OL12","OL14")]
		public object DeleteProperties(ref object schemaNames)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(schemaNames);
			object returnItem = Invoker.MethodReturn(this, "DeleteProperties", paramsArray, modifiers);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				schemaNames = (object)paramsArray[0];
			return newObject;
			}
			else
			{
				schemaNames = (object)paramsArray[0];
			return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}