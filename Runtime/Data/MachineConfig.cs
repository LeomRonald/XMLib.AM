/*
 * 作者：Peter Xiang
 * 联系方式：565067150@qq.com
 * 文档: https://github.com/PxGame
 * 创建时间: 2019/10/29 14:14:00
 */

using System;
using System.Collections.Generic;
using UnityEngine;

namespace XMLib.AM
{
    /// <summary>
    /// MachineConfig
    /// </summary>
    [Serializable]
    public class MachineConfig
    {
        public string firstStateName;
        public List<StateConfig> states = new List<StateConfig>();

        [SerializeReference]
        public List<object> globalActions = new List<object>();
    }
}