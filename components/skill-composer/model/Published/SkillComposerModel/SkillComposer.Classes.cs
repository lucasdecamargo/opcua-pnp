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

namespace SkillComposer
{
    #region MarkerFindingSkillState Class
    #if (!OPCUA_EXCLUDE_MarkerFindingSkillState)
    /// <summary>
    /// Stores an instance of the MarkerFindingSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MarkerFindingSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MarkerFindingSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(SkillComposer.ObjectTypes.MarkerFindingSkillType, SkillComposer.Namespaces.SkillComposer, namespaceUris);
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
           "BAAAACEAAABodHRwczovL3BucC5vcmcvVUEvU2tpbGxDb21wb3Nlci8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLx4AAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0RldmljZS8cAAAAaHR0cHM6" +
           "Ly9wbnAub3JnL1VBL1BuUFR5cGVzL/////+EYIACAQAAAAEAHgAAAE1hcmtlckZpbmRpbmdTa2lsbFR5" +
           "cGVJbnN0YW5jZQEBmToBAZk6mToAAAH/////DAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQGa" +
           "OgAvAQDICpo6AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEBmzoALgBEmzoAAAAR////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgEBnToALgBEnToAAAAH/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADgAAAExhc3RUcmFuc2l0aW9uAQGfOgAvAQDPCp86AAAAFf////8BAf////8DAAAAFWCJ" +
           "CgIAAAAAAAIAAABJZAEBoDoALgBEoDoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJl" +
           "cgEBojoALgBEojoAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQGj" +
           "OgAuAESjOgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAag6AC4ARKg6" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQGpOgAuAESpOgAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAMAAAAUmVjeWNsZUNvdW50AQGqOgAuAESqOgAAAAb/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAQAAAATWF4SW5zdGFuY2VDb3VudAEBrDoALgBErDoAAAAH/////wEB/////wAA" +
           "AAAEYYIKBAAAAAAABQAAAFN0YXJ0AQHWOgAvAQB6CdY6AAABAQEAAAAANQEBAcY6AAAAAARhggoEAAAA" +
           "AAAHAAAAU3VzcGVuZAEB1zoALwEAewnXOgAAAQEBAAAAADUBAQHMOgAAAAAEYYIKBAAAAAAABgAAAFJl" +
           "c3VtZQEB2DoALwEAfAnYOgAAAQEBAAAAADUBAQHOOgAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAdk6AC8B" +
           "AH0J2ToAAAEBAwAAAAA1AQEByDoANQEBAdA6ADUBAQHUOgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQHa" +
           "OgAvAQB+Cdo6AAABAQEAAAAANQEBAcQ6AAAAAARggAoBAAAAAgAMAAAAUGFyYW1ldGVyU2V0AQHcOgAv" +
           "ADrcOgAA/////wEAAAA3YIkKAgAAAAEAEQAAAEZvdW5kTWFya2Vyc0FycmF5AQHdOgMAAAAAHwAAAEFy" +
           "cmF5IG9mIGZvdW5kIGZpZHVjaWFsIG1hcmtlcnMALwA/3ToAAAEEmToBAAAAAQAAAAAAAAABAf////8A" +
           "AAAA";
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

    #region SkillComposerDeviceState Class
    #if (!OPCUA_EXCLUDE_SkillComposerDeviceState)
    /// <summary>
    /// Stores an instance of the SkillComposerDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillComposerDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillComposerDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(SkillComposer.ObjectTypes.SkillComposerDeviceType, SkillComposer.Namespaces.SkillComposer, namespaceUris);
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
           "BAAAACEAAABodHRwczovL3BucC5vcmcvVUEvU2tpbGxDb21wb3Nlci8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJLx4AAABodHRwczovL2ZvcnRpc3Mub3JnL1VBL0RldmljZS8cAAAAaHR0cHM6" +
           "Ly9wbnAub3JnL1VBL1BuUFR5cGVzL/////8EYIACAQAAAAEAHwAAAFNraWxsQ29tcG9zZXJEZXZpY2VU" +
           "eXBlSW5zdGFuY2UBAd46AQHeOt46AAD/////CAAAADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQH1" +
           "OgMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkgdGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAu" +
           "AET1OgAAABX/////AQH/////AAAAADVgiQoCAAAAAgAFAAAATW9kZWwBAfc6AwAAAAAYAAAATW9kZWwg" +
           "bmFtZSBvZiB0aGUgZGV2aWNlAC4ARPc6AAAAFf////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJk" +
           "d2FyZVJldmlzaW9uAQH4OgMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARPg6AAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlz" +
           "aW9uAQH5OgMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARPk6AAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lv" +
           "bgEB+joDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBE+joAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEB/DoDAAAAAFoAAABBZGRyZXNz" +
           "IChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNl" +
           "ciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBE/DoAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAA" +
           "AFNlcmlhbE51bWJlcgEB/joDAAAAAE0AAABJZGVudGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmll" +
           "cywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRldmljZSBpbnN0YW5jZQAuAET+OgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQEAOwMAAAAAaQAAAEFuIGluY3JlbWVu" +
           "dGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVtYmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3" +
           "aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2RpZmllZAAuAEQAOwAAAAb/////AQH/////AAAAAA==";
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