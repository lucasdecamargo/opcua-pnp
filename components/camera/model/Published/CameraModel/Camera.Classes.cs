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

namespace Camera
{
    #region PhotoSkillState Class
    #if (!OPCUA_EXCLUDE_PhotoSkillState)
    /// <summary>
    /// Stores an instance of the PhotoSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PhotoSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PhotoSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.PhotoSkillType, Camera.Namespaces.Camera, namespaceUris);
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
           "BAAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlLxwAAABodHRwczovL3BucC5v" +
           "cmcvVUEvUG5QVHlwZXMv/////4RggAIBAAAAAQAWAAAAUGhvdG9Ta2lsbFR5cGVJbnN0YW5jZQEBmToB" +
           "AZk6mToAAAH/////DAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGaOgAvAQDICpo6AAAAFf//" +
           "//8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBmzoALgBEmzoAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABgAAAE51bWJlcgEBnToALgBEnToAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExh" +
           "c3RUcmFuc2l0aW9uAQGfOgAvAQDPCp86AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "oDoALgBEoDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBojoALgBEojoAAAAH" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQGjOgAuAESjOgAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAag6AC4ARKg6AAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQGpOgAuAESpOgAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAMAAAAUmVjeWNsZUNvdW50AQGqOgAuAESqOgAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAATWF4SW5zdGFuY2VDb3VudAEBrDoALgBErDoAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAA" +
           "AFN0YXJ0AQHWOgAvAQB6CdY6AAABAQEAAAAANQEBAcY6AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEB" +
           "1zoALwEAewnXOgAAAQEBAAAAADUBAQHMOgAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEB2DoALwEAfAnY" +
           "OgAAAQEBAAAAADUBAQHOOgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAdk6AC8BAH0J2ToAAAEBAwAAAAA1" +
           "AQEByDoANQEBAdA6ADUBAQHUOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQHaOgAvAQB+Cdo6AAABAQEA" +
           "AAAANQEBAcQ6AAAAAARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHcOgAvADrcOgAA/////wAAAAA=";
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

    #region CameraDeviceState Class
    #if (!OPCUA_EXCLUDE_CameraDeviceState)
    /// <summary>
    /// Stores an instance of the CameraDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CameraDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CameraDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Camera.ObjectTypes.CameraDeviceType, Camera.Namespaces.Camera, namespaceUris);
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
           "BAAAABoAAABodHRwczovL3BucC5vcmcvVUEvQ2FtZXJhLx8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5vcmcvVUEvRGV2aWNlLxwAAABodHRwczovL3BucC5v" +
           "cmcvVUEvUG5QVHlwZXMv/////wRggAIBAAAAAQAYAAAAQ2FtZXJhRGV2aWNlVHlwZUluc3RhbmNlAQHd" +
           "OgEB3TrdOgAA/////wgAAAA1YIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEB9DoDAAAAADAAAABOYW1l" +
           "IG9mIHRoZSBjb21wYW55IHRoYXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBE9DoAAAAV/////wEB" +
           "/////wAAAAA1YIkKAgAAAAIABQAAAE1vZGVsAQH2OgMAAAAAGAAAAE1vZGVsIG5hbWUgb2YgdGhlIGRl" +
           "dmljZQAuAET2OgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEB" +
           "9zoDAAAAACwAAABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgdGhlIGRldmljZQAuAET3" +
           "OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEB+DoDAAAAADUA" +
           "AABSZXZpc2lvbiBsZXZlbCBvZiB0aGUgc29mdHdhcmUvZmlybXdhcmUgb2YgdGhlIGRldmljZQAuAET4" +
           "OgAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAfk6AwAAAAAkAAAA" +
           "T3ZlcmFsbCByZXZpc2lvbiBsZXZlbCBvZiB0aGUgZGV2aWNlAC4ARPk6AAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwBAfs6AwAAAABaAAAAQWRkcmVzcyAocGF0aG5hbWUgaW4g" +
           "dGhlIGZpbGUgc3lzdGVtIG9yIGEgVVJMIHwgV2ViIGFkZHJlc3MpIG9mIHVzZXIgbWFudWFsIGZvciB0" +
           "aGUgZGV2aWNlAC4ARPs6AAAADP////8BAf////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIB" +
           "Af06AwAAAABNAAAASWRlbnRpZmllciB0aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1h" +
           "bnVmYWN0dXJlciwgYSBkZXZpY2UgaW5zdGFuY2UALgBE/ToAAAAM/////wEB/////wAAAAA1YIkKAgAA" +
           "AAIADwAAAFJldmlzaW9uQ291bnRlcgEB/zoDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGlu" +
           "ZGljYXRpbmcgdGhlIG51bWJlciBvZiB0aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZp" +
           "Y2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE/zoAAAAG/////wEB/////wAAAAA=";
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