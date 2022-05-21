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