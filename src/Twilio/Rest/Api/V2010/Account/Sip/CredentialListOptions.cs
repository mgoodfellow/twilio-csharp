/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Sip 
{

    /// <summary>
    /// Get All Credential Lists
    /// </summary>
    public class ReadCredentialListOptions : ReadOptions<CredentialListResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }

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
    /// Create a Credential List
    /// </summary>
    public class CreateCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Human readable descriptive text
        /// </summary>
        public string FriendlyName { get; }

        /// <summary>
        /// Construct a new CreateCredentialListOptions
        /// </summary>
        /// <param name="friendlyName"> Human readable descriptive text </param>
        public CreateCredentialListOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// Get a Credential List
    /// </summary>
    public class FetchCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique credential list Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCredentialListOptions
        /// </summary>
        /// <param name="pathSid"> Fetch by unique credential list Sid </param>
        public FetchCredentialListOptions(string pathSid)
        {
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
    /// Update a Credential List
    /// </summary>
    public class UpdateCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Update by unique credential list Sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Human readable descriptive text
        /// </summary>
        public string FriendlyName { get; }

        /// <summary>
        /// Construct a new UpdateCredentialListOptions
        /// </summary>
        /// <param name="pathSid"> Update by unique credential list Sid </param>
        /// <param name="friendlyName"> Human readable descriptive text </param>
        public UpdateCredentialListOptions(string pathSid, string friendlyName)
        {
            PathSid = pathSid;
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a Credential List
    /// </summary>
    public class DeleteCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The unique id of the Account that is responsible for this resource.
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Delete by unique credential list Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCredentialListOptions
        /// </summary>
        /// <param name="pathSid"> Delete by unique credential list Sid </param>
        public DeleteCredentialListOptions(string pathSid)
        {
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

}