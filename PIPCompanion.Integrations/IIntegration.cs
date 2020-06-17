using System;
using System.Collections.Generic;
using System.Text;

namespace PIPCompanion.Integrations
{
    /// <summary>
    /// Interface for integrations to work
    /// </summary>
    interface IIntegration
    {
        /// <summary>
        /// Method used to clear the main area and place whatever the integration needs to work
        /// </summary>
        public void Setup(IIntegrationConfiguration configuration);

        /// <summary>
        /// Code used to play, if applicable
        /// </summary>
        public void Play();

        /// <summary>
        /// Code used to stop, if applicable
        /// </summary>
        public void Stop();

        /// <summary>
        /// Configuration set for the integration
        /// </summary>
        public IIntegrationConfiguration Configuration { get; set; }
    }
}
