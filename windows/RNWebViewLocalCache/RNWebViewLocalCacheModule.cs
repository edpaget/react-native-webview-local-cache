using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNWebViewLocalCache
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNWebViewLocalCacheModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNWebViewLocalCacheModule"/>.
        /// </summary>
        internal RNWebViewLocalCacheModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNWebViewLocalCache";
            }
        }
    }
}
