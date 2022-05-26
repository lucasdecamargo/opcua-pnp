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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;

namespace fortiss_Device
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Open = 15015;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Close = 15018;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Read = 15020;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Write = 15023;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition = 15025;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition = 15028;

        /// <summary>
        /// The identifier for the SkillType_Start Method.
        /// </summary>
        public const uint SkillType_Start = 15095;

        /// <summary>
        /// The identifier for the SkillType_Suspend Method.
        /// </summary>
        public const uint SkillType_Suspend = 15096;

        /// <summary>
        /// The identifier for the SkillType_Resume Method.
        /// </summary>
        public const uint SkillType_Resume = 15097;

        /// <summary>
        /// The identifier for the SkillType_Halt Method.
        /// </summary>
        public const uint SkillType_Halt = 15098;

        /// <summary>
        /// The identifier for the SkillType_Reset Method.
        /// </summary>
        public const uint SkillType_Reset = 15099;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halt Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Halt = 15431;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Reset Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Reset = 15432;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Resume Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Resume = 15433;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspend Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Suspend = 15434;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Start Method.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Start = 15435;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata Object.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata = 15001;

        /// <summary>
        /// The identifier for the SkillType_FinalResultData Object.
        /// </summary>
        public const uint SkillType_FinalResultData = 15068;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills Object.
        /// </summary>
        public const uint ISkillControllerType_Skills = 15398;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No_ Object.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No_ = 15399;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the SkillType ObjectType.
        /// </summary>
        public const uint SkillType = 15034;

        /// <summary>
        /// The identifier for the ISkillControllerType ObjectType.
        /// </summary>
        public const uint ISkillControllerType = 15396;

        /// <summary>
        /// The identifier for the SkillTransitionEventType ObjectType.
        /// </summary>
        public const uint SkillTransitionEventType = 15666;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceUri = 15002;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceVersion = 15003;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespacePublicationDate = 15004;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_IsNamespaceSubset = 15005;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_StaticNodeIdTypes = 15006;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_StaticNumericNodeIdRange = 15007;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_StaticStringNodeIdPattern = 15008;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Size = 15010;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Writable = 15011;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_UserWritable = 15012;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_OpenCount = 15013;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Open_InputArguments = 15016;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Open_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Close_InputArguments = 15019;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Read_InputArguments = 15021;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Read_OutputArguments = 15022;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_Write_InputArguments = 15024;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 15026;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 15027;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 15029;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_DefaultRolePermissions = 15031;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_DefaultUserRolePermissions = 15032;

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint FortissDeviceNamespaceMetadata_DefaultAccessRestrictions = 15033;

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Id Variable.
        /// </summary>
        public const uint SkillType_CurrentState_Id = 15036;

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Number Variable.
        /// </summary>
        public const uint SkillType_CurrentState_Number = 15038;

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Id Variable.
        /// </summary>
        public const uint SkillType_LastTransition_Id = 15041;

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Number Variable.
        /// </summary>
        public const uint SkillType_LastTransition_Number = 15043;

        /// <summary>
        /// The identifier for the SkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint SkillType_LastTransition_TransitionTime = 15044;

        /// <summary>
        /// The identifier for the SkillType_MaxInstanceCount Variable.
        /// </summary>
        public const uint SkillType_MaxInstanceCount = 15053;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_CreateSessionId = 15056;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_CreateClientName = 15057;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_InvocationCreationTime = 15058;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastTransitionTime = 15059;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodCall = 15060;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodSessionId = 15061;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodInputArguments = 15062;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodOutputArguments = 15063;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodInputValues = 15064;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodOutputValues = 15065;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodCallTime = 15066;

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint SkillType_ProgramDiagnostic_LastMethodReturnStatus = 15067;

        /// <summary>
        /// The identifier for the SkillType_Halted_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Halted_StateNumber = 15070;

        /// <summary>
        /// The identifier for the SkillType_Ready_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Ready_StateNumber = 15072;

        /// <summary>
        /// The identifier for the SkillType_Running_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Running_StateNumber = 15074;

        /// <summary>
        /// The identifier for the SkillType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint SkillType_Suspended_StateNumber = 15076;

        /// <summary>
        /// The identifier for the SkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_HaltedToReady_TransitionNumber = 15078;

        /// <summary>
        /// The identifier for the SkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_ReadyToRunning_TransitionNumber = 15080;

        /// <summary>
        /// The identifier for the SkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_RunningToHalted_TransitionNumber = 15082;

        /// <summary>
        /// The identifier for the SkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_RunningToReady_TransitionNumber = 15084;

        /// <summary>
        /// The identifier for the SkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_RunningToSuspended_TransitionNumber = 15086;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_SuspendedToRunning_TransitionNumber = 15088;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_SuspendedToHalted_TransitionNumber = 15090;

        /// <summary>
        /// The identifier for the SkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_SuspendedToReady_TransitionNumber = 15092;

        /// <summary>
        /// The identifier for the SkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_ReadyToHalted_TransitionNumber = 15094;

        /// <summary>
        /// The identifier for the SkillType_Name Variable.
        /// </summary>
        public const uint SkillType_Name = 15100;

        /// <summary>
        /// The identifier for the ISkillControllerType_Name Variable.
        /// </summary>
        public const uint ISkillControllerType_Name = 15397;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__CurrentState = 15400;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Id Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__CurrentState_Id = 15401;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Number Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__CurrentState_Number = 15403;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition = 15405;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Id Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition_Id = 15406;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Number Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition_Number = 15408;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime = 15409;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Deletable Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__Deletable = 15413;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__AutoDelete Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__AutoDelete = 15414;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RecycleCount Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__RecycleCount = 15415;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId = 15417;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName = 15418;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime = 15419;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime = 15420;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall = 15421;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId = 15422;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments = 15423;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments = 15424;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues = 15425;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues = 15426;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime = 15427;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus = 15428;

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__MaxInstanceCount Variable.
        /// </summary>
        public const uint ISkillControllerType_Skills_Skill__No__MaxInstanceCount = 15430;

        /// <summary>
        /// The identifier for the SkillTransitionEventType_Transition_Id Variable.
        /// </summary>
        public const uint SkillTransitionEventType_Transition_Id = 15677;

        /// <summary>
        /// The identifier for the SkillTransitionEventType_FromState_Id Variable.
        /// </summary>
        public const uint SkillTransitionEventType_FromState_Id = 15683;

        /// <summary>
        /// The identifier for the SkillTransitionEventType_ToState_Id Variable.
        /// </summary>
        public const uint SkillTransitionEventType_ToState_Id = 15688;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(fortiss_Device.Methods.FortissDeviceNamespaceMetadata_NamespaceFile_Open, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(fortiss_Device.Methods.FortissDeviceNamespaceMetadata_NamespaceFile_Close, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(fortiss_Device.Methods.FortissDeviceNamespaceMetadata_NamespaceFile_Read, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(fortiss_Device.Methods.FortissDeviceNamespaceMetadata_NamespaceFile_Write, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(fortiss_Device.Methods.FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(fortiss_Device.Methods.FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Start = new ExpandedNodeId(fortiss_Device.Methods.SkillType_Start, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Suspend = new ExpandedNodeId(fortiss_Device.Methods.SkillType_Suspend, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Resume = new ExpandedNodeId(fortiss_Device.Methods.SkillType_Resume, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Halt = new ExpandedNodeId(fortiss_Device.Methods.SkillType_Halt, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Reset = new ExpandedNodeId(fortiss_Device.Methods.SkillType_Reset, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Halt = new ExpandedNodeId(fortiss_Device.Methods.ISkillControllerType_Skills_Skill__No__Halt, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Reset = new ExpandedNodeId(fortiss_Device.Methods.ISkillControllerType_Skills_Skill__No__Reset, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Resume = new ExpandedNodeId(fortiss_Device.Methods.ISkillControllerType_Skills_Skill__No__Resume, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Suspend = new ExpandedNodeId(fortiss_Device.Methods.ISkillControllerType_Skills_Skill__No__Suspend, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Start Method.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Start = new ExpandedNodeId(fortiss_Device.Methods.ISkillControllerType_Skills_Skill__No__Start, fortiss_Device.Namespaces.fortissDevice);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata = new ExpandedNodeId(fortiss_Device.Objects.FortissDeviceNamespaceMetadata, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_FinalResultData Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_FinalResultData = new ExpandedNodeId(fortiss_Device.Objects.SkillType_FinalResultData, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills = new ExpandedNodeId(fortiss_Device.Objects.ISkillControllerType_Skills, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No_ Object.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No_ = new ExpandedNodeId(fortiss_Device.Objects.ISkillControllerType_Skills_Skill__No_, fortiss_Device.Namespaces.fortissDevice);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the SkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillType = new ExpandedNodeId(fortiss_Device.ObjectTypes.SkillType, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType = new ExpandedNodeId(fortiss_Device.ObjectTypes.ISkillControllerType, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillTransitionEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType = new ExpandedNodeId(fortiss_Device.ObjectTypes.SkillTransitionEventType, fortiss_Device.Namespaces.fortissDevice);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceUri = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceUri, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceVersion = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceVersion, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespacePublicationDate, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_IsNamespaceSubset, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_StaticNodeIdTypes, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_StaticNumericNodeIdRange, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_StaticStringNodeIdPattern, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Size, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Writable, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_UserWritable, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_OpenCount, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Open_InputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Open_OutputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Close_InputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Read_InputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Read_OutputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_Write_InputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_InputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_NamespaceFile_SetPosition_InputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_DefaultRolePermissions, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_DefaultUserRolePermissions, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the FortissDeviceNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId FortissDeviceNamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(fortiss_Device.Variables.FortissDeviceNamespaceMetadata_DefaultAccessRestrictions, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_CurrentState_Id = new ExpandedNodeId(fortiss_Device.Variables.SkillType_CurrentState_Id, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_CurrentState_Number = new ExpandedNodeId(fortiss_Device.Variables.SkillType_CurrentState_Number, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_LastTransition_Id = new ExpandedNodeId(fortiss_Device.Variables.SkillType_LastTransition_Id, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_LastTransition_Number = new ExpandedNodeId(fortiss_Device.Variables.SkillType_LastTransition_Number, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_LastTransition_TransitionTime = new ExpandedNodeId(fortiss_Device.Variables.SkillType_LastTransition_TransitionTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_MaxInstanceCount = new ExpandedNodeId(fortiss_Device.Variables.SkillType_MaxInstanceCount, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_CreateSessionId, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_CreateClientName, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_InvocationCreationTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastTransitionTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodCall, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodSessionId, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodInputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodOutputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodInputValues, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodOutputValues, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodCallTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ProgramDiagnostic_LastMethodReturnStatus, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Halted_StateNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_Halted_StateNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Ready_StateNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_Ready_StateNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Running_StateNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_Running_StateNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Suspended_StateNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_Suspended_StateNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_HaltedToReady_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_HaltedToReady_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ReadyToRunning_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToHalted_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_RunningToHalted_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToReady_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_RunningToReady_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_RunningToSuspended_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_SuspendedToRunning_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_SuspendedToHalted_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_SuspendedToReady_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(fortiss_Device.Variables.SkillType_ReadyToHalted_TransitionNumber, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Name = new ExpandedNodeId(fortiss_Device.Variables.SkillType_Name, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Name = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Name, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__CurrentState = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__CurrentState, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__CurrentState_Id = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__CurrentState_Id, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__CurrentState_Number = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__CurrentState_Number, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__LastTransition, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition_Id = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__LastTransition_Id, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition_Number = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__LastTransition_Number, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__LastTransition_TransitionTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__Deletable = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__Deletable, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__AutoDelete = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__AutoDelete, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__RecycleCount = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__RecycleCount, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateSessionId, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_CreateClientName, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_InvocationCreationTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastTransitionTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCall, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodSessionId, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputArguments, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodInputValues, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodOutputValues, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodCallTime, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__ProgramDiagnostic_LastMethodReturnStatus, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the ISkillControllerType_Skills_Skill__No__MaxInstanceCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISkillControllerType_Skills_Skill__No__MaxInstanceCount = new ExpandedNodeId(fortiss_Device.Variables.ISkillControllerType_Skills_Skill__No__MaxInstanceCount, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillTransitionEventType_Transition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType_Transition_Id = new ExpandedNodeId(fortiss_Device.Variables.SkillTransitionEventType_Transition_Id, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillTransitionEventType_FromState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType_FromState_Id = new ExpandedNodeId(fortiss_Device.Variables.SkillTransitionEventType_FromState_Id, fortiss_Device.Namespaces.fortissDevice);

        /// <summary>
        /// The identifier for the SkillTransitionEventType_ToState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillTransitionEventType_ToState_Id = new ExpandedNodeId(fortiss_Device.Variables.SkillTransitionEventType_ToState_Id, fortiss_Device.Namespaces.fortissDevice);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the FortissDeviceNamespaceMetadata component.
        /// </summary>
        public const string FortissDeviceNamespaceMetadata = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The BrowseName for the ISkillControllerType component.
        /// </summary>
        public const string ISkillControllerType = "ISkillControllerType";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the Skills component.
        /// </summary>
        public const string Skills = "Skills";

        /// <summary>
        /// The BrowseName for the SkillTransitionEventType component.
        /// </summary>
        public const string SkillTransitionEventType = "SkillTransitionEventType";

        /// <summary>
        /// The BrowseName for the SkillType component.
        /// </summary>
        public const string SkillType = "SkillType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the fortissDevice namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDevice = "https://fortiss.org/UA/Device/";

        /// <summary>
        /// The URI for the fortissDeviceXsd namespace (.NET code namespace is 'fortiss_Device').
        /// </summary>
        public const string fortissDeviceXsd = "https://fortiss.org/UA/Device/Types.xsd";
    }
    #endregion
}