using System;
using System.Xml;
using System.Linq;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Helpers
{
    public class RetrieveBusinessPlansOracle
    {
        private static string dataSource = Environment.GetEnvironmentVariable("oracleDataSource");
        private static string dbCredentials = Environment.GetEnvironmentVariable("oracledbCredentials");
        private static string connectionString = Environment.GetEnvironmentVariable("connectionString");
        private static string storedProcName = Environment.GetEnvironmentVariable("anubisStoredProc");


        public Models.Result<string> GetAnubisBusinessPlans(ILogger log)
        {
            log.LogInformation("Initiated GetAnubisApplications...");

            Models.Result<string> result = new Models.Result<string>();

            if (string.IsNullOrEmpty(OracleConfiguration.OracleDataSources[dataSource]))
            {
                OracleConfiguration.OracleDataSources.Add(dataSource, connectionString);
            }

            log.LogInformation("Configured OracleDataSources...");

            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = new OracleParameter("retval", OracleDbType.XmlType, 4000);
            parameters[0].Direction = ParameterDirection.ReturnValue;
            parameters[1] = new OracleParameter("@p_ho_num", OracleDbType.Int32, 8);
            parameters[1].Value = 300420;           

            log.LogInformation("Configured OracleParameters...");

            using (OracleConnection conn = new OracleConnection(dbCredentials))
            {             
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandText = storedProcName,
                    CommandType = CommandType.StoredProcedure

                };

                log.LogInformation("Configured OracleCommand...");

                foreach (OracleParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }

                log.LogInformation("Added parameters...");

                try
                {
                    conn.Open();
                    log.LogInformation("Opened database connection...");
                    command.ExecuteNonQuery();
                    log.LogInformation("Executed stored procedure...");

                    if (((OracleXmlType)command.Parameters["retval"].Value).IsNull)
                    {
                        // Set the quote error response
                        result = SetQuoteErrorResponse("900", log);
                        conn.Close();
                        conn.Dispose();
                        return result;
                    }

                    string returnString = Convert.ToString(((OracleXmlType)command.Parameters["retval"].Value).Value);

                    /*
                    // To convert an XML node contained in string xml into a JSON string   
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(returnString);

                    List<Models.ApplicationsResult> ApplicationResult = new List<Models.ApplicationsResult>();

                    //With the Json string create the JSON and then turn it into our object
                    for (var x = 1; x < doc.ChildNodes.Item(1).ChildNodes.Count; x++)
                    {
                        string jsonResult = JsonConvert.SerializeXmlNode(doc.ChildNodes.Item(1).ChildNodes.Item(x), Newtonsoft.Json.Formatting.None, true);
                        jsonResult = jsonResult.Replace("\r\n", "");
                        jsonResult = jsonResult.Replace("{\"@xsi:nil\":\"true\"}", "null");
                       
                        ApplicationResult.Add(JsonConvert.DeserializeObject<Models.ApplicationsResult>(jsonResult));                   
                    }

                    log.LogInformation("This many applications found and processed: " + doc.ChildNodes.Item(1).ChildNodes.Count.ToString());

                    //Build result object
                    result.Code = 0;
                    result.Msg = doc.ChildNodes.Item(1).ChildNodes.Count.ToString() + " applications found and processed";

                    //Sorting Order
                    if(varibles.sortingColumn != null)
                    {
                        log.LogInformation("Sorted by " + varibles.sortingColumn);
                        ApplicationResult = doSorting(ApplicationResult, varibles.sortingColumn);
                    }
                    else
                    {
                        log.LogInformation("Sorted by Application_Ref");
                        ApplicationResult = doSorting(ApplicationResult, "Application_Ref");
                    }


                    //Pagination
                    if(varibles.PageNum != null)
                    {
                        //if not there then default to 20
                        if(varibles.PageSize == null)
                        {
                            varibles.PageSize = 20;
                        }

                        //only deal with postive values
                        if(varibles.PageNum < 0)
                        {
                            result.Code = 301;
                            result.Msg = "An unexpected error occurred in Pagination: PageNum was less than 0";
                            return result;
                        }

                        //try and catch for out of bounds expections
                        try 
                        { 
                            ApplicationResult = ApplicationResult.GetRange(((int)varibles.PageNum - 1) * (int)varibles.PageSize, (int)varibles.PageSize); 
                        }
                        catch(Exception ex)
                        {
                            result.Code = 301;
                            result.Msg = "An unexpected error occurred in Pagination: " + ex.ToString();
                            return result;
                        }                        
                    }
                   
                    log.LogInformation("Returning " + ApplicationResult.Count + " Records");

                    //Return correct type still sorted 
                    if (varibles.JsonOrXML.ToUpper().Equals("JSON"))
                    {
                        result.Data = JsonConvert.SerializeObject(ApplicationResult);                    
                    }
                    else if(varibles.JsonOrXML.ToUpper().Equals("XML"))
                    {
                        result.Data = JsonConvert.SerializeObject(ApplicationResult);
                        XmlDocument doc2 = JsonConvert.DeserializeXmlNode("{\"" + "Applications" + "\":" + result.Data + "}", "DocumentElement");
                        result.Data = doc2.OuterXml;    
                    }
                    */
                    result.Data = returnString;

                    conn.Close();
                    conn.Dispose();
                    return result;
                }
                catch (Exception ex)
                {
                    log.LogError("Exception raised: " + ex.ToString());
                    conn.Close();
                    conn.Dispose();
                    result.Code = 900;
                    result.Msg = "An unexpected error occurred: " + ex.ToString();
                    return result;
                }
            }
        }

        public List<Models.ApplicationsResult> doSorting(List<Models.ApplicationsResult> list, string sortingColumn)
        {
            //get ordered list
            var temp = typeof(Models.ApplicationsResult).GetProperty(sortingColumn);
            var orderByDynamics = list.OrderBy(x => temp.GetValue(x, null));

            var tempJson = JsonConvert.SerializeObject(orderByDynamics);

            list = JsonConvert.DeserializeObject<List<Models.ApplicationsResult>>(tempJson);

            return list;
        }

        public Models.Result<string> SetQuoteErrorResponse(string errorResponse, ILogger log)
        {
            Models.Result<string> quoteErrorResponse = new Models.Result<string>();

            // Remove the ERR: prefix from the errorResponse
            string parseErrorResponse = errorResponse.Substring(errorResponse.IndexOf(":") + 1);

            // Set the error codes and responses based on the error message returned
            // Not an ideal process but it is all we have based on Anubis function return value
            switch (parseErrorResponse)
            {              
                // Any other response returned from the Anubis stored procedure
                default:
                    quoteErrorResponse.Code = 900;
                    quoteErrorResponse.Msg = "Unexpected error returned from Quote Engine: " + parseErrorResponse;
                    return quoteErrorResponse;
            }
        }
    }
}
