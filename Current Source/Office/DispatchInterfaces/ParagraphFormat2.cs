//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface ParagraphFormat2 
	/// SupportByVersion Office, 12,14
	///</summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ParagraphFormat2 : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ParagraphFormat2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ParagraphFormat2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ParagraphFormat2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ParagraphFormat2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ParagraphFormat2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ParagraphFormat2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
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
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoParagraphAlignment Alignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Alignment", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoParagraphAlignment)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Alignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoBaselineAlignment BaselineAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaselineAlignment", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBaselineAlignment)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BaselineAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.BulletFormat2 Bullet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bullet", paramsArray);
				NetOffice.OfficeApi.BulletFormat2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.BulletFormat2.LateBindingApiWrapperType) as NetOffice.OfficeApi.BulletFormat2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState FarEastLineBreakLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FarEastLineBreakLevel", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FarEastLineBreakLevel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single FirstLineIndent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstLineIndent", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstLineIndent", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HangingPunctuation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HangingPunctuation", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HangingPunctuation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Int32 IndentLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IndentLevel", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IndentLevel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single LeftIndent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftIndent", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LeftIndent", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState LineRuleAfter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineRuleAfter", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LineRuleAfter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState LineRuleBefore
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineRuleBefore", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LineRuleBefore", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState LineRuleWithin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineRuleWithin", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LineRuleWithin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single RightIndent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightIndent", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RightIndent", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single SpaceAfter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpaceAfter", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpaceAfter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single SpaceBefore
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpaceBefore", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpaceBefore", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public Single SpaceWithin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpaceWithin", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpaceWithin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TabStops2 TabStops
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TabStops", paramsArray);
				NetOffice.OfficeApi.TabStops2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TabStops2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TabStops2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTextDirection TextDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextDirection", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTextDirection)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextDirection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState WordWrap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordWrap", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WordWrap", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}