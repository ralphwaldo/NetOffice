//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Application_NewWorkbookEventHandler(LateBindingApi.ExcelApi.Workbook Wb);
	public delegate void Application_SheetSelectionChangeEventHandler(COMObject Sh, LateBindingApi.ExcelApi.Range Target);
	public delegate void Application_SheetBeforeDoubleClickEventHandler(COMObject Sh, LateBindingApi.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Application_SheetBeforeRightClickEventHandler(COMObject Sh, LateBindingApi.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Application_SheetActivateEventHandler(COMObject Sh);
	public delegate void Application_SheetDeactivateEventHandler(COMObject Sh);
	public delegate void Application_SheetCalculateEventHandler(COMObject Sh);
	public delegate void Application_SheetChangeEventHandler(COMObject Sh, LateBindingApi.ExcelApi.Range Target);
	public delegate void Application_WorkbookOpenEventHandler(LateBindingApi.ExcelApi.Workbook Wb);
	public delegate void Application_WorkbookActivateEventHandler(LateBindingApi.ExcelApi.Workbook Wb);
	public delegate void Application_WorkbookDeactivateEventHandler(LateBindingApi.ExcelApi.Workbook Wb);
	public delegate void Application_WorkbookBeforeCloseEventHandler(LateBindingApi.ExcelApi.Workbook Wb, ref bool Cancel);
	public delegate void Application_WorkbookBeforeSaveEventHandler(LateBindingApi.ExcelApi.Workbook Wb, bool SaveAsUI, ref bool Cancel);
	public delegate void Application_WorkbookBeforePrintEventHandler(LateBindingApi.ExcelApi.Workbook Wb, ref bool Cancel);
	public delegate void Application_WorkbookNewSheetEventHandler(LateBindingApi.ExcelApi.Workbook Wb, COMObject Sh);
	public delegate void Application_WorkbookAddinInstallEventHandler(LateBindingApi.ExcelApi.Workbook Wb);
	public delegate void Application_WorkbookAddinUninstallEventHandler(LateBindingApi.ExcelApi.Workbook Wb);
	public delegate void Application_WindowResizeEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.Window Wn);
	public delegate void Application_WindowActivateEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.Window Wn);
	public delegate void Application_WindowDeactivateEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.Window Wn);
	public delegate void Application_SheetFollowHyperlinkEventHandler(COMObject Sh, LateBindingApi.ExcelApi.Hyperlink Target);
	public delegate void Application_SheetPivotTableUpdateEventHandler(COMObject Sh, LateBindingApi.ExcelApi.PivotTable Target);
	public delegate void Application_WorkbookPivotTableCloseConnectionEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.PivotTable Target);
	public delegate void Application_WorkbookPivotTableOpenConnectionEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.PivotTable Target);
	public delegate void Application_WorkbookSyncEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.OfficeApi.Enums.MsoSyncEventType SyncEventType);
	public delegate void Application_WorkbookBeforeXmlImportEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.XmlMap Map, string Url, bool IsRefresh, ref bool Cancel);
	public delegate void Application_WorkbookAfterXmlImportEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.XmlMap Map, bool IsRefresh, LateBindingApi.ExcelApi.Enums.XlXmlImportResult Result);
	public delegate void Application_WorkbookBeforeXmlExportEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.XmlMap Map, string Url, ref bool Cancel);
	public delegate void Application_WorkbookAfterXmlExportEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.XmlMap Map, string Url, LateBindingApi.ExcelApi.Enums.XlXmlExportResult Result);
	public delegate void Application_WorkbookRowsetCompleteEventHandler(LateBindingApi.ExcelApi.Workbook Wb, string Description, string Sheet, bool Success);
	public delegate void Application_AfterCalculateEventHandler();
	public delegate void Application_SheetPivotTableAfterValueChangeEventHandler(COMObject Sh, LateBindingApi.ExcelApi.PivotTable TargetPivotTable, LateBindingApi.ExcelApi.Range TargetRange);
	public delegate void Application_SheetPivotTableBeforeAllocateChangesEventHandler(COMObject Sh, LateBindingApi.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Application_SheetPivotTableBeforeCommitChangesEventHandler(COMObject Sh, LateBindingApi.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Application_SheetPivotTableBeforeDiscardChangesEventHandler(COMObject Sh, LateBindingApi.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd);
	public delegate void Application_ProtectedViewWindowOpenEventHandler(LateBindingApi.ExcelApi.ProtectedViewWindow Pvw);
	public delegate void Application_ProtectedViewWindowBeforeEditEventHandler(LateBindingApi.ExcelApi.ProtectedViewWindow Pvw, ref bool Cancel);
	public delegate void Application_ProtectedViewWindowBeforeCloseEventHandler(LateBindingApi.ExcelApi.ProtectedViewWindow Pvw, LateBindingApi.ExcelApi.Enums.XlProtectedViewCloseReason Reason, ref bool Cancel);
	public delegate void Application_ProtectedViewWindowResizeEventHandler(LateBindingApi.ExcelApi.ProtectedViewWindow Pvw);
	public delegate void Application_ProtectedViewWindowActivateEventHandler(LateBindingApi.ExcelApi.ProtectedViewWindow Pvw);
	public delegate void Application_ProtectedViewWindowDeactivateEventHandler(LateBindingApi.ExcelApi.ProtectedViewWindow Pvw);
	public delegate void Application_WorkbookAfterSaveEventHandler(LateBindingApi.ExcelApi.Workbook Wb, bool Success);
	public delegate void Application_WorkbookNewChartEventHandler(LateBindingApi.ExcelApi.Workbook Wb, LateBindingApi.ExcelApi.Chart Ch);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Application SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	public class Application : _Application, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		AppEvents_SinkHelper _appEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Application(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Application(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Application(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Application()
		{
			CreateFromProgId("Excel.Application");
		}
		
		/// <param name="progId">progId</param>
		public Application(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, AppEvents_SinkHelper.Id);


			if(AppEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_appEvents_SinkHelper = new AppEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_NewWorkbookEventHandler _NewWorkbookEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_NewWorkbookEventHandler NewWorkbookEvent
		{
			add
			{
				CreateEventBridge();
				_NewWorkbookEvent += value;
			}
			remove
			{
				_NewWorkbookEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetSelectionChangeEventHandler _SheetSelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetSelectionChangeEventHandler SheetSelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetSelectionChangeEvent += value;
			}
			remove
			{
				_SheetSelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetBeforeDoubleClickEventHandler _SheetBeforeDoubleClickEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetBeforeDoubleClickEventHandler SheetBeforeDoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_SheetBeforeDoubleClickEvent += value;
			}
			remove
			{
				_SheetBeforeDoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetBeforeRightClickEventHandler _SheetBeforeRightClickEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetBeforeRightClickEventHandler SheetBeforeRightClickEvent
		{
			add
			{
				CreateEventBridge();
				_SheetBeforeRightClickEvent += value;
			}
			remove
			{
				_SheetBeforeRightClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetActivateEventHandler _SheetActivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetActivateEventHandler SheetActivateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetActivateEvent += value;
			}
			remove
			{
				_SheetActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetDeactivateEventHandler _SheetDeactivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetDeactivateEventHandler SheetDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetDeactivateEvent += value;
			}
			remove
			{
				_SheetDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetCalculateEventHandler _SheetCalculateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetCalculateEventHandler SheetCalculateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetCalculateEvent += value;
			}
			remove
			{
				_SheetCalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetChangeEventHandler _SheetChangeEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetChangeEventHandler SheetChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetChangeEvent += value;
			}
			remove
			{
				_SheetChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookOpenEventHandler _WorkbookOpenEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookOpenEventHandler WorkbookOpenEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookOpenEvent += value;
			}
			remove
			{
				_WorkbookOpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookActivateEventHandler _WorkbookActivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookActivateEventHandler WorkbookActivateEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookActivateEvent += value;
			}
			remove
			{
				_WorkbookActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookDeactivateEventHandler _WorkbookDeactivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookDeactivateEventHandler WorkbookDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookDeactivateEvent += value;
			}
			remove
			{
				_WorkbookDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookBeforeCloseEventHandler _WorkbookBeforeCloseEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookBeforeCloseEventHandler WorkbookBeforeCloseEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookBeforeCloseEvent += value;
			}
			remove
			{
				_WorkbookBeforeCloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookBeforeSaveEventHandler _WorkbookBeforeSaveEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookBeforeSaveEventHandler WorkbookBeforeSaveEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookBeforeSaveEvent += value;
			}
			remove
			{
				_WorkbookBeforeSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookBeforePrintEventHandler _WorkbookBeforePrintEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookBeforePrintEventHandler WorkbookBeforePrintEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookBeforePrintEvent += value;
			}
			remove
			{
				_WorkbookBeforePrintEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookNewSheetEventHandler _WorkbookNewSheetEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookNewSheetEventHandler WorkbookNewSheetEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookNewSheetEvent += value;
			}
			remove
			{
				_WorkbookNewSheetEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookAddinInstallEventHandler _WorkbookAddinInstallEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookAddinInstallEventHandler WorkbookAddinInstallEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookAddinInstallEvent += value;
			}
			remove
			{
				_WorkbookAddinInstallEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookAddinUninstallEventHandler _WorkbookAddinUninstallEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WorkbookAddinUninstallEventHandler WorkbookAddinUninstallEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookAddinUninstallEvent += value;
			}
			remove
			{
				_WorkbookAddinUninstallEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WindowResizeEventHandler _WindowResizeEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WindowResizeEventHandler WindowResizeEvent
		{
			add
			{
				CreateEventBridge();
				_WindowResizeEvent += value;
			}
			remove
			{
				_WindowResizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WindowActivateEventHandler _WindowActivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WindowActivateEventHandler WindowActivateEvent
		{
			add
			{
				CreateEventBridge();
				_WindowActivateEvent += value;
			}
			remove
			{
				_WindowActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WindowDeactivateEventHandler _WindowDeactivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_WindowDeactivateEventHandler WindowDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_WindowDeactivateEvent += value;
			}
			remove
			{
				_WindowDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetFollowHyperlinkEventHandler _SheetFollowHyperlinkEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Application_SheetFollowHyperlinkEventHandler SheetFollowHyperlinkEvent
		{
			add
			{
				CreateEventBridge();
				_SheetFollowHyperlinkEvent += value;
			}
			remove
			{
				_SheetFollowHyperlinkEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_SheetPivotTableUpdateEventHandler _SheetPivotTableUpdateEvent;

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public event Application_SheetPivotTableUpdateEventHandler SheetPivotTableUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableUpdateEvent += value;
			}
			remove
			{
				_SheetPivotTableUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookPivotTableCloseConnectionEventHandler _WorkbookPivotTableCloseConnectionEvent;

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public event Application_WorkbookPivotTableCloseConnectionEventHandler WorkbookPivotTableCloseConnectionEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookPivotTableCloseConnectionEvent += value;
			}
			remove
			{
				_WorkbookPivotTableCloseConnectionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookPivotTableOpenConnectionEventHandler _WorkbookPivotTableOpenConnectionEvent;

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public event Application_WorkbookPivotTableOpenConnectionEventHandler WorkbookPivotTableOpenConnectionEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookPivotTableOpenConnectionEvent += value;
			}
			remove
			{
				_WorkbookPivotTableOpenConnectionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookSyncEventHandler _WorkbookSyncEvent;

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public event Application_WorkbookSyncEventHandler WorkbookSyncEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookSyncEvent += value;
			}
			remove
			{
				_WorkbookSyncEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookBeforeXmlImportEventHandler _WorkbookBeforeXmlImportEvent;

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public event Application_WorkbookBeforeXmlImportEventHandler WorkbookBeforeXmlImportEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookBeforeXmlImportEvent += value;
			}
			remove
			{
				_WorkbookBeforeXmlImportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookAfterXmlImportEventHandler _WorkbookAfterXmlImportEvent;

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public event Application_WorkbookAfterXmlImportEventHandler WorkbookAfterXmlImportEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookAfterXmlImportEvent += value;
			}
			remove
			{
				_WorkbookAfterXmlImportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookBeforeXmlExportEventHandler _WorkbookBeforeXmlExportEvent;

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public event Application_WorkbookBeforeXmlExportEventHandler WorkbookBeforeXmlExportEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookBeforeXmlExportEvent += value;
			}
			remove
			{
				_WorkbookBeforeXmlExportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		private event Application_WorkbookAfterXmlExportEventHandler _WorkbookAfterXmlExportEvent;

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public event Application_WorkbookAfterXmlExportEventHandler WorkbookAfterXmlExportEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookAfterXmlExportEvent += value;
			}
			remove
			{
				_WorkbookAfterXmlExportEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14
		/// </summary>
		private event Application_WorkbookRowsetCompleteEventHandler _WorkbookRowsetCompleteEvent;

		/// <summary>
		/// SupportByLibrary XL12 XL14
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public event Application_WorkbookRowsetCompleteEventHandler WorkbookRowsetCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookRowsetCompleteEvent += value;
			}
			remove
			{
				_WorkbookRowsetCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14
		/// </summary>
		private event Application_AfterCalculateEventHandler _AfterCalculateEvent;

		/// <summary>
		/// SupportByLibrary XL12 XL14
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public event Application_AfterCalculateEventHandler AfterCalculateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterCalculateEvent += value;
			}
			remove
			{
				_AfterCalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_SheetPivotTableAfterValueChangeEventHandler _SheetPivotTableAfterValueChangeEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_SheetPivotTableAfterValueChangeEventHandler SheetPivotTableAfterValueChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableAfterValueChangeEvent += value;
			}
			remove
			{
				_SheetPivotTableAfterValueChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_SheetPivotTableBeforeAllocateChangesEventHandler _SheetPivotTableBeforeAllocateChangesEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_SheetPivotTableBeforeAllocateChangesEventHandler SheetPivotTableBeforeAllocateChangesEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableBeforeAllocateChangesEvent += value;
			}
			remove
			{
				_SheetPivotTableBeforeAllocateChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_SheetPivotTableBeforeCommitChangesEventHandler _SheetPivotTableBeforeCommitChangesEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_SheetPivotTableBeforeCommitChangesEventHandler SheetPivotTableBeforeCommitChangesEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableBeforeCommitChangesEvent += value;
			}
			remove
			{
				_SheetPivotTableBeforeCommitChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_SheetPivotTableBeforeDiscardChangesEventHandler _SheetPivotTableBeforeDiscardChangesEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_SheetPivotTableBeforeDiscardChangesEventHandler SheetPivotTableBeforeDiscardChangesEvent
		{
			add
			{
				CreateEventBridge();
				_SheetPivotTableBeforeDiscardChangesEvent += value;
			}
			remove
			{
				_SheetPivotTableBeforeDiscardChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_ProtectedViewWindowOpenEventHandler _ProtectedViewWindowOpenEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_ProtectedViewWindowOpenEventHandler ProtectedViewWindowOpenEvent
		{
			add
			{
				CreateEventBridge();
				_ProtectedViewWindowOpenEvent += value;
			}
			remove
			{
				_ProtectedViewWindowOpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_ProtectedViewWindowBeforeEditEventHandler _ProtectedViewWindowBeforeEditEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_ProtectedViewWindowBeforeEditEventHandler ProtectedViewWindowBeforeEditEvent
		{
			add
			{
				CreateEventBridge();
				_ProtectedViewWindowBeforeEditEvent += value;
			}
			remove
			{
				_ProtectedViewWindowBeforeEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_ProtectedViewWindowBeforeCloseEventHandler _ProtectedViewWindowBeforeCloseEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_ProtectedViewWindowBeforeCloseEventHandler ProtectedViewWindowBeforeCloseEvent
		{
			add
			{
				CreateEventBridge();
				_ProtectedViewWindowBeforeCloseEvent += value;
			}
			remove
			{
				_ProtectedViewWindowBeforeCloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_ProtectedViewWindowResizeEventHandler _ProtectedViewWindowResizeEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_ProtectedViewWindowResizeEventHandler ProtectedViewWindowResizeEvent
		{
			add
			{
				CreateEventBridge();
				_ProtectedViewWindowResizeEvent += value;
			}
			remove
			{
				_ProtectedViewWindowResizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_ProtectedViewWindowActivateEventHandler _ProtectedViewWindowActivateEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_ProtectedViewWindowActivateEventHandler ProtectedViewWindowActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ProtectedViewWindowActivateEvent += value;
			}
			remove
			{
				_ProtectedViewWindowActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_ProtectedViewWindowDeactivateEventHandler _ProtectedViewWindowDeactivateEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_ProtectedViewWindowDeactivateEventHandler ProtectedViewWindowDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_ProtectedViewWindowDeactivateEvent += value;
			}
			remove
			{
				_ProtectedViewWindowDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_WorkbookAfterSaveEventHandler _WorkbookAfterSaveEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_WorkbookAfterSaveEventHandler WorkbookAfterSaveEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookAfterSaveEvent += value;
			}
			remove
			{
				_WorkbookAfterSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Application_WorkbookNewChartEventHandler _WorkbookNewChartEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Application_WorkbookNewChartEventHandler WorkbookNewChartEvent
		{
			add
			{
				CreateEventBridge();
				_WorkbookNewChartEvent += value;
			}
			remove
			{
				_WorkbookNewChartEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _appEvents_SinkHelper)
			{
				_appEvents_SinkHelper.Dispose();
				_appEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}