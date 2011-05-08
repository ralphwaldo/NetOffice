//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// Interface IListObjects SupportByLibrary XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL11","XL12","XL14")]
	public class IListObjects : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListObjects(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListObjects(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListObjects(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListObjects()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
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

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("IndexerItem")]
		public LateBindingApi.ExcelApi.ListObject this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.ListObject get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL11 
		/// </summary>
		/// <param name="SourceType">LateBindingApi.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">LateBindingApi.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		/// <param name="Destination">optional object Destination</param>
		[SupportByLibrary("XL11")]
		public LateBindingApi.ExcelApi.ListObject Add(LateBindingApi.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, LateBindingApi.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders, object destination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="SourceType">LateBindingApi.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">LateBindingApi.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		/// <param name="Destination">optional object Destination</param>
		/// <param name="TableStyleName">optional object TableStyleName</param>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.ListObject Add(LateBindingApi.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, LateBindingApi.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders, object destination, object tableStyleName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination, tableStyleName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="SourceType">LateBindingApi.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">LateBindingApi.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.ListObject Add(LateBindingApi.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, LateBindingApi.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="SourceType">LateBindingApi.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">LateBindingApi.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		/// <param name="Destination">optional object Destination</param>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.ListObject _Add(LateBindingApi.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, LateBindingApi.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders, object destination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="SourceType">LateBindingApi.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">LateBindingApi.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.ListObject _Add(LateBindingApi.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, LateBindingApi.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			LateBindingApi.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.ListObject;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XL11","XL12","XL14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}