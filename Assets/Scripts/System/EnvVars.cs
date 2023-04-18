using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System
{
    /// <summary>
    /// 環境変数
    /// </summary>
    public partial class EnvVars
    {
        /// <summary>
        /// ChatGPTのAPIキー
        /// </summary>
        public readonly string ChatGPTKey;

        #region Singleton

        private EnvVars _instance = new EnvVars();
        public EnvVars Instance { get { return _instance; } }

        #endregion
    }
}
