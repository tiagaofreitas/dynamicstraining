using Logger;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Net;

namespace DynamicsConnection
{
    public class ConnectionHelper
    {
        #region Class level members
        
        private string _connectionString;
        private IOrganizationService _orgService;

        #endregion

        public ConnectionHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IOrganizationService ConnectCrm()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Log.LogInformation("Trying to connect to Dynamics 365");

            try
            {
                CrmServiceClient conn = new CrmServiceClient(_connectionString);

                _orgService = conn.OrganizationWebProxyClient ?? (IOrganizationService)conn.OrganizationServiceProxy;

                TestCrmConnection();
            }
            catch (Exception ex)
            {
                Log.LogError(ex.Message);
                throw ex;
            }

            return _orgService;
        }

        private void TestCrmConnection()
        {
            try
            {
                Guid userId = ((WhoAmIResponse)_orgService.Execute(new WhoAmIRequest())).UserId;

                if (userId == default(Guid))
                    throw new Exception("Unable to connect to Dynamics CRM.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}