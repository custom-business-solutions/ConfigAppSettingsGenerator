//-----------------------------------------------------------------------
// <copyright file="ConfigAppSettings.cs" company="Some Company">
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
    public partial class ConfigAppSettings : IConfigAppSettings
    {
        /// <summary>
        /// Gets the value of the 'SomeSecretStringKey' appSetting.
        /// </summary>
        /// <value>
        /// 'SomeSecretStringKey' value.
        /// </value>
        public virtual string SomeSecretStringKey
        {
            get
            {
                string configKeyString = this.GetConfigSetting("SomeSecretStringKey");
                return Convert.ToString(configKeyString);
            }
        }
        
        /// <summary>
        /// Gets the value of the 'ColonsAre:NoProblem' appSetting.
        /// </summary>
        /// <value>
        /// 'ColonsAre:NoProblem' value.
        /// </value>
        public virtual string ColonsAreNoProblem
        {
            get
            {
                string configKeyString = this.GetConfigSetting("ColonsAre:NoProblem");
                return Convert.ToString(configKeyString);
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the appSetting 'BooleanSettingsAreGoodToo' is true or false.
        /// </summary>
        /// <value>
        ///   <c>true</c> if 'BooleanSettingsAreGoodToo' value is true; otherwise, <c>false</c>.
        /// </value>
        public virtual bool BooleanSettingsAreGoodToo
        {
            get
            {
                string configKeyString = this.GetConfigSetting("BooleanSettingsAreGoodToo");
                return Convert.ToBoolean(configKeyString);
            }
        }
        
        /// <summary>
        /// Gets the value of the 'LetsHaveSomeNumbers' appSetting.
        /// </summary>
        /// <value>
        /// 'LetsHaveSomeNumbers' value.
        /// </value>
        public virtual int LetsHaveSomeNumbers
        {
            get
            {
                string configKeyString = this.GetConfigSetting("LetsHaveSomeNumbers");
                return Convert.ToInt32(configKeyString);
            }
        }
        
        /// <summary>
        /// Gets the value of the 'AndHeresADouble' appSetting.
        /// </summary>
        /// <value>
        /// 'AndHeresADouble' value.
        /// </value>
        public virtual double AndHeresADouble
        {
            get
            {
                string configKeyString = this.GetConfigSetting("AndHeresADouble");
                return Convert.ToDouble(configKeyString);
            }
        }
        
        /// <summary>
        /// Gets the configuration setting.
        /// </summary>
        /// <param name="settingName">Name of the setting.</param>
        /// <returns>The string value of the appSetting</returns>
        /// <exception cref="ConfigurationException">
        /// Invalid configuration setting:  + settingName
        /// or
        /// Invalid configuration setting:  + settingName
        /// or
        /// Invalid configuration. Required AppSettings section is missing.
        /// </exception>
        public virtual NameValueCollection AppSettings
        {
            get
            {
                return ConfigurationManager.AppSettings;
            }
        }
        
        /// <summary>
        /// Gets the configuration setting.
        /// </summary>
        /// <param name="settingName">Name of the setting.</param>
        /// <returns>The string value of the appSetting</returns>
        /// <exception cref="ConfigurationException">
        /// Invalid configuration setting:  + settingName
        /// or
        /// Invalid configuration setting:  + settingName
        /// or
        /// Invalid configuration. Required AppSettings section is missing.
        /// </exception>
        private string GetConfigSetting(string settingName)
        {
            if ((ConfigurationManager.AppSettings != null) && (ConfigurationManager.AppSettings.Count != 0))
            {
                try
                {
                    var value = ConfigurationManager.AppSettings.Get(settingName);
                    if (value == null)
                    {
                        throw new ConfigurationErrorsException("Invalid configuration setting: " + settingName);
                    }

                    return value;
                }
                catch
                {
                    throw new ConfigurationErrorsException("Invalid configuration setting: " + settingName);
                }
            }
            else
            {
                throw new ConfigurationErrorsException("Invalid configuration. Required AppSettings section is missing.");
            }
        }
    }
    
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

    }
}