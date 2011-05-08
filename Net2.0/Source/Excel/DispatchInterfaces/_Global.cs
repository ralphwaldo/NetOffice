//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// DispatchInterface _Global SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	public class _Global : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Global(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Global(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Global(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Global()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Application Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range ActiveCell
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveCell", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Chart ActiveChart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveChart", paramsArray);
				LateBindingApi.ExcelApi.Chart newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Chart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.DialogSheet ActiveDialog
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveDialog", paramsArray);
				LateBindingApi.ExcelApi.DialogSheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.DialogSheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.MenuBar ActiveMenuBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveMenuBar", paramsArray);
				LateBindingApi.ExcelApi.MenuBar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.MenuBar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public string ActivePrinter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActivePrinter", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActivePrinter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public COMObject ActiveSheet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveSheet", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Window ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveWindow", paramsArray);
				LateBindingApi.ExcelApi.Window newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Window;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Workbook ActiveWorkbook
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveWorkbook", paramsArray);
				LateBindingApi.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Workbook;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.AddIns AddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddIns", paramsArray);
				LateBindingApi.ExcelApi.AddIns newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.AddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.OfficeApi.Assistant Assistant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Assistant", paramsArray);
				LateBindingApi.OfficeApi.Assistant newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.Assistant;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Cells
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Cells", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Sheets Charts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Charts", paramsArray);
				LateBindingApi.ExcelApi.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Columns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Columns", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.OfficeApi.CommandBars CommandBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandBars", paramsArray);
				LateBindingApi.OfficeApi.CommandBars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OfficeApi.CommandBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 DDEAppReturnCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DDEAppReturnCode", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Sheets DialogSheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DialogSheets", paramsArray);
				LateBindingApi.ExcelApi.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.MenuBars MenuBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MenuBars", paramsArray);
				LateBindingApi.ExcelApi.MenuBars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.MenuBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Modules Modules
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Modules", paramsArray);
				LateBindingApi.ExcelApi.Modules newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Modules;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Names Names
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Names", paramsArray);
				LateBindingApi.ExcelApi.Names newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Names;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Cell1">object Cell1</param>
		/// <param name="Cell2">optional object Cell2</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range get_Range(object cell1, object cell2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cell1, cell2);
			object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
			LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Cell1">object Cell1</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range get_Range(object cell1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cell1);
			object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
			LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Rows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rows", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public COMObject Selection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Selection", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Sheets Sheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sheets", paramsArray);
				LateBindingApi.ExcelApi.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Menu get_ShortcutMenus(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ShortcutMenus", paramsArray);
			LateBindingApi.ExcelApi.Menu newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Menu;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Workbook ThisWorkbook
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThisWorkbook", paramsArray);
				LateBindingApi.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Workbook;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Toolbars Toolbars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Toolbars", paramsArray);
				LateBindingApi.ExcelApi.Toolbars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Toolbars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Windows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Windows", paramsArray);
				LateBindingApi.ExcelApi.Windows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Windows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Workbooks Workbooks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Workbooks", paramsArray);
				LateBindingApi.ExcelApi.Workbooks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Workbooks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.WorksheetFunction WorksheetFunction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WorksheetFunction", paramsArray);
				LateBindingApi.ExcelApi.WorksheetFunction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.WorksheetFunction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Sheets Worksheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Worksheets", paramsArray);
				LateBindingApi.ExcelApi.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Sheets Excel4IntlMacroSheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Excel4IntlMacroSheets", paramsArray);
				LateBindingApi.ExcelApi.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Sheets Excel4MacroSheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Excel4MacroSheets", paramsArray);
				LateBindingApi.ExcelApi.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sheets;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void Calculate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Calculate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Channel">Int32 Channel</param>
		/// <param name="String">string String</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void DDEExecute(Int32 channel, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel, _string);
			Invoker.Method(this, "DDEExecute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="App">string App</param>
		/// <param name="Topic">string Topic</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 DDEInitiate(string app, string topic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(app, topic);
			object returnItem = Invoker.MethodReturn(this, "DDEInitiate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Channel">Int32 Channel</param>
		/// <param name="Item">object Item</param>
		/// <param name="Data">object Data</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void DDEPoke(Int32 channel, object item, object data)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel, item, data);
			Invoker.Method(this, "DDEPoke", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Channel">Int32 Channel</param>
		/// <param name="Item">string Item</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object DDERequest(Int32 channel, string item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel, item);
			object returnItem = Invoker.MethodReturn(this, "DDERequest", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Channel">Int32 Channel</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void DDETerminate(Int32 channel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(channel);
			Invoker.Method(this, "DDETerminate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Name">object Name</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object Evaluate(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Evaluate", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Name">object Name</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object _Evaluate(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "_Evaluate", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="String">string String</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object ExecuteExcel4Macro(string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string);
			object returnItem = Invoker.MethodReturn(this, "ExecuteExcel4Macro", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Arg1">LateBindingApi.ExcelApi.Range Arg1</param>
		/// <param name="Arg2">LateBindingApi.ExcelApi.Range Arg2</param>
		/// <param name="Arg3">optional object Arg3</param>
		/// <param name="Arg4">optional object Arg4</param>
		/// <param name="Arg5">optional object Arg5</param>
		/// <param name="Arg6">optional object Arg6</param>
		/// <param name="Arg7">optional object Arg7</param>
		/// <param name="Arg8">optional object Arg8</param>
		/// <param name="Arg9">optional object Arg9</param>
		/// <param name="Arg10">optional object Arg10</param>
		/// <param name="Arg11">optional object Arg11</param>
		/// <param name="Arg12">optional object Arg12</param>
		/// <param name="Arg13">optional object Arg13</param>
		/// <param name="Arg14">optional object Arg14</param>
		/// <param name="Arg15">optional object Arg15</param>
		/// <param name="Arg16">optional object Arg16</param>
		/// <param name="Arg17">optional object Arg17</param>
		/// <param name="Arg18">optional object Arg18</param>
		/// <param name="Arg19">optional object Arg19</param>
		/// <param name="Arg20">optional object Arg20</param>
		/// <param name="Arg21">optional object Arg21</param>
		/// <param name="Arg22">optional object Arg22</param>
		/// <param name="Arg23">optional object Arg23</param>
		/// <param name="Arg24">optional object Arg24</param>
		/// <param name="Arg25">optional object Arg25</param>
		/// <param name="Arg26">optional object Arg26</param>
		/// <param name="Arg27">optional object Arg27</param>
		/// <param name="Arg28">optional object Arg28</param>
		/// <param name="Arg29">optional object Arg29</param>
		/// <param name="Arg30">optional object Arg30</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Intersect(LateBindingApi.ExcelApi.Range arg1, LateBindingApi.ExcelApi.Range arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29, object arg30)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "Intersect", paramsArray);
			LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Arg1">LateBindingApi.ExcelApi.Range Arg1</param>
		/// <param name="Arg2">LateBindingApi.ExcelApi.Range Arg2</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Intersect(LateBindingApi.ExcelApi.Range arg1, LateBindingApi.ExcelApi.Range arg2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2);
			object returnItem = Invoker.MethodReturn(this, "Intersect", paramsArray);
			LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Macro">optional object Macro</param>
		/// <param name="Arg1">optional object Arg1</param>
		/// <param name="Arg2">optional object Arg2</param>
		/// <param name="Arg3">optional object Arg3</param>
		/// <param name="Arg4">optional object Arg4</param>
		/// <param name="Arg5">optional object Arg5</param>
		/// <param name="Arg6">optional object Arg6</param>
		/// <param name="Arg7">optional object Arg7</param>
		/// <param name="Arg8">optional object Arg8</param>
		/// <param name="Arg9">optional object Arg9</param>
		/// <param name="Arg10">optional object Arg10</param>
		/// <param name="Arg11">optional object Arg11</param>
		/// <param name="Arg12">optional object Arg12</param>
		/// <param name="Arg13">optional object Arg13</param>
		/// <param name="Arg14">optional object Arg14</param>
		/// <param name="Arg15">optional object Arg15</param>
		/// <param name="Arg16">optional object Arg16</param>
		/// <param name="Arg17">optional object Arg17</param>
		/// <param name="Arg18">optional object Arg18</param>
		/// <param name="Arg19">optional object Arg19</param>
		/// <param name="Arg20">optional object Arg20</param>
		/// <param name="Arg21">optional object Arg21</param>
		/// <param name="Arg22">optional object Arg22</param>
		/// <param name="Arg23">optional object Arg23</param>
		/// <param name="Arg24">optional object Arg24</param>
		/// <param name="Arg25">optional object Arg25</param>
		/// <param name="Arg26">optional object Arg26</param>
		/// <param name="Arg27">optional object Arg27</param>
		/// <param name="Arg28">optional object Arg28</param>
		/// <param name="Arg29">optional object Arg29</param>
		/// <param name="Arg30">optional object Arg30</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object Run(object macro, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29, object arg30)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(macro, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "Run", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object Run()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Run", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Macro">optional object Macro</param>
		/// <param name="Arg1">optional object Arg1</param>
		/// <param name="Arg2">optional object Arg2</param>
		/// <param name="Arg3">optional object Arg3</param>
		/// <param name="Arg4">optional object Arg4</param>
		/// <param name="Arg5">optional object Arg5</param>
		/// <param name="Arg6">optional object Arg6</param>
		/// <param name="Arg7">optional object Arg7</param>
		/// <param name="Arg8">optional object Arg8</param>
		/// <param name="Arg9">optional object Arg9</param>
		/// <param name="Arg10">optional object Arg10</param>
		/// <param name="Arg11">optional object Arg11</param>
		/// <param name="Arg12">optional object Arg12</param>
		/// <param name="Arg13">optional object Arg13</param>
		/// <param name="Arg14">optional object Arg14</param>
		/// <param name="Arg15">optional object Arg15</param>
		/// <param name="Arg16">optional object Arg16</param>
		/// <param name="Arg17">optional object Arg17</param>
		/// <param name="Arg18">optional object Arg18</param>
		/// <param name="Arg19">optional object Arg19</param>
		/// <param name="Arg20">optional object Arg20</param>
		/// <param name="Arg21">optional object Arg21</param>
		/// <param name="Arg22">optional object Arg22</param>
		/// <param name="Arg23">optional object Arg23</param>
		/// <param name="Arg24">optional object Arg24</param>
		/// <param name="Arg25">optional object Arg25</param>
		/// <param name="Arg26">optional object Arg26</param>
		/// <param name="Arg27">optional object Arg27</param>
		/// <param name="Arg28">optional object Arg28</param>
		/// <param name="Arg29">optional object Arg29</param>
		/// <param name="Arg30">optional object Arg30</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object _Run2(object macro, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29, object arg30)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(macro, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "_Run2", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object _Run2()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_Run2", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Keys">object Keys</param>
		/// <param name="Wait">optional object Wait</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void SendKeys(object keys, object wait)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keys, wait);
			Invoker.Method(this, "SendKeys", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Keys">object Keys</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public void SendKeys(object keys)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keys);
			Invoker.Method(this, "SendKeys", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Arg1">LateBindingApi.ExcelApi.Range Arg1</param>
		/// <param name="Arg2">LateBindingApi.ExcelApi.Range Arg2</param>
		/// <param name="Arg3">optional object Arg3</param>
		/// <param name="Arg4">optional object Arg4</param>
		/// <param name="Arg5">optional object Arg5</param>
		/// <param name="Arg6">optional object Arg6</param>
		/// <param name="Arg7">optional object Arg7</param>
		/// <param name="Arg8">optional object Arg8</param>
		/// <param name="Arg9">optional object Arg9</param>
		/// <param name="Arg10">optional object Arg10</param>
		/// <param name="Arg11">optional object Arg11</param>
		/// <param name="Arg12">optional object Arg12</param>
		/// <param name="Arg13">optional object Arg13</param>
		/// <param name="Arg14">optional object Arg14</param>
		/// <param name="Arg15">optional object Arg15</param>
		/// <param name="Arg16">optional object Arg16</param>
		/// <param name="Arg17">optional object Arg17</param>
		/// <param name="Arg18">optional object Arg18</param>
		/// <param name="Arg19">optional object Arg19</param>
		/// <param name="Arg20">optional object Arg20</param>
		/// <param name="Arg21">optional object Arg21</param>
		/// <param name="Arg22">optional object Arg22</param>
		/// <param name="Arg23">optional object Arg23</param>
		/// <param name="Arg24">optional object Arg24</param>
		/// <param name="Arg25">optional object Arg25</param>
		/// <param name="Arg26">optional object Arg26</param>
		/// <param name="Arg27">optional object Arg27</param>
		/// <param name="Arg28">optional object Arg28</param>
		/// <param name="Arg29">optional object Arg29</param>
		/// <param name="Arg30">optional object Arg30</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Union(LateBindingApi.ExcelApi.Range arg1, LateBindingApi.ExcelApi.Range arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29, object arg30)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "Union", paramsArray);
			LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Arg1">LateBindingApi.ExcelApi.Range Arg1</param>
		/// <param name="Arg2">LateBindingApi.ExcelApi.Range Arg2</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Union(LateBindingApi.ExcelApi.Range arg1, LateBindingApi.ExcelApi.Range arg2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2);
			object returnItem = Invoker.MethodReturn(this, "Union", paramsArray);
			LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ExcelApi.Range;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}