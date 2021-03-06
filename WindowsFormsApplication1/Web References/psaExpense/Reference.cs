﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
// 
#pragma warning disable 1591

namespace WindowsFormsApplication1.psaExpense {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="psaExpenseWSFacadeBinding", Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    public partial class psaExpenseWSFacadeService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private SessionHeader sessionHeaderValueField;
        
        private CallOptions callOptionsValueField;
        
        private DebuggingHeader debuggingHeaderValueField;
        
        private AllowFieldTruncationHeader allowFieldTruncationHeaderValueField;
        
        private DebuggingInfo debuggingInfoValueField;
        
        private System.Threading.SendOrPostCallback insertExpensesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public psaExpenseWSFacadeService() {
            this.Url = global::WindowsFormsApplication1.Properties.Settings.Default.WindowsFormsApplication1_psaExpense_psaExpenseWSFacadeService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public SessionHeader SessionHeaderValue {
            get {
                return this.sessionHeaderValueField;
            }
            set {
                this.sessionHeaderValueField = value;
            }
        }
        
        public CallOptions CallOptionsValue {
            get {
                return this.callOptionsValueField;
            }
            set {
                this.callOptionsValueField = value;
            }
        }
        
        public DebuggingHeader DebuggingHeaderValue {
            get {
                return this.debuggingHeaderValueField;
            }
            set {
                this.debuggingHeaderValueField = value;
            }
        }
        
        public AllowFieldTruncationHeader AllowFieldTruncationHeaderValue {
            get {
                return this.allowFieldTruncationHeaderValueField;
            }
            set {
                this.allowFieldTruncationHeaderValueField = value;
            }
        }
        
        public DebuggingInfo DebuggingInfoValue {
            get {
                return this.debuggingInfoValueField;
            }
            set {
                this.debuggingInfoValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event insertExpensesCompletedEventHandler insertExpensesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("DebuggingHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("SessionHeaderValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("DebuggingInfoValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("CallOptionsValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("AllowFieldTruncationHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", ResponseNamespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result", IsNullable=true)]
        public psaExpenseWSResponse insertExpenses([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string batchId, [System.Xml.Serialization.XmlElementAttribute("concurExpenseReports", IsNullable=true)] psaConcurExpenseReport[] concurExpenseReports) {
            object[] results = this.Invoke("insertExpenses", new object[] {
                        batchId,
                        concurExpenseReports});
            return ((psaExpenseWSResponse)(results[0]));
        }
        
        /// <remarks/>
        public void insertExpensesAsync(string batchId, psaConcurExpenseReport[] concurExpenseReports) {
            this.insertExpensesAsync(batchId, concurExpenseReports, null);
        }
        
        /// <remarks/>
        public void insertExpensesAsync(string batchId, psaConcurExpenseReport[] concurExpenseReports, object userState) {
            if ((this.insertExpensesOperationCompleted == null)) {
                this.insertExpensesOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertExpensesOperationCompleted);
            }
            this.InvokeAsync("insertExpenses", new object[] {
                        batchId,
                        concurExpenseReports}, this.insertExpensesOperationCompleted, userState);
        }
        
        private void OninsertExpensesOperationCompleted(object arg) {
            if ((this.insertExpensesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertExpensesCompleted(this, new insertExpensesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", IsNullable=false)]
    public partial class DebuggingHeader : System.Web.Services.Protocols.SoapHeader {
        
        private LogInfo[] categoriesField;
        
        private LogType debugLevelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("categories")]
        public LogInfo[] categories {
            get {
                return this.categoriesField;
            }
            set {
                this.categoriesField = value;
            }
        }
        
        /// <remarks/>
        public LogType debugLevel {
            get {
                return this.debugLevelField;
            }
            set {
                this.debugLevelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    public partial class LogInfo {
        
        private LogCategory categoryField;
        
        private LogCategoryLevel levelField;
        
        /// <remarks/>
        public LogCategory category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public LogCategoryLevel level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    public enum LogCategory {
        
        /// <remarks/>
        Db,
        
        /// <remarks/>
        Workflow,
        
        /// <remarks/>
        Validation,
        
        /// <remarks/>
        Callout,
        
        /// <remarks/>
        Apex_code,
        
        /// <remarks/>
        Apex_profiling,
        
        /// <remarks/>
        Visualforce,
        
        /// <remarks/>
        System,
        
        /// <remarks/>
        All,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    public enum LogCategoryLevel {
        
        /// <remarks/>
        Internal,
        
        /// <remarks/>
        Finest,
        
        /// <remarks/>
        Finer,
        
        /// <remarks/>
        Fine,
        
        /// <remarks/>
        Debug,
        
        /// <remarks/>
        Info,
        
        /// <remarks/>
        Warn,
        
        /// <remarks/>
        Error,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSResponse")]
    public partial class Error {
        
        private string concurEntryIdField;
        
        private string concurReportKeyField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string concurEntryId {
            get {
                return this.concurEntryIdField;
            }
            set {
                this.concurEntryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string concurReportKey {
            get {
                return this.concurReportKeyField;
            }
            set {
                this.concurReportKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string errorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSResponse")]
    public partial class psaExpenseWSResponse {
        
        private Error[] errorListField;
        
        private System.Nullable<bool> successField;
        
        private bool successFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("errorList", IsNullable=true)]
        public Error[] errorList {
            get {
                return this.errorListField;
            }
            set {
                this.errorListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool successSpecified {
            get {
                return this.successFieldSpecified;
            }
            set {
                this.successFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaConcurExpenseReport")]
    public partial class psaConcurExpense {
        
        private System.Nullable<bool> billableField;
        
        private bool billableFieldSpecified;
        
        private string concurEntryIdField;
        
        private string descriptionField;
        
        private System.Nullable<double> expenseAmountField;
        
        private bool expenseAmountFieldSpecified;
        
        private string expenseCountryField;
        
        private string expenseCurrencyCodeField;
        
        private System.Nullable<System.DateTime> expenseDateField;
        
        private bool expenseDateFieldSpecified;
        
        private System.Nullable<double> expenseNonBillableAmountField;
        
        private bool expenseNonBillableAmountFieldSpecified;
        
        private string expenseStateField;
        
        private string expenseTypeField;
        
        private string expenseVendorField;
        
        private System.Nullable<double> govAllowanceAmountField;
        
        private bool govAllowanceAmountFieldSpecified;
        
        private System.Nullable<double> incurredTaxAmountField;
        
        private bool incurredTaxAmountFieldSpecified;
        
        private System.Nullable<bool> incurredTaxNonBillableField;
        
        private bool incurredTaxNonBillableFieldSpecified;
        
        private System.Nullable<int> millageField;
        
        private bool millageFieldSpecified;
        
        private System.Nullable<double> millageReimbursementRateField;
        
        private bool millageReimbursementRateFieldSpecified;
        
        private System.Nullable<bool> nonReimbursibleField;
        
        private bool nonReimbursibleFieldSpecified;
        
        private string notesField;
        
        private System.Nullable<int> numberOfAttendeesField;
        
        private bool numberOfAttendeesFieldSpecified;
        
        private string taxTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> billable {
            get {
                return this.billableField;
            }
            set {
                this.billableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billableSpecified {
            get {
                return this.billableFieldSpecified;
            }
            set {
                this.billableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string concurEntryId {
            get {
                return this.concurEntryIdField;
            }
            set {
                this.concurEntryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> expenseAmount {
            get {
                return this.expenseAmountField;
            }
            set {
                this.expenseAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expenseAmountSpecified {
            get {
                return this.expenseAmountFieldSpecified;
            }
            set {
                this.expenseAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string expenseCountry {
            get {
                return this.expenseCountryField;
            }
            set {
                this.expenseCountryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string expenseCurrencyCode {
            get {
                return this.expenseCurrencyCodeField;
            }
            set {
                this.expenseCurrencyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> expenseDate {
            get {
                return this.expenseDateField;
            }
            set {
                this.expenseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expenseDateSpecified {
            get {
                return this.expenseDateFieldSpecified;
            }
            set {
                this.expenseDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> expenseNonBillableAmount {
            get {
                return this.expenseNonBillableAmountField;
            }
            set {
                this.expenseNonBillableAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expenseNonBillableAmountSpecified {
            get {
                return this.expenseNonBillableAmountFieldSpecified;
            }
            set {
                this.expenseNonBillableAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string expenseState {
            get {
                return this.expenseStateField;
            }
            set {
                this.expenseStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string expenseType {
            get {
                return this.expenseTypeField;
            }
            set {
                this.expenseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string expenseVendor {
            get {
                return this.expenseVendorField;
            }
            set {
                this.expenseVendorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> govAllowanceAmount {
            get {
                return this.govAllowanceAmountField;
            }
            set {
                this.govAllowanceAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool govAllowanceAmountSpecified {
            get {
                return this.govAllowanceAmountFieldSpecified;
            }
            set {
                this.govAllowanceAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> incurredTaxAmount {
            get {
                return this.incurredTaxAmountField;
            }
            set {
                this.incurredTaxAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool incurredTaxAmountSpecified {
            get {
                return this.incurredTaxAmountFieldSpecified;
            }
            set {
                this.incurredTaxAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> incurredTaxNonBillable {
            get {
                return this.incurredTaxNonBillableField;
            }
            set {
                this.incurredTaxNonBillableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool incurredTaxNonBillableSpecified {
            get {
                return this.incurredTaxNonBillableFieldSpecified;
            }
            set {
                this.incurredTaxNonBillableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> millage {
            get {
                return this.millageField;
            }
            set {
                this.millageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool millageSpecified {
            get {
                return this.millageFieldSpecified;
            }
            set {
                this.millageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> millageReimbursementRate {
            get {
                return this.millageReimbursementRateField;
            }
            set {
                this.millageReimbursementRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool millageReimbursementRateSpecified {
            get {
                return this.millageReimbursementRateFieldSpecified;
            }
            set {
                this.millageReimbursementRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> nonReimbursible {
            get {
                return this.nonReimbursibleField;
            }
            set {
                this.nonReimbursibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nonReimbursibleSpecified {
            get {
                return this.nonReimbursibleFieldSpecified;
            }
            set {
                this.nonReimbursibleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> numberOfAttendees {
            get {
                return this.numberOfAttendeesField;
            }
            set {
                this.numberOfAttendeesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfAttendeesSpecified {
            get {
                return this.numberOfAttendeesFieldSpecified;
            }
            set {
                this.numberOfAttendeesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaConcurExpenseReport")]
    public partial class psaConcurExpenseReport {
        
        private string approverIdField;
        
        private System.Nullable<bool> billableField;
        
        private bool billableFieldSpecified;
        
        private System.Nullable<System.DateTime> concurExtractDateField;
        
        private bool concurExtractDateFieldSpecified;
        
        private string concurReportKeyField;
        
        private System.Nullable<System.DateTime> dateReimbursedField;
        
        private bool dateReimbursedFieldSpecified;
        
        private System.Nullable<System.DateTime> dateSubmittedField;
        
        private bool dateSubmittedFieldSpecified;
        
        private string descriptionField;
        
        private psaConcurExpense[] expensesField;
        
        private string projectCodeField;
        
        private string reportNameField;
        
        private string resourceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string approverId {
            get {
                return this.approverIdField;
            }
            set {
                this.approverIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> billable {
            get {
                return this.billableField;
            }
            set {
                this.billableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billableSpecified {
            get {
                return this.billableFieldSpecified;
            }
            set {
                this.billableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> concurExtractDate {
            get {
                return this.concurExtractDateField;
            }
            set {
                this.concurExtractDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool concurExtractDateSpecified {
            get {
                return this.concurExtractDateFieldSpecified;
            }
            set {
                this.concurExtractDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string concurReportKey {
            get {
                return this.concurReportKeyField;
            }
            set {
                this.concurReportKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> dateReimbursed {
            get {
                return this.dateReimbursedField;
            }
            set {
                this.dateReimbursedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateReimbursedSpecified {
            get {
                return this.dateReimbursedFieldSpecified;
            }
            set {
                this.dateReimbursedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true)]
        public System.Nullable<System.DateTime> dateSubmitted {
            get {
                return this.dateSubmittedField;
            }
            set {
                this.dateSubmittedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSubmittedSpecified {
            get {
                return this.dateSubmittedFieldSpecified;
            }
            set {
                this.dateSubmittedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expenses", IsNullable=true)]
        public psaConcurExpense[] expenses {
            get {
                return this.expensesField;
            }
            set {
                this.expensesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string projectCode {
            get {
                return this.projectCodeField;
            }
            set {
                this.projectCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string reportName {
            get {
                return this.reportNameField;
            }
            set {
                this.reportNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string resourceId {
            get {
                return this.resourceIdField;
            }
            set {
                this.resourceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    public enum LogType {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Debugonly,
        
        /// <remarks/>
        Db,
        
        /// <remarks/>
        Profiling,
        
        /// <remarks/>
        Callout,
        
        /// <remarks/>
        Detail,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", IsNullable=false)]
    public partial class SessionHeader : System.Web.Services.Protocols.SoapHeader {
        
        private string sessionIdField;
        
        /// <remarks/>
        public string sessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", IsNullable=false)]
    public partial class DebuggingInfo : System.Web.Services.Protocols.SoapHeader {
        
        private string debugLogField;
        
        /// <remarks/>
        public string debugLog {
            get {
                return this.debugLogField;
            }
            set {
                this.debugLogField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", IsNullable=false)]
    public partial class CallOptions : System.Web.Services.Protocols.SoapHeader {
        
        private string clientField;
        
        /// <remarks/>
        public string client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soap.sforce.com/schemas/class/psaExpenseWSFacade", IsNullable=false)]
    public partial class AllowFieldTruncationHeader : System.Web.Services.Protocols.SoapHeader {
        
        private bool allowFieldTruncationField;
        
        /// <remarks/>
        public bool allowFieldTruncation {
            get {
                return this.allowFieldTruncationField;
            }
            set {
                this.allowFieldTruncationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void insertExpensesCompletedEventHandler(object sender, insertExpensesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertExpensesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertExpensesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public psaExpenseWSResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((psaExpenseWSResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591