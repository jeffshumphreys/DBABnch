using System;

// Super-master-developer gurus say never to customize exceptions. Because.
// But, when I do, for my programs, I get a richer response, can develop faster, and therefore more bugs occur, but they're easier to fix.
// Fuck. Gurus.

namespace QuickInterface
{
    // Surprisingly there is no such thing in .NET.  But this tells me a bit more.  What happened? the value crashed it?  It's not out of range, it's just not one we coded for.
    public class ArgumentUnrecognizedException : ArgumentException
    {
        
    }

    public class TypeUnrecognizedException : SystemException
    {
        private Type typeUnrecognizedByCodeBranches;
        private string nameOfFieldThatIsOfThisType;
        public TypeUnrecognizedException(Type typeUnrecognizedByCodeBranchesReportToDeveloperToAddBranch, string nameOfPropWithThisType, string optionalMessage = "No additional message given.")
            : base($"Type {typeUnrecognizedByCodeBranchesReportToDeveloperToAddBranch.Name} not recognized in this method.  Variable was {nameOfPropWithThisType}. Either add a branch for this type, or fix caller, or constrain this field so that it cannot be assigned an unsupported type. {optionalMessage}")
        {
            typeUnrecognizedByCodeBranches = typeUnrecognizedByCodeBranchesReportToDeveloperToAddBranch;
            nameOfFieldThatIsOfThisType = nameOfPropWithThisType;
        }

    }

    public class UnsupportedFeatureException : ArgumentException
    {
        public UnsupportedFeatureException(string message) : base(message)
        {
        }
    }

    public class UnsupportedFeatureExceptionButAGreatOppForADynamicFeature : ArgumentException
    {
        public UnsupportedFeatureExceptionButAGreatOppForADynamicFeature(string message) : base(message)
        {
        }
    }

    public class IncompatibleTypesException : ArgumentException
    {
        public IncompatibleTypesException(string message): base(message) { }
    }
    public class NotSupportingOtherTypesYetException : ArgumentException
    {
        public NotSupportingOtherTypesYetException(string message) : base(message) { }
    }
    public class DuplicateUIElementException : ArgumentException
    {
        public DuplicateUIElementException(string message) : base(message) { }
    }
}
