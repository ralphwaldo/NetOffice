//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.AccessApi
{
	///<summary>
	/// DispatchInterface _CurrentData SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	public class _CurrentData : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CurrentData()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public LateBindingApi.AccessApi.AllTables AllTables
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllTables", paramsArray);
				LateBindingApi.AccessApi.AllTables newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.AccessApi.AllTables;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public LateBindingApi.AccessApi.AllQueries AllQueries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllQueries", paramsArray);
				LateBindingApi.AccessApi.AllQueries newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.AccessApi.AllQueries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public LateBindingApi.AccessApi.AllViews AllViews
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllViews", paramsArray);
				LateBindingApi.AccessApi.AllViews newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.AccessApi.AllViews;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public LateBindingApi.AccessApi.AllStoredProcedures AllStoredProcedures
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllStoredProcedures", paramsArray);
				LateBindingApi.AccessApi.AllStoredProcedures newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.AccessApi.AllStoredProcedures;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public LateBindingApi.AccessApi.AllDatabaseDiagrams AllDatabaseDiagrams
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllDatabaseDiagrams", paramsArray);
				LateBindingApi.AccessApi.AllDatabaseDiagrams newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.AccessApi.AllDatabaseDiagrams;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC10","AC11","AC12","AC14")]
		public LateBindingApi.AccessApi.AllFunctions AllFunctions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllFunctions", paramsArray);
				LateBindingApi.AccessApi.AllFunctions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.AccessApi.AllFunctions;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("AC11","AC12","AC14")]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}