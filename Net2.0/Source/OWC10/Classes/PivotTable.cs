//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{

	#region Delegates

	#pragma warning disable
	public delegate void PivotTable_SelectionChangeEventHandler();
	public delegate void PivotTable_ViewChangeEventHandler(LateBindingApi.OWC10Api.Enums.PivotViewReasonEnum Reason);
	public delegate void PivotTable_DataChangeEventHandler(LateBindingApi.OWC10Api.Enums.PivotDataReasonEnum Reason);
	public delegate void PivotTable_PivotTableChangeEventHandler(LateBindingApi.OWC10Api.Enums.PivotTableReasonEnum Reason);
	public delegate void PivotTable_BeforeQueryEventHandler();
	public delegate void PivotTable_QueryEventHandler();
	public delegate void PivotTable_OnConnectEventHandler();
	public delegate void PivotTable_OnDisconnectEventHandler();
	public delegate void PivotTable_MouseDownEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void PivotTable_MouseMoveEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void PivotTable_MouseUpEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void PivotTable_MouseWheelEventHandler(bool Page, Int32 Count);
	public delegate void PivotTable_ClickEventHandler();
	public delegate void PivotTable_DblClickEventHandler();
	public delegate void PivotTable_CommandEnabledEventHandler(COMObject Command, LateBindingApi.OWC10Api.ByRef Enabled);
	public delegate void PivotTable_CommandCheckedEventHandler(COMObject Command, LateBindingApi.OWC10Api.ByRef Checked);
	public delegate void PivotTable_CommandTipTextEventHandler(COMObject Command, LateBindingApi.OWC10Api.ByRef Caption);
	public delegate void PivotTable_CommandBeforeExecuteEventHandler(COMObject Command, LateBindingApi.OWC10Api.ByRef Cancel);
	public delegate void PivotTable_CommandExecuteEventHandler(COMObject Command, bool Succeeded);
	public delegate void PivotTable_KeyDownEventHandler(Int32 KeyCode, Int32 Shift);
	public delegate void PivotTable_KeyUpEventHandler(Int32 KeyCode, Int32 Shift);
	public delegate void PivotTable_KeyPressEventHandler(Int32 KeyAscii);
	public delegate void PivotTable_BeforeKeyDownEventHandler(Int32 KeyCode, Int32 Shift, LateBindingApi.OWC10Api.ByRef Cancel);
	public delegate void PivotTable_BeforeKeyUpEventHandler(Int32 KeyCode, Int32 Shift, LateBindingApi.OWC10Api.ByRef Cancel);
	public delegate void PivotTable_BeforeKeyPressEventHandler(Int32 KeyAscii, LateBindingApi.OWC10Api.ByRef Cancel);
	public delegate void PivotTable_BeforeContextMenuEventHandler(Int32 x, Int32 y, LateBindingApi.OWC10Api.ByRef Menu, LateBindingApi.OWC10Api.ByRef Cancel);
	public delegate void PivotTable_StartEditEventHandler(COMObject Selection, COMObject ActiveObject, LateBindingApi.OWC10Api.ByRef InitialValue, LateBindingApi.OWC10Api.ByRef ArrowMode, LateBindingApi.OWC10Api.ByRef CaretPosition, LateBindingApi.OWC10Api.ByRef Cancel, LateBindingApi.OWC10Api.ByRef ErrorDescription);
	public delegate void PivotTable_EndEditEventHandler(bool Accept, LateBindingApi.OWC10Api.ByRef FinalValue, LateBindingApi.OWC10Api.ByRef Cancel, LateBindingApi.OWC10Api.ByRef ErrorDescription);
	public delegate void PivotTable_BeforeScreenTipEventHandler(LateBindingApi.OWC10Api.ByRef ScreenTipText, COMObject SourceObject);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass PivotTable SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class PivotTable : IPivotControl, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		IPivotControlEvents_SinkHelper _iPivotControlEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotTable(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public PivotTable()
		{
			CreateFromProgId("OWC10.PivotTable");
		}
		
		/// <param name="progId">progId</param>
		public PivotTable(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, IPivotControlEvents_SinkHelper.Id);


			if(IPivotControlEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iPivotControlEvents_SinkHelper = new IPivotControlEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_SelectionChangeEventHandler SelectionChangeEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_ViewChangeEventHandler _ViewChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_ViewChangeEventHandler ViewChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ViewChangeEvent += value;
			}
			remove
			{
				_ViewChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_DataChangeEventHandler _DataChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_DataChangeEventHandler DataChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DataChangeEvent += value;
			}
			remove
			{
				_DataChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_PivotTableChangeEventHandler _PivotTableChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_PivotTableChangeEventHandler PivotTableChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PivotTableChangeEvent += value;
			}
			remove
			{
				_PivotTableChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_BeforeQueryEventHandler _BeforeQueryEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_BeforeQueryEventHandler BeforeQueryEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeQueryEvent += value;
			}
			remove
			{
				_BeforeQueryEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_QueryEventHandler _QueryEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_QueryEventHandler QueryEvent
		{
			add
			{
				CreateEventBridge();
				_QueryEvent += value;
			}
			remove
			{
				_QueryEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_OnConnectEventHandler _OnConnectEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_OnConnectEventHandler OnConnectEvent
		{
			add
			{
				CreateEventBridge();
				_OnConnectEvent += value;
			}
			remove
			{
				_OnConnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_OnDisconnectEventHandler _OnDisconnectEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_OnDisconnectEventHandler OnDisconnectEvent
		{
			add
			{
				CreateEventBridge();
				_OnDisconnectEvent += value;
			}
			remove
			{
				_OnDisconnectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_MouseWheelEventHandler _MouseWheelEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_MouseWheelEventHandler MouseWheelEvent
		{
			add
			{
				CreateEventBridge();
				_MouseWheelEvent += value;
			}
			remove
			{
				_MouseWheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_CommandEnabledEventHandler _CommandEnabledEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_CommandEnabledEventHandler CommandEnabledEvent
		{
			add
			{
				CreateEventBridge();
				_CommandEnabledEvent += value;
			}
			remove
			{
				_CommandEnabledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_CommandCheckedEventHandler _CommandCheckedEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_CommandCheckedEventHandler CommandCheckedEvent
		{
			add
			{
				CreateEventBridge();
				_CommandCheckedEvent += value;
			}
			remove
			{
				_CommandCheckedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_CommandTipTextEventHandler _CommandTipTextEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_CommandTipTextEventHandler CommandTipTextEvent
		{
			add
			{
				CreateEventBridge();
				_CommandTipTextEvent += value;
			}
			remove
			{
				_CommandTipTextEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_CommandBeforeExecuteEventHandler _CommandBeforeExecuteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_CommandBeforeExecuteEventHandler CommandBeforeExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandBeforeExecuteEvent += value;
			}
			remove
			{
				_CommandBeforeExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_CommandExecuteEventHandler _CommandExecuteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_CommandExecuteEventHandler CommandExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandExecuteEvent += value;
			}
			remove
			{
				_CommandExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_BeforeKeyDownEventHandler _BeforeKeyDownEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_BeforeKeyDownEventHandler BeforeKeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyDownEvent += value;
			}
			remove
			{
				_BeforeKeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_BeforeKeyUpEventHandler _BeforeKeyUpEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_BeforeKeyUpEventHandler BeforeKeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyUpEvent += value;
			}
			remove
			{
				_BeforeKeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_BeforeKeyPressEventHandler _BeforeKeyPressEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_BeforeKeyPressEventHandler BeforeKeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyPressEvent += value;
			}
			remove
			{
				_BeforeKeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_BeforeContextMenuEventHandler _BeforeContextMenuEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_BeforeContextMenuEventHandler BeforeContextMenuEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeContextMenuEvent += value;
			}
			remove
			{
				_BeforeContextMenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_StartEditEventHandler _StartEditEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_StartEditEventHandler StartEditEvent
		{
			add
			{
				CreateEventBridge();
				_StartEditEvent += value;
			}
			remove
			{
				_StartEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_EndEditEventHandler _EndEditEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_EndEditEventHandler EndEditEvent
		{
			add
			{
				CreateEventBridge();
				_EndEditEvent += value;
			}
			remove
			{
				_EndEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event PivotTable_BeforeScreenTipEventHandler _BeforeScreenTipEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event PivotTable_BeforeScreenTipEventHandler BeforeScreenTipEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeScreenTipEvent += value;
			}
			remove
			{
				_BeforeScreenTipEvent -= value;
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
			if( null != _iPivotControlEvents_SinkHelper)
			{
				_iPivotControlEvents_SinkHelper.Dispose();
				_iPivotControlEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}