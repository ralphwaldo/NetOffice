//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OlkDateControl_ClickEventHandler();
	public delegate void OlkDateControl_DoubleClickEventHandler();
	public delegate void OlkDateControl_MouseDownEventHandler(LateBindingApi.OutlookApi.Enums.OlMouseButton Button, LateBindingApi.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkDateControl_MouseMoveEventHandler(LateBindingApi.OutlookApi.Enums.OlMouseButton Button, LateBindingApi.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkDateControl_MouseUpEventHandler(LateBindingApi.OutlookApi.Enums.OlMouseButton Button, LateBindingApi.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkDateControl_EnterEventHandler();
	public delegate void OlkDateControl_ExitEventHandler(ref bool Cancel);
	public delegate void OlkDateControl_KeyDownEventHandler(ref Int32 KeyCode, LateBindingApi.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkDateControl_KeyPressEventHandler(ref Int32 KeyAscii);
	public delegate void OlkDateControl_KeyUpEventHandler(ref Int32 KeyCode, LateBindingApi.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkDateControl_ChangeEventHandler();
	public delegate void OlkDateControl_DropButtonClickEventHandler();
	public delegate void OlkDateControl_AfterUpdateEventHandler();
	public delegate void OlkDateControl_BeforeUpdateEventHandler(ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OlkDateControl SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	public class OlkDateControl : _OlkDateControl, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OlkDateControlEvents_SinkHelper _olkDateControlEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkDateControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkDateControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkDateControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OlkDateControl()
		{
			CreateFromProgId("Outlook.OlkDateControl");
		}
		
		/// <param name="progId">progId</param>
		public OlkDateControl(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OlkDateControlEvents_SinkHelper.Id);


			if(OlkDateControlEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_olkDateControlEvents_SinkHelper = new OlkDateControlEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_ClickEventHandler ClickEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_DoubleClickEventHandler _DoubleClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_DoubleClickEventHandler DoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_DoubleClickEvent += value;
			}
			remove
			{
				_DoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_KeyDownEventHandler KeyDownEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_KeyPressEventHandler KeyPressEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_KeyUpEventHandler KeyUpEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_ChangeEventHandler ChangeEvent
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
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_DropButtonClickEventHandler _DropButtonClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_DropButtonClickEventHandler DropButtonClickEvent
		{
			add
			{
				CreateEventBridge();
				_DropButtonClickEvent += value;
			}
			remove
			{
				_DropButtonClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkDateControl_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkDateControl_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
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
			if( null != _olkDateControlEvents_SinkHelper)
			{
				_olkDateControlEvents_SinkHelper.Dispose();
				_olkDateControlEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}