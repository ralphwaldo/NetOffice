﻿//Generated by LateBindingApi.CodeGenerator
using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using LateBindingApi.Core;

namespace WordApi.Utils
{
	#pragma warning disable
    /// <summary>
    /// necessary factory info, used from LateBindingApi.Core.Factory while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Field

        private string   _namespace     = "LateBindingApi.WordApi";
        private Guid     _componentGuid = new Guid("00020905-0000-0000-C000-000000000046");
        private Assembly _assembly;

        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

        public string Namespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        #endregion
    }
    #pragma warning restore
}
