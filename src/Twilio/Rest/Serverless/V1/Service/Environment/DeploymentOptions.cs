/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Environment 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of all Deployments.
    /// </summary>
    public class ReadDeploymentOptions : ReadOptions<DeploymentResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }

        /// <summary>
        /// Construct a new ReadDeploymentOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        public ReadDeploymentOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a specific Deployment.
    /// </summary>
    public class FetchDeploymentOptions : IOptions<DeploymentResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// Deployment Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchDeploymentOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        /// <param name="pathSid"> Deployment Sid. </param>
        public FetchDeploymentOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Create a new Deployment.
    /// </summary>
    public class CreateDeploymentOptions : IOptions<DeploymentResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Environment Sid.
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// Build Sid.
        /// </summary>
        public string BuildSid { get; }

        /// <summary>
        /// Construct a new CreateDeploymentOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathEnvironmentSid"> Environment Sid. </param>
        /// <param name="buildSid"> Build Sid. </param>
        public CreateDeploymentOptions(string pathServiceSid, string pathEnvironmentSid, string buildSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            BuildSid = buildSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (BuildSid != null)
            {
                p.Add(new KeyValuePair<string, string>("BuildSid", BuildSid.ToString()));
            }

            return p;
        }
    }

}