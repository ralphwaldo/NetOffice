//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.WordApi
{
	///<summary>
	/// DispatchInterface OMathFunction SupportByLibrary WD12 WD14 
	///</summary>
	[SupportByLibrary("WD12","WD14")]
	public class OMathFunction : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunction(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunction(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunction(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathFunction()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdOMathFunctionType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdOMathFunctionType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
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
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				LateBindingApi.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathArgs Args
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Args", paramsArray);
				LateBindingApi.WordApi.OMathArgs newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathArgs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathAcc Acc
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Acc", paramsArray);
				LateBindingApi.WordApi.OMathAcc newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathAcc;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathBar Bar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bar", paramsArray);
				LateBindingApi.WordApi.OMathBar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathBar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathBox Box
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Box", paramsArray);
				LateBindingApi.WordApi.OMathBox newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathBox;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathBorderBox BorderBox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BorderBox", paramsArray);
				LateBindingApi.WordApi.OMathBorderBox newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathBorderBox;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathDelim Delim
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Delim", paramsArray);
				LateBindingApi.WordApi.OMathDelim newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathDelim;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathEqArray EqArray
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EqArray", paramsArray);
				LateBindingApi.WordApi.OMathEqArray newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathEqArray;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathFrac Frac
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Frac", paramsArray);
				LateBindingApi.WordApi.OMathFrac newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathFrac;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathFunc Func
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Func", paramsArray);
				LateBindingApi.WordApi.OMathFunc newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathFunc;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathGroupChar GroupChar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupChar", paramsArray);
				LateBindingApi.WordApi.OMathGroupChar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathGroupChar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathLimLow LimLow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LimLow", paramsArray);
				LateBindingApi.WordApi.OMathLimLow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathLimLow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathLimUpp LimUpp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LimUpp", paramsArray);
				LateBindingApi.WordApi.OMathLimUpp newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathLimUpp;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathMat Mat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mat", paramsArray);
				LateBindingApi.WordApi.OMathMat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathMat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathNary Nary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nary", paramsArray);
				LateBindingApi.WordApi.OMathNary newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathNary;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathPhantom Phantom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Phantom", paramsArray);
				LateBindingApi.WordApi.OMathPhantom newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathPhantom;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathScrPre ScrPre
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScrPre", paramsArray);
				LateBindingApi.WordApi.OMathScrPre newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathScrPre;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathRad Rad
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rad", paramsArray);
				LateBindingApi.WordApi.OMathRad newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathRad;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathScrSub ScrSub
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScrSub", paramsArray);
				LateBindingApi.WordApi.OMathScrSub newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathScrSub;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathScrSubSup ScrSubSup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScrSubSup", paramsArray);
				LateBindingApi.WordApi.OMathScrSubSup newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathScrSubSup;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathScrSup ScrSup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScrSup", paramsArray);
				LateBindingApi.WordApi.OMathScrSup newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMathScrSup;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMath OMath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OMath", paramsArray);
				LateBindingApi.WordApi.OMath newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.OMath;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public LateBindingApi.WordApi.OMathFunction Remove()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Remove", paramsArray);
			LateBindingApi.WordApi.OMathFunction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.OMathFunction;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}