using System;
using Newtonsoft.Json;

namespace Models
{
    public class ApplicationsResult
    {
        [JsonProperty("ID")]
        public int? Id { get; set; }

        [JsonProperty("TITLE")]
        public string Title { get; set; }

        [JsonProperty("first_Name")]
        public string firstName { get; set; }

        [JsonProperty("last_Name")]
        public string lastName { get; set; }

        [JsonProperty("Address1")]
        public string Add1 { get; set; }

        [JsonProperty("Address2")]
        public string Add2 { get; set; }

        [JsonProperty("Address3")]
        public string Add3 { get; set; }

        [JsonProperty("Address4")]
        public string Add4 { get; set; }

        [JsonProperty("Address5")]
        public string Add5 { get; set; }

        [JsonProperty("Address6")]
        public string Add6 { get; set; }

        [JsonProperty("Postcode1")]
        public string Postcode1 { get; set; }

        [JsonProperty("Postcode2")]
        public string Postcode2 { get; set; }

        [JsonProperty("Telephone_no")]
        public string Telephone_no { get; set; }

        [JsonProperty("Mobile_no")]
        public string Mobile_no { get; set; }

        [JsonProperty("Date_of_birth")]
        public DateTime? DOB { get; set; }

        [JsonProperty("Sex")]
        public string Sex { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("NOK_Title")]
        public string NOK_Title { get; set; }

        [JsonProperty("NOK_first_Name")]
        public string NOK_firstName { get; set; }

        [JsonProperty("NOK_last_Name")]
        public string NOK_lastName { get; set; }

        [JsonProperty("NOK_Address1")]
        public string NOK_Add1 { get; set; }

        [JsonProperty("NOK_Address2")]
        public string NOK_Add2 { get; set; }

        [JsonProperty("NOK_Address3")]
        public string NOK_Add3 { get; set; }

        [JsonProperty("NOK_Address4")]
        public string NOK_Add4 { get; set; }

        [JsonProperty("NOK_Address5")]
        public string NOK_Add5 { get; set; }

        [JsonProperty("NOK_Address6")]
        public string NOK_Add6 { get; set; }

        [JsonProperty("NOK_Postcode1")]
        public string NOK_Postcode1 { get; set; }

        [JsonProperty("NOK_Postcode2")]
        public string NOK_Postcode2 { get; set; }

        [JsonProperty("NOK_Telephone_no")]
        public string NOK_Telephone_no { get; set; }

        [JsonProperty("NOK_Mobile_no")]
        public string NOK_Mobile_no { get; set; }

        [JsonProperty("NOK_Date_of_Birth")]
        public DateTime? NOK_DOB { get; set; }

        [JsonProperty("NOK_Sex")]
        public string NOK_Sex { get; set; }

        [JsonProperty("NOK_email")]
        public string NOK_email { get; set; }

        [JsonProperty("NOK_relation")]
        public string NOK_relation { get; set; }

        [JsonProperty("NOK_country")]
        public string NOK_country { get; set; }

        [JsonProperty("REP_Title")]
        public string REP_Title { get; set; }

        [JsonProperty("REP_first_Name")]
        public string REP_firstName { get; set; }

        [JsonProperty("REP_last_Name")]
        public string REP_lastName { get; set; }

        [JsonProperty("REP_Address1")]
        public string REP_Add1 { get; set; }

        [JsonProperty("REP_Address2")]
        public string REP_Add2 { get; set; }

        [JsonProperty("REP_Address3")]
        public string REP_Add3 { get; set; }

        [JsonProperty("REP_Address4")]
        public string REP_Add4 { get; set; }

        [JsonProperty("REP_Address5")]
        public string REP_Add5 { get; set; }

        [JsonProperty("REP_Address6")]
        public string REP_Add6 { get; set; }

        [JsonProperty("REP_Postcode1")]
        public string REP_Postcode1 { get; set; }

        [JsonProperty("REP_Postcode2")]
        public string REP_Postcode2 { get; set; }

        [JsonProperty("REP_Telephone_no")]
        public string REP_Telephone_no { get; set; }

        [JsonProperty("REP_Mobile_no")]
        public string REP_Mobile_no { get; set; }

        [JsonProperty("REP_Date_of_birth")]
        public DateTime? REP_DOB { get; set; }

        [JsonProperty("REP_Sex")]
        public string REP_Sex { get; set; }

        [JsonProperty("REP_email")]
        public string REP_email { get; set; }

        [JsonProperty("REP_relation")]
        public string REP_relation { get; set; }

        [JsonProperty("REP_country")]
        public string REP_country { get; set; }

        [JsonProperty("Disposal_type")]
        public string Disposal_type { get; set; }

        [JsonProperty("Church_Service")]
        public string Church_Service { get; set; }

        [JsonProperty("Crematorium_Cemetery_Service")]
        public string Crematorium_Cemetery_Service { get; set; }

        [JsonProperty("Church")]
        public string Church { get; set; }

        [JsonProperty("Crematorium")]
        public string Crematorium { get; set; }

        [JsonProperty("Disposal_ashes")]
        public string Disposal_ashes { get; set; }

        [JsonProperty("Urn_type")]
        public string Urn_type { get; set; }

        [JsonProperty("Cemetery")]
        public string Cemetery { get; set; }

        [JsonProperty("Grave_Certificate_Number")]
        public string Grave_Certificate_Number { get; set; }

        [JsonProperty("Grave_Class")]
        public string Grave_Class { get; set; }

        [JsonProperty("Lair_No")]
        public string Lair_No { get; set; }

        [JsonProperty("Grave_Section")]
        public string Grave_Section { get; set; }

        [JsonProperty("Memorial_type")]
        public string Memorial_type { get; set; }

        [JsonProperty("Additional_Info")]
        public string Additional_Info { get; set; }

        [JsonProperty("Date_signed")]
        public DateTime? Date_signed { get; set; }

        [JsonProperty("Fulfilment_Pref")]
        public string Fulfilment_Pref { get; set; }

        [JsonProperty("Payment_Scheme_Code")]
        public string Payment_Scheme_Code { get; set; }

        [JsonProperty("Payment_Method_Code")]
        public string Payment_Method_Code { get; set; }

        [JsonProperty("Chq_Amount")]
        public decimal? Chq_Amount { get; set; }

        [JsonProperty("Total_Instalments_No")]
        public int? Total_Instalments_No { get; set; }

        [JsonProperty("Monthly_Payment")]
        public decimal? Monthly_Payment { get; set; }

        [JsonProperty("Deposit")]
        public decimal? Deposit { get; set; }

        [JsonProperty("Bank_Sort_Code")]
        public string Bank_Sort_Code { get; set; }

        [JsonProperty("Bank_Account_No")]
        public string Bank_Account_No { get; set; }

        [JsonProperty("Bank_Account_Name")]
        public string Bank_Account_Name { get; set; }

        [JsonProperty("Policy_Provider_No")]
        public int? Policy_Provider_No { get; set; }

        [JsonProperty("Application_Date")]
        public DateTime? Application_Date { get; set; }

        [JsonProperty("Application_Ref")]
        public string Application_Ref { get; set; }

        [JsonProperty("Plan_Brand_Name")]
        public string Plan_Brand_Name { get; set; }

        [JsonProperty("Funeral_Director_Name")]
        public string Funeral_Director_Name { get; set; }

        [JsonProperty("Funeral_Director_Address")]
        public string Funeral_Director_Address { get; set; }

        [JsonProperty("FD_Date_Signed")]
        public DateTime? FD_Date_Signed { get; set; }

        [JsonProperty("Plan_Type_Name")]
        public string Plan_Type_Name { get; set; }

        [JsonProperty("Discount")]
        public decimal? Discount { get; set; }

        [JsonProperty("SR_Options_Total")]
        public decimal? SR_Options_Total { get; set; }

        [JsonProperty("Plan_Type_Base_Cost")]
        public decimal? Plan_Type_Base_Cost { get; set; }

        [JsonProperty("Marketing_Consent")]
        public string Marketing_Consent { get; set; }

        [JsonProperty("Marketing_Phone_Consent")]
        public string Marketing_Phone_Consent { get; set; }

        [JsonProperty("Marketing_Mail_Consent")]
        public string Marketing_Mail_Consent { get; set; }

        [JsonProperty("Marketing_Email_Consent")]
        public string Marketing_Email_Consent { get; set; }

        [JsonProperty("Marketing_Text_Consent")]
        public string Marketing_Text_Consent { get; set; }

        [JsonProperty("Full_Name")]
        public string Full_Name { get; set; }

        [JsonProperty("Instalment_Charge")]
        public decimal? Instanlment_Charge { get; set; }

        [JsonProperty("INIT_Payment_Method_Code")]
        public string INIT_Payment_Method_Code { get; set; }

        [JsonProperty("EPDQ_Merchant_Id")]
        public string EPDQ_Merchant_Id { get; set; }

        [JsonProperty("EPDQ_Id")]
        public string EPDQ_Id { get; set; }

        [JsonProperty("ZVA_Token")]
        public string ZVA_Token { get; set; }

        [JsonProperty("Seller_Id")]
        public int? Seller_Id { get; set; }

        [JsonProperty("Plan_Version_Number")]
        public int? Plan_Version_Number { get; set; }

        [JsonProperty("Plan_Type")]
        public string Plan_Type { get; set; }

        [JsonProperty("PH_Declaration_Signature")]
        public string PH_Declaration_Signature { get; set; }

        [JsonProperty("FD_Declaration_Signature")]
        public string FD_Declaration_Signature { get; set; }

        [JsonProperty("Application_Status")]
        public string Application_Status { get; set; }

        [JsonProperty("Total_Plan_Cost")]
        public decimal? Total_Plan_Cost { get; set; }

        [JsonProperty("RBL_Donation")]
        public string RBL_Donation { get; set; }

        [JsonProperty("NOK_House_No")]
        public string NOK_House_No { get; set; }

        [JsonProperty("REP_House_No")]
        public string REP_House_No { get; set; }

        [JsonProperty("OOH_Charge")]
        public string OOH_Charge { get; set; }

        [JsonProperty("Branch_Num")]
        public int? Branch_Num { get; set; }

        [JsonProperty("UK_Account_Holder")]
        public string UK_Account_Holder { get; set; }

        [JsonProperty("Only_Debit_Authoriser")]
        public string Only_Debit_Authoriser { get; set; }

        [JsonProperty("Payee")]
        public string Payee { get; set; }

        [JsonProperty("Gateway_Reference")]
        public string Gateway_Reference { get; set; }

        [JsonProperty("Payment_Invoice_Id")]
        public string Payment_Invoice_Id { get; set; }      
    }
}
