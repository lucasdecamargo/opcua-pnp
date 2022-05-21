/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;
using fortiss_Device;
using PnPTypes;

namespace ImageProcessor
{
    #region MarkerDetectionSkillState Class
    #if (!OPCUA_EXCLUDE_MarkerDetectionSkillState)
    /// <summary>
    /// Stores an instance of the MarkerDetectionSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MarkerDetectionSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MarkerDetectionSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ImageProcessor.ObjectTypes.MarkerDetectionSkillType, ImageProcessor.Namespaces.ImageProcessor, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "BAAAACIAAABodHRwczovL3BucC5vcmcvVUEvSW1hZ2VQcm9jZXNzb3IvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8eAAAAaHR0cHM6Ly9mb3J0aXNzLm9yZy9VQS9EZXZpY2UvHAAAAGh0dHBz" +
           "Oi8vcG5wLm9yZy9VQS9QblBUeXBlcy//////hGCAAgEAAAABACAAAABNYXJrZXJEZXRlY3Rpb25Ta2ls" +
           "bFR5cGVJbnN0YW5jZQEBmToBAZk6mToAAAH/////DAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRl" +
           "AQGaOgAvAQDICpo6AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBmzoALgBEmzoAAAAR" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBnToALgBEnToAAAAH/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQGfOgAvAQDPCp86AAAAFf////8BAf////8DAAAA" +
           "FWCJCgIAAAAAAAIAAABJZAEBoDoALgBEoDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51" +
           "bWJlcgEBojoALgBEojoAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1l" +
           "AQGjOgAuAESjOgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAag6AC4A" +
           "RKg6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQGpOgAuAESpOgAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQGqOgAuAESqOgAAAAb/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBrDoALgBErDoAAAAH/////wEB////" +
           "/wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQHWOgAvAQB6CdY6AAABAQEAAAAANQEBAcY6AAAAAARhggoE" +
           "AAAAAAAHAAAAU3VzcGVuZAEB1zoALwEAewnXOgAAAQEBAAAAADUBAQHMOgAAAAAEYYIKBAAAAAAABgAA" +
           "AFJlc3VtZQEB2DoALwEAfAnYOgAAAQEBAAAAADUBAQHOOgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAdk6" +
           "AC8BAH0J2ToAAAEBAwAAAAA1AQEByDoANQEBAdA6ADUBAQHUOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0" +
           "AQHaOgAvAQB+Cdo6AAABAQEAAAAANQEBAcQ6AAAAAARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHc" +
           "OgAvADrcOgAA/////wQAAAA1YIkKAgAAAAEACgAAAENhbWVyYUluZm8BAd06AwAAAABNAAAARGlzdG9y" +
           "dGlvbiBjb2VmZmljaWVudHMgYW5kIG1hdHJpeCBvZiB0aGUgY2FtZXJhIHVzZWQgdG8gdGFrZSB0aGUg" +
           "aW1hZ2UgcGhvdG8ALwA/3ToAAAEEzTr/////AwP/////AAAAADVgiQoCAAAAAQAKAAAASW5wdXRJbWFn" +
           "ZQEB3joDAAAAADQAAABDb250YWlucyB0aGUgZGF0YSBvZiB0aGUgaW5wdXQgaW1hZ2UgdG8gYmUgcHJv" +
           "Y2Vzc2VkAC8AP946AAAAD/////8DA/////8AAAAANWCJCgIAAAABAAsAAABPdXRwdXRJbWFnZQEB3zoD" +
           "AAAAADgAAABDb250YWlucyB0aGUgZGF0YSBvZiB0aGUgb3V0cHV0IGltYWdlIHdpdGggZHJhd24gbWFy" +
           "a2VycwAvAD/fOgAAAQDTB/////8BAf////8AAAAAN2CJCgIAAAABABQAAABEZXRlY3RlZE1hcmtlcnNB" +
           "cnJheQEB4DoDAAAAACIAAABBcnJheSBvZiBkZXRlY3RlZCBmaWR1Y2lhbCBtYXJrZXJzAC8AP+A6AAAB" +
           "BJk6AQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ParameterSet
        {
            get
            {
                return m_parameterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Di.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        #endregion
    }
    #endif
    #endregion

    #region ImageProcessorDeviceState Class
    #if (!OPCUA_EXCLUDE_ImageProcessorDeviceState)
    /// <summary>
    /// Stores an instance of the ImageProcessorDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ImageProcessorDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ImageProcessorDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ImageProcessor.ObjectTypes.ImageProcessorDeviceType, ImageProcessor.Namespaces.ImageProcessor, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "BAAAACIAAABodHRwczovL3BucC5vcmcvVUEvSW1hZ2VQcm9jZXNzb3IvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8eAAAAaHR0cHM6Ly9mb3J0aXNzLm9yZy9VQS9EZXZpY2UvHAAAAGh0dHBz" +
           "Oi8vcG5wLm9yZy9VQS9QblBUeXBlcy//////BGCAAgEAAAABACAAAABJbWFnZVByb2Nlc3NvckRldmlj" +
           "ZVR5cGVJbnN0YW5jZQEB4ToBAeE64ToAAP////8IAAAANWCJCgIAAAACAAwAAABNYW51ZmFjdHVyZXIB" +
           "Afg6AwAAAAAwAAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNl" +
           "AC4ARPg6AAAAFf////8BAf////8AAAAANWCJCgIAAAACAAUAAABNb2RlbAEB+joDAAAAABgAAABNb2Rl" +
           "bCBuYW1lIG9mIHRoZSBkZXZpY2UALgBE+joAAAAV/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAEhh" +
           "cmR3YXJlUmV2aXNpb24BAfs6AwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9m" +
           "IHRoZSBkZXZpY2UALgBE+zoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIAEAAAAFNvZnR3YXJlUmV2" +
           "aXNpb24BAfw6AwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9m" +
           "IHRoZSBkZXZpY2UALgBE/DoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADgAAAERldmljZVJldmlz" +
           "aW9uAQH9OgMAAAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAET9OgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQH/OgMAAAAAWgAAAEFkZHJl" +
           "c3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1" +
           "c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAuAET/OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAM" +
           "AAAAU2VyaWFsTnVtYmVyAQEBOwMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlm" +
           "aWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARAE7AAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAA8AAABSZXZpc2lvbkNvdW50ZXIBAQM7AwAAAABpAAAAQW4gaW5jcmVt" +
           "ZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRh" +
           "IHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARAM7AAAABv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}