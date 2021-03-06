// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create or update runbook properties.
    /// </summary>
    public partial class RunbookCreateOrUpdateProperties
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the runbook.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private int _logActivityTrace;
        
        /// <summary>
        /// Optional. Gets or sets the activity-level tracing options of the
        /// runbook.
        /// </summary>
        public int LogActivityTrace
        {
            get { return this._logActivityTrace; }
            set { this._logActivityTrace = value; }
        }
        
        private bool _logProgress;
        
        /// <summary>
        /// Optional. Gets or sets progress log option.
        /// </summary>
        public bool LogProgress
        {
            get { return this._logProgress; }
            set { this._logProgress = value; }
        }
        
        private bool _logVerbose;
        
        /// <summary>
        /// Optional. Gets or sets verbose log option.
        /// </summary>
        public bool LogVerbose
        {
            get { return this._logVerbose; }
            set { this._logVerbose = value; }
        }
        
        private ContentLink _publishContentLink;
        
        /// <summary>
        /// Required. Gets or sets the published runbook content link.
        /// </summary>
        public ContentLink PublishContentLink
        {
            get { return this._publishContentLink; }
            set { this._publishContentLink = value; }
        }
        
        private string _runbookType;
        
        /// <summary>
        /// Required. Gets or sets the type of the runbook.
        /// </summary>
        public string RunbookType
        {
            get { return this._runbookType; }
            set { this._runbookType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookCreateOrUpdateProperties
        /// class.
        /// </summary>
        public RunbookCreateOrUpdateProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookCreateOrUpdateProperties
        /// class with required arguments.
        /// </summary>
        public RunbookCreateOrUpdateProperties(string runbookType, ContentLink publishContentLink)
            : this()
        {
            if (runbookType == null)
            {
                throw new ArgumentNullException("runbookType");
            }
            if (publishContentLink == null)
            {
                throw new ArgumentNullException("publishContentLink");
            }
            this.RunbookType = runbookType;
            this.PublishContentLink = publishContentLink;
        }
    }
}
