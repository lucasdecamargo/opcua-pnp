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

namespace fortiss_Device
{
    #region SkillState Class
    #if (!OPCUA_EXCLUDE_SkillState)
    /// <summary>
    /// Stores an instance of the SkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillState : ProgramStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.SkillType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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

            if (FinalResultData != null)
            {
                FinalResultData.Initialize(context, FinalResultData_InitializationString);
            }
        }

        #region Initialization String
        private const string FinalResultData_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIAKAQAAAAAADwAAAEZpbmFsUmVzdWx0RGF0YQEC3DoALwA63DoAAP//" +
           "//8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAEQAAAFNraWxsVHlwZUluc3RhbmNlAQK6OgECujq6OgAA" +
           "Af////8MAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBArs6AC8BAMgKuzoAAAAV/////wEB////" +
           "/wIAAAAVYIkKAgAAAAAAAgAAAElkAQK8OgAuAES8OgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAG" +
           "AAAATnVtYmVyAQK+OgAuAES+OgAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAATGFzdFRyYW5z" +
           "aXRpb24BAsA6AC8BAM8KwDoAAAAV/////wEB/////wMAAAAVYIkKAgAAAAAAAgAAAElkAQLBOgAuAETB" +
           "OgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQLDOgAuAETDOgAAAAf/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUBAsQ6AC4ARMQ6AAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAACQAAAERlbGV0YWJsZQECyToALgBEyToAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACgAAAEF1dG9EZWxldGUBAso6AC4ARMo6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABSZWN5Y2xlQ291bnQBAss6AC4ARMs6AAAABv////8BAf////8AAAAAFWCJCgIAAAAAABAAAABNYXhJ" +
           "bnN0YW5jZUNvdW50AQLNOgAuAETNOgAAAAf/////AQH/////AAAAAARggAoBAAAAAAAPAAAARmluYWxS" +
           "ZXN1bHREYXRhAQLcOgAvADrcOgAA/////wAAAAAEYYIKBAAAAAAABQAAAFN0YXJ0AQL3OgAvAQB6Cfc6" +
           "AAABAQEAAAAANQEBAuc6AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEC+DoALwEAewn4OgAAAQEBAAAA" +
           "ADUBAQLtOgAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQEC+ToALwEAfAn5OgAAAQEBAAAAADUBAQLvOgAA" +
           "AAAEYYIKBAAAAAAABAAAAEhhbHQBAvo6AC8BAH0J+joAAAEBAwAAAAA1AQEC6ToANQEBAvE6ADUBAQL1" +
           "OgAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQL7OgAvAQB+Cfs6AAABAQEAAAAANQEBAuU6AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Halt
        {
            get
            {
                return m_haltMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_haltMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_haltMethod = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <remarks />
        public MethodState Resume
        {
            get
            {
                return m_resumeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resumeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resumeMethod = value;
            }
        }

        /// <remarks />
        public MethodState Suspend
        {
            get
            {
                return m_suspendMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendMethod = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
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
            if (m_haltMethod != null)
            {
                children.Add(m_haltMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_resumeMethod != null)
            {
                children.Add(m_resumeMethod);
            }

            if (m_suspendMethod != null)
            {
                children.Add(m_suspendMethod);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
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
                case Opc.Ua.BrowseNames.Halt:
                {
                    if (createOrReplace)
                    {
                        if (Halt == null)
                        {
                            if (replacement == null)
                            {
                                Halt = new MethodState(this);
                            }
                            else
                            {
                                Halt = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Halt;
                    break;
                }

                case Opc.Ua.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case Opc.Ua.BrowseNames.Resume:
                {
                    if (createOrReplace)
                    {
                        if (Resume == null)
                        {
                            if (replacement == null)
                            {
                                Resume = new MethodState(this);
                            }
                            else
                            {
                                Resume = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Resume;
                    break;
                }

                case Opc.Ua.BrowseNames.Suspend:
                {
                    if (createOrReplace)
                    {
                        if (Suspend == null)
                        {
                            if (replacement == null)
                            {
                                Suspend = new MethodState(this);
                            }
                            else
                            {
                                Suspend = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Suspend;
                    break;
                }

                case Opc.Ua.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
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
        private MethodState m_haltMethod;
        private MethodState m_resetMethod;
        private MethodState m_resumeMethod;
        private MethodState m_suspendMethod;
        private MethodState m_startMethod;
        #endregion
    }
    #endif
    #endregion

    #region GripperSkillState Class
    #if (!OPCUA_EXCLUDE_GripperSkillState)
    /// <summary>
    /// Stores an instance of the GripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GripperSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.GripperSkillType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAGAAAAEdyaXBwZXJTa2lsbFR5cGVJbnN0YW5jZQEC/ToB" +
           "Av06/ToAAAH/////CwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQL+OgAvAQDICv46AAAAFf//" +
           "//8BAf////8CAAAAFWCJCgIAAAAAAAIAAABJZAEC/zoALgBE/zoAAAAR/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABgAAAE51bWJlcgECATsALgBEATsAAAAH/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAExh" +
           "c3RUcmFuc2l0aW9uAQIDOwAvAQDPCgM7AAAAFf////8BAf////8DAAAAFWCJCgIAAAAAAAIAAABJZAEC" +
           "BDsALgBEBDsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAE51bWJlcgECBjsALgBEBjsAAAAH" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1lAQIHOwAuAEQHOwAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABEZWxldGFibGUBAgw7AC4ARAw7AAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAoAAABBdXRvRGVsZXRlAQINOwAuAEQNOwAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAMAAAAUmVjeWNsZUNvdW50AQIOOwAuAEQOOwAAAAb/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAATWF4SW5zdGFuY2VDb3VudAECEDsALgBEEDsAAAAH/////wEB/////wAAAAAEYYIKBAAAAAAABQAA" +
           "AFN0YXJ0AQI6OwAvAQB6CTo7AAABAQEAAAAANQEBAio7AAAAAARhggoEAAAAAAAHAAAAU3VzcGVuZAEC" +
           "OzsALwEAewk7OwAAAQEBAAAAADUBAQIwOwAAAAAEYYIKBAAAAAAABgAAAFJlc3VtZQECPDsALwEAfAk8" +
           "OwAAAQEBAAAAADUBAQIyOwAAAAAEYYIKBAAAAAAABAAAAEhhbHQBAj07AC8BAH0JPTsAAAEBAwAAAAA1" +
           "AQECLDsANQEBAjQ7ADUBAQI4OwAAAAAEYYIKBAAAAAAABQAAAFJlc2V0AQI+OwAvAQB+CT47AAABAQEA" +
           "AAAANQEBAig7AAAAAA==";
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

    #region GraspGripperSkillState Class
    #if (!OPCUA_EXCLUDE_GraspGripperSkillState)
    /// <summary>
    /// Stores an instance of the GraspGripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GraspGripperSkillState : GripperSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GraspGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.GraspGripperSkillType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIAKAQAAAAEADAAAAFBhcmFtZXRlclNldAECgzsALwA6gzsAAP////8B" +
           "AAAANWCJCgIAAAACAAUAAABGb3JjZQEChDsDAAAAABEAAABUaGUgZ3JpcHBlciBmb3JjZQAvAQBACYQ7" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQKIOwAuAESIOwAAAQB0A/////8B" +
           "Af////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAHQAAAEdyYXNwR3JpcHBlclNraWxsVHlwZUluc3RhbmNl" +
           "AQJAOwECQDtAOwAAAf////8MAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAkE7AC8BAMgKQTsA" +
           "AAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAAAElkAQJCOwAuAERCOwAAABH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAGAAAATnVtYmVyAQJEOwAuAEREOwAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAO" +
           "AAAATGFzdFRyYW5zaXRpb24BAkY7AC8BAM8KRjsAAAAV/////wEB/////wMAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQJHOwAuAERHOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAATnVtYmVyAQJJOwAuAERJ" +
           "OwAAAAf/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUBAko7AC4AREo7AAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAERlbGV0YWJsZQECTzsALgBETzsAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACgAAAEF1dG9EZWxldGUBAlA7AC4ARFA7AAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABSZWN5Y2xlQ291bnQBAlE7AC4ARFE7AAAABv////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABAAAABNYXhJbnN0YW5jZUNvdW50AQJTOwAuAERTOwAAAAf/////AQH/////AAAAAARhggoEAAAA" +
           "AAAFAAAAU3RhcnQBAn07AC8BAHoJfTsAAAEBAQAAAAA1AQECbTsAAAAABGGCCgQAAAAAAAcAAABTdXNw" +
           "ZW5kAQJ+OwAvAQB7CX47AAABAQEAAAAANQEBAnM7AAAAAARhggoEAAAAAAAGAAAAUmVzdW1lAQJ/OwAv" +
           "AQB8CX87AAABAQEAAAAANQEBAnU7AAAAAARhggoEAAAAAAAEAAAASGFsdAECgDsALwEAfQmAOwAAAQED" +
           "AAAAADUBAQJvOwA1AQECdzsANQEBAns7AAAAAARhggoEAAAAAAAFAAAAUmVzZXQBAoE7AC8BAH4JgTsA" +
           "AAEBAQAAAAA1AQECazsAAAAABGCACgEAAAABAAwAAABQYXJhbWV0ZXJTZXQBAoM7AC8AOoM7AAD/////" +
           "AQAAADVgiQoCAAAAAgAFAAAARm9yY2UBAoQ7AwAAAAARAAAAVGhlIGdyaXBwZXIgZm9yY2UALwEAQAmE" +
           "OwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQECiDsALgBEiDsAAAEAdAP/////" +
           "AQH/////AAAAAA==";
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

    #region ReleaseGripperSkillState Class
    #if (!OPCUA_EXCLUDE_ReleaseGripperSkillState)
    /// <summary>
    /// Stores an instance of the ReleaseGripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReleaseGripperSkillState : GripperSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReleaseGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.ReleaseGripperSkillType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIAKAQAAAAEADAAAAFBhcmFtZXRlclNldAECzTsALwA6zTsAAP////8B" +
           "AAAANWCJCgIAAAACAAUAAABGb3JjZQECzjsDAAAAABEAAABUaGUgZ3JpcHBlciBmb3JjZQAvAQBACc47" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQLSOwAuAETSOwAAAQB0A/////8B" +
           "Af////8AAAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAHwAAAFJlbGVhc2VHcmlwcGVyU2tpbGxUeXBlSW5zdGFu" +
           "Y2UBAoo7AQKKO4o7AAAB/////wwAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQECizsALwEAyAqL" +
           "OwAAABX/////AQH/////AgAAABVgiQoCAAAAAAACAAAASWQBAow7AC4ARIw7AAAAEf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAo47AC4ARI47AAAAB/////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AA4AAABMYXN0VHJhbnNpdGlvbgECkDsALwEAzwqQOwAAABX/////AQH/////AwAAABVgiQoCAAAAAAAC" +
           "AAAASWQBApE7AC4ARJE7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBApM7AC4A" +
           "RJM7AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQEClDsALgBElDsA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQKZOwAuAESZOwAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQECmjsALgBEmjsAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAADAAAAFJlY3ljbGVDb3VudAECmzsALgBEmzsAAAAG/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAAEAAAAE1heEluc3RhbmNlQ291bnQBAp07AC4ARJ07AAAAB/////8BAf////8AAAAABGGCCgQA" +
           "AAAAAAUAAABTdGFydAECxzsALwEAegnHOwAAAQEBAAAAADUBAQK3OwAAAAAEYYIKBAAAAAAABwAAAFN1" +
           "c3BlbmQBAsg7AC8BAHsJyDsAAAEBAQAAAAA1AQECvTsAAAAABGGCCgQAAAAAAAYAAABSZXN1bWUBAsk7" +
           "AC8BAHwJyTsAAAEBAQAAAAA1AQECvzsAAAAABGGCCgQAAAAAAAQAAABIYWx0AQLKOwAvAQB9Cco7AAAB" +
           "AQMAAAAANQEBArk7ADUBAQLBOwA1AQECxTsAAAAABGGCCgQAAAAAAAUAAABSZXNldAECyzsALwEAfgnL" +
           "OwAAAQEBAAAAADUBAQK1OwAAAAAEYIAKAQAAAAEADAAAAFBhcmFtZXRlclNldAECzTsALwA6zTsAAP//" +
           "//8BAAAANWCJCgIAAAACAAUAAABGb3JjZQECzjsDAAAAABEAAABUaGUgZ3JpcHBlciBmb3JjZQAvAQBA" +
           "Cc47AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQLSOwAuAETSOwAAAQB0A///" +
           "//8BAf////8AAAAA";
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

    #region MoveGripperSkillState Class
    #if (!OPCUA_EXCLUDE_MoveGripperSkillState)
    /// <summary>
    /// Stores an instance of the MoveGripperSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MoveGripperSkillState : GripperSkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MoveGripperSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.MoveGripperSkillType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAHAAAAE1vdmVHcmlwcGVyU2tpbGxUeXBlSW5zdGFuY2UB" +
           "AtQ7AQLUO9Q7AAAB/////wwAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEC1TsALwEAyArVOwAA" +
           "ABX/////AQH/////AgAAABVgiQoCAAAAAAACAAAASWQBAtY7AC4ARNY7AAAAEf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAYAAABOdW1iZXIBAtg7AC4ARNg7AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4A" +
           "AABMYXN0VHJhbnNpdGlvbgEC2jsALwEAzwraOwAAABX/////AQH/////AwAAABVgiQoCAAAAAAACAAAA" +
           "SWQBAts7AC4ARNs7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABOdW1iZXIBAt07AC4ARN07" +
           "AAAAB/////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9uVGltZQEC3jsALgBE3jsAAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARGVsZXRhYmxlAQLjOwAuAETjOwAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAKAAAAQXV0b0RlbGV0ZQEC5DsALgBE5DsAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAADAAAAFJlY3ljbGVDb3VudAEC5TsALgBE5TsAAAAG/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEAAAAE1heEluc3RhbmNlQ291bnQBAuc7AC4AROc7AAAAB/////8BAf////8AAAAABGGCCgQAAAAA" +
           "AAUAAABTdGFydAECETwALwEAegkRPAAAAQEBAAAAADUBAQIBPAAAAAAEYYIKBAAAAAAABwAAAFN1c3Bl" +
           "bmQBAhI8AC8BAHsJEjwAAAEBAQAAAAA1AQECBzwAAAAABGGCCgQAAAAAAAYAAABSZXN1bWUBAhM8AC8B" +
           "AHwJEzwAAAEBAQAAAAA1AQECCTwAAAAABGGCCgQAAAAAAAQAAABIYWx0AQIUPAAvAQB9CRQ8AAABAQMA" +
           "AAAANQEBAgM8ADUBAQILPAA1AQECDzwAAAAABGGCCgQAAAAAAAUAAABSZXNldAECFTwALwEAfgkVPAAA" +
           "AQEBAAAAADUBAQL/OwAAAAAEYIAKAQAAAAEADAAAAFBhcmFtZXRlclNldAECFzwALwA6FzwAAP////8C" +
           "AAAANWCJCgIAAAACAAUAAABXaWR0aAECGDwDAAAAABEAAABUaGUgZ3JpcHBlciB3aWR0aAAvAQBACRg8" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQIcPAAuAEQcPAAAAQB0A/////8B" +
           "Af////8AAAAANWCJCgIAAAACAAUAAABGb3JjZQECHjwDAAAAABEAAABUaGUgZ3JpcHBlciBmb3JjZQAv" +
           "AQBACR48AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQIiPAAuAEQiPAAAAQB0" +
           "A/////8BAf////8AAAAA";
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

    #region ISkillControllerState Class
    #if (!OPCUA_EXCLUDE_ISkillControllerState)
    /// <summary>
    /// Stores an instance of the ISkillControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISkillControllerState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISkillControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.ISkillControllerType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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

            if (Name != null)
            {
                Name.Initialize(context, Name_InitializationString);
            }
        }

        #region Initialization String
        private const string Name_InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8VYIkKAgAAAAIABAAAAE5hbWUBAiU8AC4ARCU8AAAAFf////8BAf////8A" +
           "AAAA";

        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAHAAAAElTa2lsbENvbnRyb2xsZXJUeXBlSW5zdGFuY2UB" +
           "AiQ8AQIkPCQ8AAAB/////wIAAAAVYIkKAgAAAAIABAAAAE5hbWUBAiU8AC4ARCU8AAAAFf////8BAf//" +
           "//8AAAAAJGCACgEAAAACAAYAAABTa2lsbHMBAiY8AwAAAAAkAAAAQ29udGFpbnMgdGhlIHNraWxscyBv" +
           "ZiB0aGUgQ29tcG9uZW50AC8AOiY8AAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<LocalizedText> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public BaseObjectState Skills
        {
            get
            {
                return m_skills;
            }

            set
            {
                if (!Object.ReferenceEquals(m_skills, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_skills = value;
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
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_skills != null)
            {
                children.Add(m_skills);
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
                case fortiss_Device.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Name = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case fortiss_Device.BrowseNames.Skills:
                {
                    if (createOrReplace)
                    {
                        if (Skills == null)
                        {
                            if (replacement == null)
                            {
                                Skills = new BaseObjectState(this);
                            }
                            else
                            {
                                Skills = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Skills;
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
        private PropertyState<LocalizedText> m_name;
        private BaseObjectState m_skills;
        #endregion
    }
    #endif
    #endregion

    #region IPowerOffDeviceState Class
    #if (!OPCUA_EXCLUDE_IPowerOffDeviceState)
    /// <summary>
    /// Stores an instance of the IPowerOffDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IPowerOffDeviceState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IPowerOffDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.IPowerOffDeviceType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAGwAAAElQb3dlck9mZkRldmljZVR5cGVJbnN0YW5jZQEC" +
           "TDwBAkw8TDwAAAH/////AQAAAARhggoEAAAAAgAOAAAAUG93ZXJPZmZEZXZpY2UBAk08AC8BAk08TTwA" +
           "AAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQJOPAAuAEROPAAAlgEAAAABACoB" +
           "ARYAAAAHAAAARGVsYXlNcwAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PowerOffDeviceMethodState PowerOffDevice
        {
            get
            {
                return m_powerOffDeviceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_powerOffDeviceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerOffDeviceMethod = value;
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
            if (m_powerOffDeviceMethod != null)
            {
                children.Add(m_powerOffDeviceMethod);
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
                case fortiss_Device.BrowseNames.PowerOffDevice:
                {
                    if (createOrReplace)
                    {
                        if (PowerOffDevice == null)
                        {
                            if (replacement == null)
                            {
                                PowerOffDevice = new PowerOffDeviceMethodState(this);
                            }
                            else
                            {
                                PowerOffDevice = (PowerOffDeviceMethodState)replacement;
                            }
                        }
                    }

                    instance = PowerOffDevice;
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
        private PowerOffDeviceMethodState m_powerOffDeviceMethod;
        #endregion
    }
    #endif
    #endregion

    #region PowerOffDeviceMethodState Class
    #if (!OPCUA_EXCLUDE_PowerOffDeviceMethodState)
    /// <summary>
    /// Stores an instance of the PowerOffDeviceMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerOffDeviceMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PowerOffDeviceMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new PowerOffDeviceMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYYIKBAAAAAIAGAAAAFBvd2VyT2ZmRGV2aWNlTWV0aG9kVHlwZQECTzwA" +
           "LwECTzxPPAAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAlA8AC4ARFA8AACW" +
           "AQAAAAEAKgEBFgAAAAcAAABEZWxheU1zAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public PowerOffDeviceMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            uint delayMs = (uint)_inputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    delayMs);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult PowerOffDeviceMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        uint delayMs);
    #endif
    #endregion

    #region GripPointState Class
    #if (!OPCUA_EXCLUDE_GripPointState)
    /// <summary>
    /// Stores an instance of the GripPoint ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GripPointState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GripPointState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.GripPoint, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIACAQAAAAIAEQAAAEdyaXBQb2ludEluc3RhbmNlAQJTPAECUzxTPAAA" +
           "/////wIAAAA1YIkKAgAAAAIABAAAAFR5cGUBAlQ8AwAAAAANAAAAR3JpcHBpbmcgdHlwZQAvAD9UPAAA" +
           "AQJRPP////8BAf////8AAAAANWCJCgIAAAACAAYAAABPZmZzZXQBAlU8AwAAAAA1AAAAT2Zmc2V0IHRv" +
           "IHRoZSBncmlwcGluZyBwb2ludCBmcm9tIHRoZSB0b29sIGJhc2UgZnJhbWUALwEAZ0lVPAAAAQB+Sf//" +
           "//8BAf////8CAAAAFWCJCgIAAAAAABQAAABDYXJ0ZXNpYW5Db29yZGluYXRlcwECVjwALwEAVklWPAAA" +
           "AQB6Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABYAQJdPAAvAD9dPAAAAAv/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAABAAAAWQECXjwALwA/XjwAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAAAQAAAFoB" +
           "Al88AC8AP188AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABPcmllbnRhdGlvbgECWDwALwEA" +
           "XUlYPAAAAQB8Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABBAQJgPAAvAD9gPAAAAAv/////AQH/" +
           "////AAAAABVgiQoCAAAAAAABAAAAQgECYTwALwA/YTwAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "AQAAAEMBAmI8AC8AP2I8AAAAC/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<GripTypeEnumeration> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <remarks />
        public ThreeDFrameState Offset
        {
            get
            {
                return m_offset;
            }

            set
            {
                if (!Object.ReferenceEquals(m_offset, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_offset = value;
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
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_offset != null)
            {
                children.Add(m_offset);
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
                case fortiss_Device.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new BaseDataVariableState<GripTypeEnumeration>(this);
                            }
                            else
                            {
                                Type = (BaseDataVariableState<GripTypeEnumeration>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case fortiss_Device.BrowseNames.Offset:
                {
                    if (createOrReplace)
                    {
                        if (Offset == null)
                        {
                            if (replacement == null)
                            {
                                Offset = new ThreeDFrameState(this);
                            }
                            else
                            {
                                Offset = (ThreeDFrameState)replacement;
                            }
                        }
                    }

                    instance = Offset;
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
        private BaseDataVariableState<GripTypeEnumeration> m_type;
        private ThreeDFrameState m_offset;
        #endregion
    }
    #endif
    #endregion

    #region VacuumGripPointState Class
    #if (!OPCUA_EXCLUDE_VacuumGripPointState)
    /// <summary>
    /// Stores an instance of the VacuumGripPoint ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VacuumGripPointState : GripPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VacuumGripPointState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.VacuumGripPoint, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIACAQAAAAIAFwAAAFZhY3V1bUdyaXBQb2ludEluc3RhbmNlAQJjPAEC" +
           "YzxjPAAA/////wIAAAA1YKkKAgAAAAIABAAAAFR5cGUBAmQ8AwAAAAANAAAAR3JpcHBpbmcgdHlwZQAv" +
           "AD9kPAAABQEAAQJRPP////8BAf////8AAAAANWCJCgIAAAACAAYAAABPZmZzZXQBAmU8AwAAAAA1AAAA" +
           "T2Zmc2V0IHRvIHRoZSBncmlwcGluZyBwb2ludCBmcm9tIHRoZSB0b29sIGJhc2UgZnJhbWUALwEAZ0ll" +
           "PAAAAQB+Sf////8BAf////8CAAAAFWCJCgIAAAAAABQAAABDYXJ0ZXNpYW5Db29yZGluYXRlcwECZjwA" +
           "LwEAVklmPAAAAQB6Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABYAQJtPAAvAD9tPAAAAAv/////" +
           "AQH/////AAAAABVgiQoCAAAAAAABAAAAWQECbjwALwA/bjwAAAAL/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAAQAAAFoBAm88AC8AP288AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABPcmllbnRhdGlv" +
           "bgECaDwALwEAXUloPAAAAQB8Sf////8BAf////8DAAAAFWCJCgIAAAAAAAEAAABBAQJwPAAvAD9wPAAA" +
           "AAv/////AQH/////AAAAABVgiQoCAAAAAAABAAAAQgECcTwALwA/cTwAAAAL/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAAQAAAEMBAnI8AC8AP3I8AAAAC/////8BAf////8AAAAA";
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

    #region ParallelGripPointState Class
    #if (!OPCUA_EXCLUDE_ParallelGripPointState)
    /// <summary>
    /// Stores an instance of the ParallelGripPoint ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ParallelGripPointState : GripPointState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ParallelGripPointState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.ParallelGripPoint, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIACAQAAAAIAGQAAAFBhcmFsbGVsR3JpcFBvaW50SW5zdGFuY2UBAnM8" +
           "AQJzPHM8AAD/////AwAAADVgqQoCAAAAAgAEAAAAVHlwZQECdDwDAAAAAA0AAABHcmlwcGluZyB0eXBl" +
           "AC8AP3Q8AAAFAAABAlE8/////wEB/////wAAAAA1YIkKAgAAAAIABgAAAE9mZnNldAECdTwDAAAAADUA" +
           "AABPZmZzZXQgdG8gdGhlIGdyaXBwaW5nIHBvaW50IGZyb20gdGhlIHRvb2wgYmFzZSBmcmFtZQAvAQBn" +
           "SXU8AAABAH5J/////wEB/////wIAAAAVYIkKAgAAAAAAFAAAAENhcnRlc2lhbkNvb3JkaW5hdGVzAQJ2" +
           "PAAvAQBWSXY8AAABAHpJ/////wEB/////wMAAAAVYIkKAgAAAAAAAQAAAFgBAn08AC8AP308AAAAC///" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAEAAABZAQJ+PAAvAD9+PAAAAAv/////AQH/////AAAAABVgiQoC" +
           "AAAAAAABAAAAWgECfzwALwA/fzwAAAAL/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAE9yaWVudGF0" +
           "aW9uAQJ4PAAvAQBdSXg8AAABAHxJ/////wEB/////wMAAAAVYIkKAgAAAAAAAQAAAEEBAoA8AC8AP4A8" +
           "AAAAC/////8BAf////8AAAAAFWCJCgIAAAAAAAEAAABCAQKBPAAvAD+BPAAAAAv/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAABAAAAQwECgjwALwA/gjwAAAAL/////wEB/////wAAAAAVYIkKAgAAAAIABQAAAFJh" +
           "bmdlAQKDPAAvAD+DPAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<Range> Range
        {
            get
            {
                return m_range;
            }

            set
            {
                if (!Object.ReferenceEquals(m_range, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_range = value;
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
            if (m_range != null)
            {
                children.Add(m_range);
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
                case fortiss_Device.BrowseNames.Range:
                {
                    if (createOrReplace)
                    {
                        if (Range == null)
                        {
                            if (replacement == null)
                            {
                                Range = new BaseDataVariableState<Range>(this);
                            }
                            else
                            {
                                Range = (BaseDataVariableState<Range>)replacement;
                            }
                        }
                    }

                    instance = Range;
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
        private BaseDataVariableState<Range> m_range;
        #endregion
    }
    #endif
    #endregion

    #region IGripperState Class
    #if (!OPCUA_EXCLUDE_IGripperState)
    /// <summary>
    /// Stores an instance of the IGripperType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IGripperState : BaseInterfaceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public IGripperState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.IGripperType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAFAAAAElHcmlwcGVyVHlwZUluc3RhbmNlAQKEPAEChDyE" +
           "PAAAAf////8BAAAAJGCACgEAAAACAAoAAABHcmlwUG9pbnRzAQKFPAMAAAAAJQAAAENvbnRhaW5zIHRo" +
           "ZSBwb3NzaWJsZSBncmlwcGluZyBwb2ludHMALwA6hTwAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState GripPoints
        {
            get
            {
                return m_gripPoints;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gripPoints, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gripPoints = value;
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
            if (m_gripPoints != null)
            {
                children.Add(m_gripPoints);
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
                case fortiss_Device.BrowseNames.GripPoints:
                {
                    if (createOrReplace)
                    {
                        if (GripPoints == null)
                        {
                            if (replacement == null)
                            {
                                GripPoints = new BaseObjectState(this);
                            }
                            else
                            {
                                GripPoints = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = GripPoints;
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
        private BaseObjectState m_gripPoints;
        #endregion
    }
    #endif
    #endregion

    #region SensorState Class
    #if (!OPCUA_EXCLUDE_SensorState)
    /// <summary>
    /// Stores an instance of the SensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SensorState : ComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.SensorType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIACAQAAAAIAEgAAAFNlbnNvclR5cGVJbnN0YW5jZQECljwBApY8ljwA" +
           "AP////8AAAAA";
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

    #region ForceTorqueSensorState Class
    #if (!OPCUA_EXCLUDE_ForceTorqueSensorState)
    /// <summary>
    /// Stores an instance of the ForceTorqueSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ForceTorqueSensorState : SensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ForceTorqueSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.ForceTorqueSensorType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////+EYIACAQAAAAIAHQAAAEZvcmNlVG9ycXVlU2Vuc29yVHlwZUluc3RhbmNl" +
           "AQK7PAECuzy7PAAAAf////8CAAAAJGCACgEAAAACAAsAAABGb3JjZVNlbnNvcgEC4DwDAAAAADcAAABP" +
           "ZmZlcnMgaW5mb3JtYXRpb24gYWJvdXQgZm9yY2UgZXhwZXJpZW5jZWQgYnkgdGhlIHJvYm90AC8BApY8" +
           "4DwAAP////8BAAAAN2CJCgIAAAACAAUAAABGb3JjZQECAz0DAAAAACQAAABUaGUgY3VycmVudCBmb3Jj" +
           "ZXMgaW4gWCBZIGFuZCBaIGluIE4ALwEAQAkDPQAAAAsBAAAAAQAAAAAAAAADA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQIHPQAuAEQHPQAAAQB0A/////8BAf////8AAAAAJGCACgEAAAACAAwAAABU" +
           "b3JxdWVTZW5zb3IBAgk9AwAAAAA5AAAAT2ZmZXJzIGluZm9ybWF0aW9uIGFib3V0IHRvcnF1ZSBleHBl" +
           "cmllbmNlZCBieSB0aGUgc2Vuc29yAC8BApY8CT0AAP////8BAAAAN2CJCgIAAAACAAYAAABUb3JxdWUB" +
           "Aiw9AwAAAAAdAAAAVGhlIHRvcnF1ZSBpbiBYIFkgYW5kIFogaW4gTm0ALwEAQAksPQAAAAsBAAAAAQAA" +
           "AAAAAAADA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQIwPQAuAEQwPQAAAQB0A/////8BAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SensorState ForceSensor
        {
            get
            {
                return m_forceSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_forceSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_forceSensor = value;
            }
        }

        /// <remarks />
        public SensorState TorqueSensor
        {
            get
            {
                return m_torqueSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_torqueSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_torqueSensor = value;
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
            if (m_forceSensor != null)
            {
                children.Add(m_forceSensor);
            }

            if (m_torqueSensor != null)
            {
                children.Add(m_torqueSensor);
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
                case fortiss_Device.BrowseNames.ForceSensor:
                {
                    if (createOrReplace)
                    {
                        if (ForceSensor == null)
                        {
                            if (replacement == null)
                            {
                                ForceSensor = new SensorState(this);
                            }
                            else
                            {
                                ForceSensor = (SensorState)replacement;
                            }
                        }
                    }

                    instance = ForceSensor;
                    break;
                }

                case fortiss_Device.BrowseNames.TorqueSensor:
                {
                    if (createOrReplace)
                    {
                        if (TorqueSensor == null)
                        {
                            if (replacement == null)
                            {
                                TorqueSensor = new SensorState(this);
                            }
                            else
                            {
                                TorqueSensor = (SensorState)replacement;
                            }
                        }
                    }

                    instance = TorqueSensor;
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
        private SensorState m_forceSensor;
        private SensorState m_torqueSensor;
        #endregion
    }
    #endif
    #endregion

    #region SkillTransitionEventState Class
    #if (!OPCUA_EXCLUDE_SkillTransitionEventState)
    /// <summary>
    /// Stores an instance of the SkillTransitionEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillTransitionEventState : ProgramTransitionEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillTransitionEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(fortiss_Device.ObjectTypes.SkillTransitionEventType, fortiss_Device.Namespaces.fortissDevice, namespaceUris);
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
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHgAAAGh0dHBzOi8vZm9ydGlzcy5v" +
           "cmcvVUEvRGV2aWNlL/////8EYIACAQAAAAIAIAAAAFNraWxsVHJhbnNpdGlvbkV2ZW50VHlwZUluc3Rh" +
           "bmNlAQIyPQECMj0yPQAA/////wwAAAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAjM9AC4ARDM9AAAAD///" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAjQ9AC4ARDQ9AAAAEf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQI1PQAuAEQ1PQAAABH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAKAAAAU291cmNlTmFtZQECNj0ALgBENj0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAA" +
           "AFRpbWUBAjc9AC4ARDc9AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQI4PQAuAEQ4PQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQI6PQAuAEQ6" +
           "PQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAjs9AC4ARDs9AAAABf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAoAAABUcmFuc2l0aW9uAQI8PQAvAQDKCjw9AAAAFf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAIAAABJZAECPT0ALgBEPT0AAAAY/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEZyb21TdGF0ZQECQj0ALwEAwwpCPQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAkM9" +
           "AC4AREM9AAAAGP////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABUb1N0YXRlAQJHPQAvAQDDCkc9AAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAECSD0ALgBESD0AAAAY/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEgAAAEludGVybWVkaWF0ZVJlc3VsdAECTD0ALwA/TD0AAAAY/////wEB/////wAAAAA=";
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