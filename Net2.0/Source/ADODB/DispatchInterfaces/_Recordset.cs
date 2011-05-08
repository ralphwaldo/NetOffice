//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ADODBApi
{
	///<summary>
	/// DispatchInterface _Recordset SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	public class _Recordset : Recordset21
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				LateBindingApi.ADODBApi.Properties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ADODBApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.PositionEnum AbsolutePosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePosition", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.PositionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public COMObject ActiveConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveConnection", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActiveConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public bool BOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public object Bookmark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bookmark", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Bookmark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 CacheSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CacheSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.CursorTypeEnum CursorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorType", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.CursorTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public bool EOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				LateBindingApi.ADODBApi.Fields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ADODBApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.LockTypeEnum LockType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockType", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.LockTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 MaxRecords
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxRecords", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxRecords", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 RecordCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public COMObject Source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Source", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Source", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.PositionEnum AbsolutePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePage", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.PositionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.EditModeEnum EditMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EditMode", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.EditModeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public object Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 PageCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 PageSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PageSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public string Sort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sort", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sort", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 Status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Status", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.CursorLocationEnum CursorLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorLocation", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.CursorLocationEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public object get_Collect(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Collect", paramsArray);
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

		public void set_Collect(object index, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "Collect", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.MarshalOptionsEnum MarshalOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarshalOptions", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.MarshalOptionsEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarshalOptions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 
		/// </summary>
		[SupportByLibrary("ADO2.1")]
		public string Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Index", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public COMObject DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public COMObject ActiveCommand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveCommand", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public bool StayInSync
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StayInSync", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StayInSync", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public string DataMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataMember", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataMember", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="FieldList">optional object FieldList</param>
		/// <param name="Values">optional object Values</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void AddNew(object fieldList, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldList, values);
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void AddNew()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void CancelUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CancelUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="AffectRecords">LateBindingApi.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Delete(LateBindingApi.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		/// <param name="Start">optional object Start</param>
		/// <param name="Fields">optional object Fields</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public object GetRows(Int32 rows, object start, object fields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows, start, fields);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
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
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public object GetRows(Int32 rows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
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
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="NumRecords">Int32 NumRecords</param>
		/// <param name="Start">optional object Start</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Move(Int32 numRecords, object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRecords, start);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="NumRecords">Int32 NumRecords</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Move(Int32 numRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRecords);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void MoveNext()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveNext", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void MovePrevious()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MovePrevious", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void MoveFirst()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveFirst", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void MoveLast()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveLast", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="ActiveConnection">object ActiveConnection</param>
		/// <param name="CursorType">LateBindingApi.ADODBApi.Enums.CursorTypeEnum CursorType</param>
		/// <param name="LockType">LateBindingApi.ADODBApi.Enums.LockTypeEnum LockType</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Open(object source, object activeConnection, LateBindingApi.ADODBApi.Enums.CursorTypeEnum cursorType, LateBindingApi.ADODBApi.Enums.LockTypeEnum lockType, Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, activeConnection, cursorType, lockType, options);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Requery(Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="AffectRecords">LateBindingApi.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void _xResync(LateBindingApi.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "_xResync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Fields">optional object Fields</param>
		/// <param name="Values">optional object Values</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Update(object fields, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fields, values);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi._Recordset _xClone()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_xClone", paramsArray);
			LateBindingApi.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="AffectRecords">LateBindingApi.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void UpdateBatch(LateBindingApi.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "UpdateBatch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="AffectRecords">LateBindingApi.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void CancelBatch(LateBindingApi.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "CancelBatch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="RecordsAffected">ref optional object RecordsAffected</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi._Recordset NextRecordset(ref object recordsAffected)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(recordsAffected);
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray, modifiers);
			LateBindingApi.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ADODBApi._Recordset;
			recordsAffected = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi._Recordset NextRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray);
			LateBindingApi.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="CursorOptions">LateBindingApi.ADODBApi.Enums.CursorOptionEnum CursorOptions</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public bool Supports(LateBindingApi.ADODBApi.Enums.CursorOptionEnum cursorOptions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cursorOptions);
			object returnItem = Invoker.MethodReturn(this, "Supports", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		/// <param name="SkipRecords">Int32 SkipRecords</param>
		/// <param name="SearchDirection">LateBindingApi.ADODBApi.Enums.SearchDirectionEnum SearchDirection</param>
		/// <param name="Start">optional object Start</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Find(string criteria, Int32 skipRecords, LateBindingApi.ADODBApi.Enums.SearchDirectionEnum searchDirection, object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria, skipRecords, searchDirection, start);
			Invoker.Method(this, "Find", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		/// <param name="SkipRecords">Int32 SkipRecords</param>
		/// <param name="SearchDirection">LateBindingApi.ADODBApi.Enums.SearchDirectionEnum SearchDirection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Find(string criteria, Int32 skipRecords, LateBindingApi.ADODBApi.Enums.SearchDirectionEnum searchDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria, skipRecords, searchDirection);
			Invoker.Method(this, "Find", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 
		/// </summary>
		/// <param name="KeyValues">object KeyValues</param>
		/// <param name="SeekOption">LateBindingApi.ADODBApi.Enums.SeekEnum SeekOption</param>
		[SupportByLibrary("ADO2.1")]
		public void Seek(object keyValues, LateBindingApi.ADODBApi.Enums.SeekEnum seekOption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keyValues, seekOption);
			Invoker.Method(this, "Seek", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="PersistFormat">LateBindingApi.ADODBApi.Enums.PersistFormatEnum PersistFormat</param>
		[SupportByLibrary("ADO2.5")]
		public void _xSave(string fileName, LateBindingApi.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, persistFormat);
			Invoker.Method(this, "_xSave", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="StringFormat">LateBindingApi.ADODBApi.Enums.StringFormatEnum StringFormat</param>
		/// <param name="NumRows">Int32 NumRows</param>
		/// <param name="ColumnDelimeter">string ColumnDelimeter</param>
		/// <param name="RowDelimeter">string RowDelimeter</param>
		/// <param name="NullExpr">string NullExpr</param>
		[SupportByLibrary("ADO2.5")]
		public string GetString(LateBindingApi.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows, string columnDelimeter, string rowDelimeter, string nullExpr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows, columnDelimeter, rowDelimeter, nullExpr);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="Bookmark1">object Bookmark1</param>
		/// <param name="Bookmark2">object Bookmark2</param>
		[SupportByLibrary("ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.CompareEnum CompareBookmarks(object bookmark1, object bookmark2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bookmark1, bookmark2);
			object returnItem = Invoker.MethodReturn(this, "CompareBookmarks", paramsArray);
			return (LateBindingApi.ADODBApi.Enums.CompareEnum)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="LockType">LateBindingApi.ADODBApi.Enums.LockTypeEnum LockType</param>
		[SupportByLibrary("ADO2.5")]
		public LateBindingApi.ADODBApi._Recordset Clone(LateBindingApi.ADODBApi.Enums.LockTypeEnum lockType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lockType);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			LateBindingApi.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="AffectRecords">LateBindingApi.ADODBApi.Enums.AffectEnum AffectRecords</param>
		/// <param name="ResyncValues">LateBindingApi.ADODBApi.Enums.ResyncEnum ResyncValues</param>
		[SupportByLibrary("ADO2.5")]
		public void Resync(LateBindingApi.ADODBApi.Enums.AffectEnum affectRecords, LateBindingApi.ADODBApi.Enums.ResyncEnum resyncValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords, resyncValues);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="Destination">object Destination</param>
		/// <param name="PersistFormat">LateBindingApi.ADODBApi.Enums.PersistFormatEnum PersistFormat</param>
		[SupportByLibrary("ADO2.5")]
		public void Save(object destination, LateBindingApi.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destination, persistFormat);
			Invoker.Method(this, "Save", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}