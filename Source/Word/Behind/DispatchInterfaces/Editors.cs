﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.WordApi;

namespace NetOffice.WordApi.Behind
{
	/// <summary>
	/// DispatchInterface Editors 
	/// SupportByVersion Word, 11,12,14,15,16
	/// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836293.aspx </remarks>
	public class Editors : COMObject, NetOffice.WordApi.Editors
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.WordApi.Editors);
                return _contractType;
            }
        }
        private static Type _contractType;


		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Editors);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Editors() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836315.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual NetOffice.WordApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Application>(this, "Application", typeof(NetOffice.WordApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194730.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual Int32 Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837326.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836636.aspx </remarks>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Word", 11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.WordApi.Editor this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.WordApi.Editor>(this, "Item", typeof(NetOffice.WordApi.Editor), index);
			}
		}

		/// <summary>
		/// SupportByVersion Word 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838556.aspx </remarks>
		/// <param name="editorID">object editorID</param>
		[SupportByVersion("Word", 11,12,14,15,16)]
		public virtual NetOffice.WordApi.Editor Add(object editorID)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.WordApi.Editor>(this, "Add", typeof(NetOffice.WordApi.Editor), editorID);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.WordApi.Editor>

        ICOMObject IEnumerableProvider<NetOffice.WordApi.Editor>.GetComObjectEnumerator(ICOMObject parent)
        {
            return this;
        }

        IEnumerable IEnumerableProvider<NetOffice.WordApi.Editor>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.WordApi.Editor item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable<NetOffice.WordApi.Editor>

        /// <summary>
        /// SupportByVersion Word, 11,12,14,15,16
        /// This is a custom enumerator from NetOffice
        /// </summary>
        [SupportByVersion("Word", 11, 12, 14, 15, 16)]
        [CustomEnumerator]
        public virtual IEnumerator<NetOffice.WordApi.Editor> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.WordApi.Editor item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Word, 11,12,14,15,16
        /// This is a custom enumerator from NetOffice
        /// </summary>
        [SupportByVersion("Word", 11, 12, 14, 15, 16)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i + 1];

            foreach (object item in enumeratorObjects)
                yield return item;
        }

        #endregion

        #pragma warning restore
    }
}

