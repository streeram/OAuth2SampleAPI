//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatientJourney.DataAccess.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient_Journey
    {
        public Patient_Journey()
        {
            this.Patient_Journey_Strategic_Moment = new HashSet<Patient_Journey_Strategic_Moment>();
            this.Patient_Journey_Temp = new HashSet<Patient_Journey_Temp>();
            this.Patient_Journey_Stages = new HashSet<Patient_Journey_Stages>();
            this.Patient_Journey_VersionDetails = new HashSet<Patient_Journey_VersionDetails>();
            this.Patient_Journey_Patient_Insights = new HashSet<Patient_Journey_Patient_Insights>();
            this.Patient_Journey_HCP_Insights = new HashSet<Patient_Journey_HCP_Insights>();
            this.Patient_Journey_Payor_Insights = new HashSet<Patient_Journey_Payor_Insights>();
        }
    
        public int Patient_Journey_Id { get; set; }
        public string Journey_Title { get; set; }
        public Nullable<int> Brand_Master_Id { get; set; }
        public Nullable<int> Country_Master_Id { get; set; }
        public Nullable<int> Status_Master_Id { get; set; }
        public string User_Comments { get; set; }
        public string Approver_Comments { get; set; }
        public int Year { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Submitted_By { get; set; }
        public Nullable<System.DateTime> Submitted_Date { get; set; }
        public string Approved_By { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public string Journey_Description { get; set; }
    
        public virtual Brand_Master Brand_Master { get; set; }
        public virtual Country_Master Country_Master { get; set; }
        public virtual ICollection<Patient_Journey_Strategic_Moment> Patient_Journey_Strategic_Moment { get; set; }
        public virtual ICollection<Patient_Journey_Temp> Patient_Journey_Temp { get; set; }
        public virtual ICollection<Patient_Journey_Stages> Patient_Journey_Stages { get; set; }
        public virtual ICollection<Patient_Journey_VersionDetails> Patient_Journey_VersionDetails { get; set; }
        public virtual Status_Master Status_Master { get; set; }
        public virtual ICollection<Patient_Journey_Patient_Insights> Patient_Journey_Patient_Insights { get; set; }
        public virtual ICollection<Patient_Journey_HCP_Insights> Patient_Journey_HCP_Insights { get; set; }
        public virtual ICollection<Patient_Journey_Payor_Insights> Patient_Journey_Payor_Insights { get; set; }
    }
}
