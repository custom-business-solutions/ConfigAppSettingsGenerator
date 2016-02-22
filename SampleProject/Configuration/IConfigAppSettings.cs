//-----------------------------------------------------------------------
// <copyright file="IConfigAppSettings.cs" company="Some Company">
//  Copyright (c) 2016 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace YourProject.NameSpace.Configuration
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
    
    /// <summary>
    /// Provides staticly-typed access to the appSettings values.
    /// This class is dynamically created.  Do not modify directly.
    /// </summary>
    public interface IConfigAppSettings
    {
        /// <summary>
        /// Gets the value of the 'SomeSecretStringKey' appSetting.
        /// </summary>
        /// <value>
        /// 'SomeSecretStringKey' value.
        /// </value>
        string SomeSecretStringKey
        {
            get;
        }

        /// <summary>
        /// Gets the value of the 'ColonsAre:NoProblem' appSetting.
        /// </summary>
        /// <value>
        /// 'ColonsAre:NoProblem' value.
        /// </value>
        string ColonsAreNoProblem
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether the appSetting 'BooleanSettingsAreGoodToo' is true or false.
        /// </summary>
        /// <value>
        ///   <c>true</c> if 'BooleanSettingsAreGoodToo' value is true; otherwise, <c>false</c>.
        /// </value>
        bool BooleanSettingsAreGoodToo
        {
            get;
        }

        /// <summary>
        /// Gets the value of the 'LetsHaveSomeNumbers' appSetting.
        /// </summary>
        /// <value>
        /// 'LetsHaveSomeNumbers' value.
        /// </value>
        int LetsHaveSomeNumbers
        {
            get;
        }

        /// <summary>
        /// Gets the value of the 'AndHeresADouble' appSetting.
        /// </summary>
        /// <value>
        /// 'AndHeresADouble' value.
        /// </value>
        double AndHeresADouble
        {
            get;
        }

        /// <summary>
        /// Gets the configuration setting.
        /// </summary>
        /// <param name="settingName">Name of the setting.</param>
        /// <returns>The string value of the appSetting</returns>
        /// <exception cref="ConfigurationException">
        /// Invalid configuration setting:  + settingName
        /// Invalid configuration. Required AppSettings section is missing.
        /// </exception>
        NameValueCollection AppSettings
        {
            get;
        }
    }
}
