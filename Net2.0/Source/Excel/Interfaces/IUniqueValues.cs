//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// Interface IUniqueValues SupportByLibrary XL12 XL14 
	///</summary>
	[SupportByLibrary("XL12","XL14")]
	public class IUniqueValues : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUniqueValues(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUniqueValues(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUniqueValues(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IUniqueValues()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
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
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
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
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
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
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 Priority
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Priority", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Priority", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool StopIfTrue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StopIfTrue", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StopIfTrue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Range AppliesTo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AppliesTo", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlDupeUnique DupeUnique
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DupeUnique", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlDupeUnique)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DupeUnique", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Interior Interior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Interior", paramsArray);
				LateBindingApi.ExcelApi.Interior newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Interior;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				LateBindingApi.ExcelApi.Borders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Borders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				LateBindingApi.ExcelApi.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Font;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public object NumberFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberFormat", paramsArray);
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
				Invoker.PropertySet(this, "NumberFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool PTCondition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PTCondition", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlPivotConditionScope ScopeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScopeType", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlPivotConditionScope)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScopeType", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 SetFirstPriority()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "SetFirstPriority", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 SetLastPriority()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "SetLastPriority", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="Range">LateBindingApi.ExcelApi.Range Range</param>
		[SupportByLibrary("XL12","XL14")]
		public Int32 ModifyAppliesToRange(LateBindingApi.ExcelApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "ModifyAppliesToRange", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}