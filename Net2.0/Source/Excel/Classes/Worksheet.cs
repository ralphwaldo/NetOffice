//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Worksheet_SelectionChangeEventHandler(LateBindingApi.ExcelApi.Range Target);
	public delegate void Worksheet_BeforeDoubleClickEventHandler(LateBindingApi.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Worksheet_BeforeRightClickEventHandler(LateBindingApi.ExcelApi.Range Target, ref bool Cancel);
	public delegate void Worksheet_ActivateEventHandler();
	public delegate void Worksheet_DeactivateEventHandler();
	public delegate void Worksheet_CalculateEventHandler();
	public delegate void Worksheet_ChangeEventHandler(LateBindingApi.ExcelApi.Range Target);
	public delegate void Worksheet_FollowHyperlinkEventHandler(LateBindingApi.ExcelApi.Hyperlink Target);
	public delegate void Worksheet_PivotTableUpdateEventHandler(LateBindingApi.ExcelApi.PivotTable Target);
	public delegate void Worksheet_PivotTableAfterValueChangeEventHandler(LateBindingApi.ExcelApi.PivotTable TargetPivotTable, LateBindingApi.ExcelApi.Range TargetRange);
	public delegate void Worksheet_PivotTableBeforeAllocateChangesEventHandler(LateBindingApi.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Worksheet_PivotTableBeforeCommitChangesEventHandler(LateBindingApi.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd, ref bool Cancel);
	public delegate void Worksheet_PivotTableBeforeDiscardChangesEventHandler(LateBindingApi.ExcelApi.PivotTable TargetPivotTable, Int32 ValueChangeStart, Int32 ValueChangeEnd);
	public delegate void Worksheet_PivotTableChangeSyncEventHandler(LateBindingApi.ExcelApi.PivotTable Target);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Worksheet SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	public class Worksheet : _Worksheet, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		DocEvents_SinkHelper _docEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Worksheet(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Worksheet(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Worksheet(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Worksheet()
		{
			CreateFromProgId("Excel.Worksheet");
		}
		
		/// <param name="progId">progId</param>
		public Worksheet(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, DocEvents_SinkHelper.Id);


			if(DocEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_docEvents_SinkHelper = new DocEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_SelectionChangeEventHandler SelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangeEvent += value;
			}
			remove
			{
				_SelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_BeforeDoubleClickEventHandler _BeforeDoubleClickEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_BeforeDoubleClickEventHandler BeforeDoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDoubleClickEvent += value;
			}
			remove
			{
				_BeforeDoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_BeforeRightClickEventHandler _BeforeRightClickEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_BeforeRightClickEventHandler BeforeRightClickEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeRightClickEvent += value;
			}
			remove
			{
				_BeforeRightClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_CalculateEventHandler _CalculateEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_CalculateEventHandler CalculateEvent
		{
			add
			{
				CreateEventBridge();
				_CalculateEvent += value;
			}
			remove
			{
				_CalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_FollowHyperlinkEventHandler _FollowHyperlinkEvent;

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public event Worksheet_FollowHyperlinkEventHandler FollowHyperlinkEvent
		{
			add
			{
				CreateEventBridge();
				_FollowHyperlinkEvent += value;
			}
			remove
			{
				_FollowHyperlinkEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		private event Worksheet_PivotTableUpdateEventHandler _PivotTableUpdateEvent;

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public event Worksheet_PivotTableUpdateEventHandler PivotTableUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableUpdateEvent += value;
			}
			remove
			{
				_PivotTableUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Worksheet_PivotTableAfterValueChangeEventHandler _PivotTableAfterValueChangeEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Worksheet_PivotTableAfterValueChangeEventHandler PivotTableAfterValueChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableAfterValueChangeEvent += value;
			}
			remove
			{
				_PivotTableAfterValueChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Worksheet_PivotTableBeforeAllocateChangesEventHandler _PivotTableBeforeAllocateChangesEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Worksheet_PivotTableBeforeAllocateChangesEventHandler PivotTableBeforeAllocateChangesEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableBeforeAllocateChangesEvent += value;
			}
			remove
			{
				_PivotTableBeforeAllocateChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Worksheet_PivotTableBeforeCommitChangesEventHandler _PivotTableBeforeCommitChangesEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Worksheet_PivotTableBeforeCommitChangesEventHandler PivotTableBeforeCommitChangesEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableBeforeCommitChangesEvent += value;
			}
			remove
			{
				_PivotTableBeforeCommitChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Worksheet_PivotTableBeforeDiscardChangesEventHandler _PivotTableBeforeDiscardChangesEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Worksheet_PivotTableBeforeDiscardChangesEventHandler PivotTableBeforeDiscardChangesEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableBeforeDiscardChangesEvent += value;
			}
			remove
			{
				_PivotTableBeforeDiscardChangesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		private event Worksheet_PivotTableChangeSyncEventHandler _PivotTableChangeSyncEvent;

		/// <summary>
		/// SupportByLibrary XL14
		/// </summary>
		[SupportByLibrary("XL14")]
		public event Worksheet_PivotTableChangeSyncEventHandler PivotTableChangeSyncEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableChangeSyncEvent += value;
			}
			remove
			{
				_PivotTableChangeSyncEvent -= value;
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
			if( null != _docEvents_SinkHelper)
			{
				_docEvents_SinkHelper.Dispose();
				_docEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}