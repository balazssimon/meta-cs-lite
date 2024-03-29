﻿using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public static class ModelErrorCode
    {
        /// <summary>
        /// XMI error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_XmiError = DiagnosticDescriptor.Error(nameof(ERR_XmiError), "XMI error", "{0}");

        /// <summary>
        /// XMI warning: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_XmiWarning = DiagnosticDescriptor.Warning(nameof(WRN_XmiWarning), "XMI warning", "{0}");

        /// <summary>
        /// Import error: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor ERR_ImportError = DiagnosticDescriptor.Error(nameof(ERR_ImportError), "Import error", "{0}");

        /// <summary>
        /// Import warning: {0}
        /// </summary>
        public static readonly DiagnosticDescriptor WRN_ImportWarning = DiagnosticDescriptor.Warning(nameof(WRN_ImportWarning), "Import warning", "{0}");
    }
}
