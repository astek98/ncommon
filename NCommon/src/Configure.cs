#region license
//Copyright 2010 Ritesh Rao 

//Licensed under the Apache License, Version 2.0 (the "License"); 
//you may not use this file except in compliance with the License. 
//You may obtain a copy of the License at 

//http://www.apache.org/licenses/LICENSE-2.0 

//Unless required by applicable law or agreed to in writing, software 
//distributed under the License is distributed on an "AS IS" BASIS, 
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
//See the License for the specific language governing permissions and 
//limitations under the License. 
#endregion

using System;
using NCommon.Configuration;

namespace NCommon
{
    /// <summary>
    /// Static configuration class that allows configuration of NCommon services.
    /// </summary>
    public static class Configure
    {
        /// <summary>
        /// Entry point to NCommon configuration.
        /// </summary>
        /// <param name="containerAdapter">The <see cref="IContainerAdapter"/> instance to use
        /// for component registration.</param>
        /// <returns>An instance of <see cref="INCommonConfig"/> that can be used to configure
        /// NCommon configuration.</returns> 
        public static INCommonConfig Using(IContainerAdapter containerAdapter)
        {
            Guard.Against<ArgumentNullException>(containerAdapter == null,
                                                 "Expected a non-null IContainerAdapter implementation.");
            return new NCommonConfig(containerAdapter);
        }
    }
}