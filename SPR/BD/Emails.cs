//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPR.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emails
    {
        public System.Guid Receiver_Email_ID { get; set; }
        public string Receiver_EmailAddress { get; set; }
        public string Receiver_EmailSubject { get; set; }
        public string Receiver_EmailBody { get; set; }
    
        public virtual ServerPerformances ServerPerformances { get; set; }
        public virtual Receivers Receivers { get; set; }
    }
}