﻿using FubuCore;

namespace FubuMVC.Diagnostics.Models
{
    public class PackageDiagnosticsLogModel
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Provenance { get; set; }
        public string Timing { get; set; }
        public string FullTraceText { get; set; }
        public bool Success { get; set; }

        public bool HasTraceText()
        {
            return FullTraceText.IsNotEmpty();
        }
    }
}