﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi
{
	/// <summary>
	/// DispatchInterface DispHTMLUrnCollection 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
	[TypeId("3050F551-98B5-11CF-BB82-00AA00BDCE0B")]
    [CoClassSource(typeof(NetOffice.MSHTMLApi.HTMLUrnCollection))]
    public interface DispHTMLUrnCollection : ICOMObject
	{
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		Int32 length { get; }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		object constructor { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersion("MSHTML", 4)]
		string item(Int32 index);

		#endregion
	}
}
