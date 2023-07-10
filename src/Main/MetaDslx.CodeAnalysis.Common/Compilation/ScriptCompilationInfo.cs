using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class ScriptCompilationInfo
    {
        private Compilation? _previousSubmission;
        private Type _submissionReturnType;
        private Type _hostObjectType;

        public ScriptCompilationInfo(Compilation? previousSubmission, Type submissionReturnType, Type hostObjectType)
        {
            _previousSubmission = previousSubmission;
            _submissionReturnType = submissionReturnType;
            _hostObjectType = hostObjectType;
        }

        public Compilation? PreviousSubmission => _previousSubmission;
        public Type SubmissionReturnType => _submissionReturnType;
        public Type HostObjectType => _hostObjectType;
    }
}
