#region Copyright

// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2018
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//

#endregion


namespace DotNetNuke.Modules.Reports.Extensions
{
    using System.Collections.Generic;

    /// -----------------------------------------------------------------------------
    /// <summary>
    ///     The IReportsSettingsControl class provides an interface to a Reports Module Settings Control
    /// </summary>
    /// <history>
    ///     [anurse]     08/02/2007    Created
    /// </history>
    /// -----------------------------------------------------------------------------
    public interface IReportsSettingsControl : IReportsControl
    {
        /// -----------------------------------------------------------------------------
        /// <summary>
        ///     Loads settings from the specified settings dictionary into the
        ///     settings UI
        /// </summary>
        /// <param name="Settings">The settings dictionary to load into the UI</param>
        /// <history>
        ///     [anurse]     08/02/2007    Created
        /// </history>
        /// -----------------------------------------------------------------------------
        void LoadSettings(Dictionary<string, string> Settings);

        /// -----------------------------------------------------------------------------
        /// <summary>
        ///     Save settings to the specified settings dictionary from the
        ///     settings UI
        /// </summary>
        /// <param name="Settings">The settings dictionary to save from the UI</param>
        /// <history>
        ///     [anurse]     08/02/2007    Created
        /// </history>
        /// -----------------------------------------------------------------------------
        void SaveSettings(Dictionary<string, string> Settings);
    }
}